// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.MixedReality.RemoteRendering;

namespace Azure.MixedReality.RemoteRendering.Models
{
    /// <summary> The error response containing details of why the request failed. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> The error object containing details of why the request failed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ErrorResponse(RemoteRenderingServiceError error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> The error object containing details of why the request failed. </summary>
        public RemoteRenderingServiceError Error { get; }
    }
}