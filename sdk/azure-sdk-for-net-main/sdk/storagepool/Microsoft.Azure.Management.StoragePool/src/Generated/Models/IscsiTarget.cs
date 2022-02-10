// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StoragePool.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response for iSCSI Target requests.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IscsiTarget : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the IscsiTarget class.
        /// </summary>
        public IscsiTarget()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IscsiTarget class.
        /// </summary>
        /// <param name="aclMode">Mode for Target connectivity. Possible values
        /// include: 'Dynamic', 'Static'</param>
        /// <param name="targetIqn">iSCSI Target IQN (iSCSI Qualified Name);
        /// example: "iqn.2005-03.org.iscsi:server".</param>
        /// <param name="provisioningState">State of the operation on the
        /// resource. Possible values include: 'Invalid', 'Succeeded',
        /// 'Failed', 'Canceled', 'Pending', 'Creating', 'Updating',
        /// 'Deleting'</param>
        /// <param name="status">Operational status of the iSCSI Target.
        /// Possible values include: 'Invalid', 'Unknown', 'Healthy',
        /// 'Unhealthy', 'Updating', 'Running', 'Stopped', 'Stopped
        /// (deallocated)'</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="staticAcls">Access Control List (ACL) for an iSCSI
        /// Target; defines LUN masking policy</param>
        /// <param name="luns">List of LUNs to be exposed through iSCSI
        /// Target.</param>
        /// <param name="endpoints">List of private IPv4 addresses to connect
        /// to the iSCSI Target.</param>
        /// <param name="port">The port used by iSCSI Target portal
        /// group.</param>
        /// <param name="systemData">Resource metadata required by ARM
        /// RPC</param>
        public IscsiTarget(string aclMode, string targetIqn, string provisioningState, string status, string id = default(string), string name = default(string), string type = default(string), IList<Acl> staticAcls = default(IList<Acl>), IList<IscsiLun> luns = default(IList<IscsiLun>), IList<string> endpoints = default(IList<string>), int? port = default(int?), SystemMetadata systemData = default(SystemMetadata))
            : base(id, name, type)
        {
            AclMode = aclMode;
            StaticAcls = staticAcls;
            Luns = luns;
            TargetIqn = targetIqn;
            ProvisioningState = provisioningState;
            Status = status;
            Endpoints = endpoints;
            Port = port;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets mode for Target connectivity. Possible values include:
        /// 'Dynamic', 'Static'
        /// </summary>
        [JsonProperty(PropertyName = "properties.aclMode")]
        public string AclMode { get; set; }

        /// <summary>
        /// Gets or sets access Control List (ACL) for an iSCSI Target; defines
        /// LUN masking policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.staticAcls")]
        public IList<Acl> StaticAcls { get; set; }

        /// <summary>
        /// Gets or sets list of LUNs to be exposed through iSCSI Target.
        /// </summary>
        [JsonProperty(PropertyName = "properties.luns")]
        public IList<IscsiLun> Luns { get; set; }

        /// <summary>
        /// Gets or sets iSCSI Target IQN (iSCSI Qualified Name); example:
        /// "iqn.2005-03.org.iscsi:server".
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetIqn")]
        public string TargetIqn { get; set; }

        /// <summary>
        /// Gets or sets state of the operation on the resource. Possible
        /// values include: 'Invalid', 'Succeeded', 'Failed', 'Canceled',
        /// 'Pending', 'Creating', 'Updating', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets operational status of the iSCSI Target. Possible
        /// values include: 'Invalid', 'Unknown', 'Healthy', 'Unhealthy',
        /// 'Updating', 'Running', 'Stopped', 'Stopped (deallocated)'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets list of private IPv4 addresses to connect to the iSCSI
        /// Target.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoints")]
        public IList<string> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets the port used by iSCSI Target portal group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets resource metadata required by ARM RPC
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemMetadata SystemData { get; set; }

    }
}