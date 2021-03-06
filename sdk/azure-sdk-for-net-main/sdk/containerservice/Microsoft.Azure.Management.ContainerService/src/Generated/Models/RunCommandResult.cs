// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// run command result.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RunCommandResult
    {
        /// <summary>
        /// Initializes a new instance of the RunCommandResult class.
        /// </summary>
        public RunCommandResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunCommandResult class.
        /// </summary>
        /// <param name="id">The command id.</param>
        /// <param name="provisioningState">provisioning State</param>
        /// <param name="exitCode">The exit code of the command</param>
        /// <param name="startedAt">The time when the command started.</param>
        /// <param name="finishedAt">The time when the command
        /// finished.</param>
        /// <param name="logs">The command output.</param>
        /// <param name="reason">An explanation of why provisioningState is set
        /// to failed (if so).</param>
        public RunCommandResult(string id = default(string), string provisioningState = default(string), int? exitCode = default(int?), System.DateTime? startedAt = default(System.DateTime?), System.DateTime? finishedAt = default(System.DateTime?), string logs = default(string), string reason = default(string))
        {
            Id = id;
            ProvisioningState = provisioningState;
            ExitCode = exitCode;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            Logs = logs;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the command id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets provisioning State
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the exit code of the command
        /// </summary>
        [JsonProperty(PropertyName = "properties.exitCode")]
        public int? ExitCode { get; private set; }

        /// <summary>
        /// Gets the time when the command started.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startedAt")]
        public System.DateTime? StartedAt { get; private set; }

        /// <summary>
        /// Gets the time when the command finished.
        /// </summary>
        [JsonProperty(PropertyName = "properties.finishedAt")]
        public System.DateTime? FinishedAt { get; private set; }

        /// <summary>
        /// Gets the command output.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logs")]
        public string Logs { get; private set; }

        /// <summary>
        /// Gets an explanation of why provisioningState is set to failed (if
        /// so).
        /// </summary>
        [JsonProperty(PropertyName = "properties.reason")]
        public string Reason { get; private set; }

    }
}
