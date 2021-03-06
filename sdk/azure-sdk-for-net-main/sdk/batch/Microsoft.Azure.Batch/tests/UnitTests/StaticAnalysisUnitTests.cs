// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

´╗┐namespace Azure.Batch.Unit.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using BatchTestCommon;
    using TestUtilities;
    using Xunit;
    using Xunit.Abstractions;

    public class StaticAnalysisUnitTests
    {
        private readonly string sourceLocation;
        private readonly string proxySourceLocation;

        private const string SourceFileType = @".*\.cs";
        private readonly ITestOutputHelper testOutputHelper;

        private const string GeneratedProtocolFolder = "GeneratedProtocol";

        public StaticAnalysisUnitTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;

            this.sourceLocation = GetSourceDirectory();
            this.proxySourceLocation = Path.Combine(this.sourceLocation, GeneratedProtocolFolder);
        }

        private string GetSourceDirectory([System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "")
        {
            System.Console.WriteLine($"SFP2: {sourceFilePath}");
            return Path.Combine(Path.GetDirectoryName(sourceFilePath), "..", "..", "src");
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void ExceptionsThrownDirectlyByRestProxyDontChange()
        {
            const string exceptionNameCaptureGroup = "ExceptionName";
            string pattern = GetExceptionCaptureRegex(exceptionNameCaptureGroup);

            SourceParser sourceParser = new SourceParser(this.proxySourceLocation, SourceFileType, null, pattern);

            List<SourceParserResult> results = sourceParser.Parse().ToList();

            //Ensure we've scanned at least some files...
            const int expectedExceptionCount = 100;
            this.testOutputHelper.WriteLine("Found {0} \"throw new Exception\" strings", results.Count);
            Assert.True(results.Count > expectedExceptionCount);

            HashSet<string> exceptionSet = new HashSet<string>();

            foreach (SourceParserResult parserResult in results)
            {
                string exceptionName = parserResult.Match.Groups[exceptionNameCaptureGroup].Value;
                exceptionSet.Add(exceptionName);
            }

            this.testOutputHelper.WriteLine("Found {0} types of exception thrown by rest proxy", exceptionSet.Count);
            this.testOutputHelper.WriteLine("Exceptions:");
            this.testOutputHelper.WriteLine("------------------------");
            foreach (string exceptionType in exceptionSet)
            {
                this.testOutputHelper.WriteLine("{0}", exceptionType);
            }

            IEnumerable<string> expectedExceptions = new List<string>()
            {
                "ArgumentNullException",
                "ValidationException",
                "SerializationException"
            };

            Assert.Equal(expectedExceptions, exceptionSet);
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void ExceptionsThrownDirectlyByObjectModelDontChange()
        {
            const string exceptionNameCaptureGroup = "ExceptionName";
            string pattern = GetExceptionCaptureRegex(exceptionNameCaptureGroup);

            SourceParser sourceParser = new SourceParser(this.sourceLocation, SourceFileType, GeneratedProtocolFolder, pattern);

            List<SourceParserResult> results = sourceParser.Parse().ToList();

            //Ensure we've scanned at least some files...
            const int expectedExceptionCount = 50;
            this.testOutputHelper.WriteLine("Found {0} \"throw new Exception\" strings", results.Count);
            Assert.True(results.Count > expectedExceptionCount);

            HashSet<string> exceptionSet = new HashSet<string>();

            foreach (SourceParserResult parserResult in results)
            {
                string exceptionName = parserResult.Match.Groups[exceptionNameCaptureGroup].Value;
                exceptionSet.Add(exceptionName);
            }

            this.testOutputHelper.WriteLine("Found {0} types of exception thrown by object model", exceptionSet.Count);
            this.testOutputHelper.WriteLine("Exceptions:");
            this.testOutputHelper.WriteLine("------------------------");
            foreach (string exceptionType in exceptionSet)
            {
                this.testOutputHelper.WriteLine("{0}", exceptionType);
            }

            var expectedExceptions = new HashSet<string>
                 {
                     "ArgumentNullException",
                     "AddTaskCollectionTerminatedException",
                     "BatchClientException",
                     "RunOnceException",
                     "TimeoutException",
                     "ArgumentOutOfRangeException",
                     "InvalidOperationException",
                     "ArgumentException",
                     "ParallelOperationsException",
                 };

            Assert.Equal(expectedExceptions.OrderBy(e => e), exceptionSet.OrderBy(e => e));
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void DotWaitAndDotResultAreNeverUsed()
        {
            //TODO: We should use Roslyn to do this

            //What this expression means:
            //(?<!//.*?) -- Make sure that any await we find is not preceeded on the same line by //
            //(?s: -- means . will match newlines in this sub-expression.
            //\\.Wait\\(\\) -- matches .Wait()
            //(?<!this\\.?)\\.Result(\\.|;|\\s|,) -- matches .Result followed by a ., ;, whitespace, or , which is not prefixed immediately by "this."
            const string pattern = "(?<!//.*?)(?s:(\\.Wait\\(\\)|(?<!this\\.?)\\.Result(\\.|;|\\s|,)))";

            SourceParser sourceParser = new SourceParser(this.sourceLocation, SourceFileType, null, pattern);

            List<SourceParserResult> results = sourceParser.Parse().ToList();

            //There should be no .Result or .Wait() calls outside of the two which are expected below
            //Remove the two we expect
            results.Remove(results.First(r => r.File.Contains("UtilitiesInternal.cs")));
            results.Remove(results.First(r => r.File.Contains("SynchronousMethodExceptionBehavior.cs")));

            foreach (SourceParserResult parserResult in results)
            {
                this.testOutputHelper.WriteLine("Found .Wait or .Result in {0} at {1} -- {2}", parserResult.File, parserResult.LineNumber, parserResult.Match);
            }

            Assert.Empty(results);
        }

        #region Private helpers

        private static string GetExceptionCaptureRegex(string exceptionNameCaptureGroup)
        {
            //TODO: Note that this misses anything like "throw ex;" since it's missing the new -- we should try to  use
            //TODO: Roslyn or something else to do a better job of this.
            //What this expression means:
            //(?<!//.*?) - make sure any throw we find is not on a line which starts with //'s
            //(throw\\s+?new - find "throw new" with any number of whitespace characters seperating them (on the same line)
            //\\s+(?<{0}>\\w+?)\\( - find everything after the "new" in the previous part of the expression which is a
            //                       "word" character (alphanumeric), and comes before the next "(" character
            //                       and store it in the group named "ExceptionName"

            string pattern = string.Format("(?<!//.*?)(throw\\s+?new\\s+(\\w+\\.)*(?<{0}>\\w+?)\\()", exceptionNameCaptureGroup);

            return pattern;
        }

        #endregion
    }
}
