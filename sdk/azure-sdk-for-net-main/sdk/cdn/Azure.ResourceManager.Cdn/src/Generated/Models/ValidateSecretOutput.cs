// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of the validated secret. </summary>
    internal partial class ValidateSecretOutput
    {
        /// <summary> Initializes a new instance of ValidateSecretOutput. </summary>
        internal ValidateSecretOutput()
        {
        }

        /// <summary> The validation status. </summary>
        public Status? Status { get; }
        /// <summary> Detailed error message. </summary>
        public string Message { get; }
    }
}
