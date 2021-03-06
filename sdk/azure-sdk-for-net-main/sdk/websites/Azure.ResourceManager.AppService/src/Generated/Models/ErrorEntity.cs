// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Body of the error response returned from the API. </summary>
    public partial class ErrorEntity
    {
        /// <summary> Initializes a new instance of ErrorEntity. </summary>
        internal ErrorEntity()
        {
            Parameters = new ChangeTrackingList<string>();
            InnerErrors = new ChangeTrackingList<ErrorEntity>();
            Details = new ChangeTrackingList<ErrorEntity>();
        }

        /// <summary> Initializes a new instance of ErrorEntity. </summary>
        /// <param name="extendedCode"> Type of error. </param>
        /// <param name="messageTemplate"> Message template. </param>
        /// <param name="parameters"> Parameters for the template. </param>
        /// <param name="innerErrors"> Inner errors. </param>
        /// <param name="details"> Error Details. </param>
        /// <param name="target"> The error target. </param>
        /// <param name="code"> Basic error code. </param>
        /// <param name="message"> Any details of the error. </param>
        internal ErrorEntity(string extendedCode, string messageTemplate, IReadOnlyList<string> parameters, IReadOnlyList<ErrorEntity> innerErrors, IReadOnlyList<ErrorEntity> details, string target, string code, string message)
        {
            ExtendedCode = extendedCode;
            MessageTemplate = messageTemplate;
            Parameters = parameters;
            InnerErrors = innerErrors;
            Details = details;
            Target = target;
            Code = code;
            Message = message;
        }

        /// <summary> Type of error. </summary>
        public string ExtendedCode { get; }
        /// <summary> Message template. </summary>
        public string MessageTemplate { get; }
        /// <summary> Parameters for the template. </summary>
        public IReadOnlyList<string> Parameters { get; }
        /// <summary> Inner errors. </summary>
        public IReadOnlyList<ErrorEntity> InnerErrors { get; }
        /// <summary> Error Details. </summary>
        public IReadOnlyList<ErrorEntity> Details { get; }
        /// <summary> The error target. </summary>
        public string Target { get; }
        /// <summary> Basic error code. </summary>
        public string Code { get; }
        /// <summary> Any details of the error. </summary>
        public string Message { get; }
    }
}
