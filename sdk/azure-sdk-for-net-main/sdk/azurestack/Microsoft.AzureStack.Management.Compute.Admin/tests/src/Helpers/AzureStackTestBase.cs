// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Net;
using Microsoft.Rest.Azure;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace Compute.Tests
{
    /// <summary>
    /// Base class for all AzureStack tests.  This class should not be modified but extended through a child class.
    /// </summary>
    ///
    public abstract class AzureStackTestBase<T> where T : class
    {

        /// <summary>
        /// Reference to service client.
        /// </summary>
        protected T client;
        
        /// <summary>
        /// Validate the client.
        /// </summary>
        /// <param name="client">The instantiated client we want to validate.</param>
        protected abstract void ValidateClient(T client);

        /// <summary>
        /// The default location for all admin actions.  Override in derived class as needed.
        /// </summary>
        protected string Location = "local";

        /// <summary>
        /// Run a test that accepts no arguments.  An exception can be 
        /// </summary>
        /// <param name="test">The test we wish to run.</param>
        /// <param name="before">Function to execute before your test has completed.</param>
        /// <param name="after">Function to execute after your test has completed.</param>
        /// <param name="status">Expected returned HttpStatusCode.</param>
        /// <exception cref="System.Exception">Thrown when an unexpected exception occurs.</exception>  
        ///
        protected void RunTest(Action<T> test,
            Action before = null,
            Action after = null,
            HttpStatusCode status = HttpStatusCode.OK,
            [System.Runtime.CompilerServices.CallerMemberName]
            string methodName= "testframework_failed") {

            Exception caught = null;

            try
            {
                var handler = new RecordedDelegatingHandler { StatusCodeToReturn = status };
                handler.IsPassThrough = true;

                using (MockContext context = MockContext.Start(typeof(T).Name, methodName))
                {
                    var client = context.GetServiceClient<T>(handlers: handler);
                    ValidateClient(client);

                    before?.Invoke();
                    test(client);
                    after?.Invoke();
                }
            }
            catch (Exception ex)
            {
                caught = ex;
            }
            finally
            {
                if (caught != null)
                {
                    throw new Exception("Test failed", caught);
                }
            }
        }

        public void IgnoreExceptions(Action action) {
            try { action.Invoke(); }
            catch (Exception) { }
        }

        public void ValidateExpectedReturnCode(Action action, HttpStatusCode httpResponseCode)
        {
            Assert.Throws<CloudException>(() =>
            {
                try
                {
                    action.Invoke();
                }
                catch (CloudException ex)
                {
                    if (ex.Response.StatusCode == httpResponseCode)
                    {
                        // Expected exception received.
                        throw;
                    }
                    else
                    {
                        throw new Exception($"Test failed: CloudException with wrong StatusCode {ex.Response.StatusCode}.");
                    }
                }
            });
        }
    }
}
