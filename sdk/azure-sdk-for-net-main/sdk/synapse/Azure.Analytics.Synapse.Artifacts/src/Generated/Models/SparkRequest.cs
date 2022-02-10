// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The SparkRequest. </summary>
    public partial class SparkRequest
    {
        /// <summary> Initializes a new instance of SparkRequest. </summary>
        internal SparkRequest()
        {
            Arguments = new ChangeTrackingList<string>();
            Jars = new ChangeTrackingList<string>();
            PythonFiles = new ChangeTrackingList<string>();
            Files = new ChangeTrackingList<string>();
            Archives = new ChangeTrackingList<string>();
            Configuration = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of SparkRequest. </summary>
        /// <param name="name"></param>
        /// <param name="file"></param>
        /// <param name="className"></param>
        /// <param name="arguments"></param>
        /// <param name="jars"></param>
        /// <param name="pythonFiles"></param>
        /// <param name="files"></param>
        /// <param name="archives"></param>
        /// <param name="configuration"> Dictionary of &lt;string&gt;. </param>
        /// <param name="driverMemory"></param>
        /// <param name="driverCores"></param>
        /// <param name="executorMemory"></param>
        /// <param name="executorCores"></param>
        /// <param name="executorCount"></param>
        internal SparkRequest(string name, string file, string className, IReadOnlyList<string> arguments, IReadOnlyList<string> jars, IReadOnlyList<string> pythonFiles, IReadOnlyList<string> files, IReadOnlyList<string> archives, IReadOnlyDictionary<string, string> configuration, string driverMemory, int? driverCores, string executorMemory, int? executorCores, int? executorCount)
        {
            Name = name;
            File = file;
            ClassName = className;
            Arguments = arguments;
            Jars = jars;
            PythonFiles = pythonFiles;
            Files = files;
            Archives = archives;
            Configuration = configuration;
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            ExecutorCount = executorCount;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the file. </summary>
        public string File { get; }
        /// <summary> Gets the class name. </summary>
        public string ClassName { get; }
        /// <summary> Gets the arguments. </summary>
        public IReadOnlyList<string> Arguments { get; }
        /// <summary> Gets the jars. </summary>
        public IReadOnlyList<string> Jars { get; }
        /// <summary> Gets the python files. </summary>
        public IReadOnlyList<string> PythonFiles { get; }
        /// <summary> Gets the files. </summary>
        public IReadOnlyList<string> Files { get; }
        /// <summary> Gets the archives. </summary>
        public IReadOnlyList<string> Archives { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Configuration { get; }
        /// <summary> Gets the driver memory. </summary>
        public string DriverMemory { get; }
        /// <summary> Gets the driver cores. </summary>
        public int? DriverCores { get; }
        /// <summary> Gets the executor memory. </summary>
        public string ExecutorMemory { get; }
        /// <summary> Gets the executor cores. </summary>
        public int? ExecutorCores { get; }
        /// <summary> Gets the executor count. </summary>
        public int? ExecutorCount { get; }
    }
}