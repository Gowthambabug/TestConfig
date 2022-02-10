// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of hybrid runbook worker.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HybridRunbookWorker : Resource
    {
        /// <summary>
        /// Initializes a new instance of the HybridRunbookWorker class.
        /// </summary>
        public HybridRunbookWorker()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridRunbookWorker class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="ip">Gets or sets the assigned machine IP
        /// address.</param>
        /// <param name="registeredDateTime">Gets or sets the registration time
        /// of the worker machine.</param>
        /// <param name="lastSeenDateTime">Last Heartbeat from the
        /// Worker</param>
        /// <param name="vmResourceId">Azure Resource Manager Id for a virtual
        /// machine.</param>
        /// <param name="workerType">Type of the HybridWorker. Possible values
        /// include: 'HybridV1', 'HybridV2'</param>
        /// <param name="workerName">Name of the HybridWorker.</param>
        /// <param name="systemData">Resource system metadata.</param>
        public HybridRunbookWorker(string id = default(string), string name = default(string), string type = default(string), string ip = default(string), System.DateTimeOffset registeredDateTime = default(System.DateTimeOffset), System.DateTimeOffset lastSeenDateTime = default(System.DateTimeOffset), string vmResourceId = default(string), string workerType = default(string), string workerName = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            Ip = ip;
            RegisteredDateTime = registeredDateTime;
            LastSeenDateTime = lastSeenDateTime;
            VmResourceId = vmResourceId;
            WorkerType = workerType;
            WorkerName = workerName;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the assigned machine IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets the registration time of the worker machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.registeredDateTime")]
        public System.DateTimeOffset RegisteredDateTime { get; set; }

        /// <summary>
        /// Gets or sets last Heartbeat from the Worker
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastSeenDateTime")]
        public System.DateTimeOffset LastSeenDateTime { get; set; }

        /// <summary>
        /// Gets or sets azure Resource Manager Id for a virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmResourceId")]
        public string VmResourceId { get; set; }

        /// <summary>
        /// Gets or sets type of the HybridWorker. Possible values include:
        /// 'HybridV1', 'HybridV2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.workerType")]
        public string WorkerType { get; set; }

        /// <summary>
        /// Gets or sets name of the HybridWorker.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workerName")]
        public string WorkerName { get; set; }

        /// <summary>
        /// Gets or sets resource system metadata.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

    }
}