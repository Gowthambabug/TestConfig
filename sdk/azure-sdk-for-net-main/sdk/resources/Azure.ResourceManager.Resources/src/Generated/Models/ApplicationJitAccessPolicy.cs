// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application Jit access policy. </summary>
    public partial class ApplicationJitAccessPolicy
    {
        /// <summary> Initializes a new instance of ApplicationJitAccessPolicy. </summary>
        /// <param name="jitAccessEnabled"> Whether the JIT access is enabled. </param>
        public ApplicationJitAccessPolicy(bool jitAccessEnabled)
        {
            JitAccessEnabled = jitAccessEnabled;
            JitApprovers = new ChangeTrackingList<JitApproverDefinition>();
        }

        /// <summary> Initializes a new instance of ApplicationJitAccessPolicy. </summary>
        /// <param name="jitAccessEnabled"> Whether the JIT access is enabled. </param>
        /// <param name="jitApprovalMode"> JIT approval mode. </param>
        /// <param name="jitApprovers"> The JIT approvers. </param>
        /// <param name="maximumJitAccessDuration"> The maximum duration JIT access is granted. This is an ISO8601 time period value. </param>
        internal ApplicationJitAccessPolicy(bool jitAccessEnabled, JitApprovalMode? jitApprovalMode, IList<JitApproverDefinition> jitApprovers, string maximumJitAccessDuration)
        {
            JitAccessEnabled = jitAccessEnabled;
            JitApprovalMode = jitApprovalMode;
            JitApprovers = jitApprovers;
            MaximumJitAccessDuration = maximumJitAccessDuration;
        }

        /// <summary> Whether the JIT access is enabled. </summary>
        public bool JitAccessEnabled { get; set; }
        /// <summary> JIT approval mode. </summary>
        public JitApprovalMode? JitApprovalMode { get; set; }
        /// <summary> The JIT approvers. </summary>
        public IList<JitApproverDefinition> JitApprovers { get; }
        /// <summary> The maximum duration JIT access is granted. This is an ISO8601 time period value. </summary>
        public string MaximumJitAccessDuration { get; set; }
    }
}