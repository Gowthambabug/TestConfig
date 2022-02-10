// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Request body structure for creating data flow debug session. </summary>
    public partial class CreateDataFlowDebugSessionRequest
    {
        /// <summary> Initializes a new instance of CreateDataFlowDebugSessionRequest. </summary>
        public CreateDataFlowDebugSessionRequest()
        {
        }

        /// <summary> Initializes a new instance of CreateDataFlowDebugSessionRequest. </summary>
        /// <param name="computeType"> Compute type of the cluster. The value will be overwritten by the same setting in integration runtime if provided. </param>
        /// <param name="coreCount"> Core count of the cluster. The value will be overwritten by the same setting in integration runtime if provided. </param>
        /// <param name="timeToLive"> Time to live setting of the cluster in minutes. </param>
        /// <param name="integrationRuntime"> Set to use integration runtime setting for data flow debug session. </param>
        internal CreateDataFlowDebugSessionRequest(string computeType, int? coreCount, int? timeToLive, IntegrationRuntimeDebugResource integrationRuntime)
        {
            ComputeType = computeType;
            CoreCount = coreCount;
            TimeToLive = timeToLive;
            IntegrationRuntime = integrationRuntime;
        }

        /// <summary> Compute type of the cluster. The value will be overwritten by the same setting in integration runtime if provided. </summary>
        public string ComputeType { get; set; }
        /// <summary> Core count of the cluster. The value will be overwritten by the same setting in integration runtime if provided. </summary>
        public int? CoreCount { get; set; }
        /// <summary> Time to live setting of the cluster in minutes. </summary>
        public int? TimeToLive { get; set; }
        /// <summary> Set to use integration runtime setting for data flow debug session. </summary>
        public IntegrationRuntimeDebugResource IntegrationRuntime { get; set; }
    }
}