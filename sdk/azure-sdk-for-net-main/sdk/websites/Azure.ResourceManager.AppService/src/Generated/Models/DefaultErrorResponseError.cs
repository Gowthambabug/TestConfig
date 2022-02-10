// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Error model. </summary>
    internal partial class DefaultErrorResponseError
    {
        /// <summary> Initializes a new instance of DefaultErrorResponseError. </summary>
        internal DefaultErrorResponseError()
        {
            Details = new ChangeTrackingList<DefaultErrorResponseErrorDetailsItem>();
        }

        /// <summary> Initializes a new instance of DefaultErrorResponseError. </summary>
        /// <param name="code"> Standardized string to programmatically identify the error. </param>
        /// <param name="message"> Detailed error description and debugging information. </param>
        /// <param name="target"> Detailed error description and debugging information. </param>
        /// <param name="details"></param>
        /// <param name="innererror"> More information to debug error. </param>
        internal DefaultErrorResponseError(string code, string message, string target, IReadOnlyList<DefaultErrorResponseErrorDetailsItem> details, string innererror)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
        }

        /// <summary> Standardized string to programmatically identify the error. </summary>
        public string Code { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        public string Message { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        public string Target { get; }
        /// <summary> Gets the details. </summary>
        public IReadOnlyList<DefaultErrorResponseErrorDetailsItem> Details { get; }
        /// <summary> More information to debug error. </summary>
        public string Innererror { get; }
    }
}