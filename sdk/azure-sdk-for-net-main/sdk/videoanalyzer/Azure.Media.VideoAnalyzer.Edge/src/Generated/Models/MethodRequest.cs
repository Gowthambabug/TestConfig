// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Base class for direct method calls. </summary>
    public partial class MethodRequest
    {
        /// <summary> Initializes a new instance of MethodRequest. </summary>
        public MethodRequest()
        {
            ApiVersion = "1.1";
        }

        /// <summary> Initializes a new instance of MethodRequest. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        internal MethodRequest(string methodName, string apiVersion)
        {
            MethodName = methodName;
            ApiVersion = apiVersion;
        }
        /// <summary> Video Analyzer API version. </summary>
        public string ApiVersion { get; set; }
    }
}