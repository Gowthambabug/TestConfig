// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Condition defines an extension to status. </summary>
    internal partial class Condition
    {
        /// <summary> Initializes a new instance of Condition. </summary>
        internal Condition()
        {
        }

        /// <summary> Status of the condition. </summary>
        public string Status { get; }
        /// <summary> The reason for the condition&apos;s status. </summary>
        public string Reason { get; }
        /// <summary> A human readable message indicating details about the status. </summary>
        public string Message { get; }
        /// <summary> Severity with which to treat failures of this type of condition. </summary>
        public string Severity { get; }
    }
}