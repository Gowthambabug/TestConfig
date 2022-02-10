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
    /// Response for Disk Pool request.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiskPool : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the DiskPool class.
        /// </summary>
        public DiskPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskPool class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives.</param>
        /// <param name="diskPoolName">Sku name</param>
        /// <param name="provisioningState">State of the operation on the
        /// resource. Possible values include: 'Invalid', 'Succeeded',
        /// 'Failed', 'Canceled', 'Pending', 'Creating', 'Updating',
        /// 'Deleting'</param>
        /// <param name="availabilityZones">Logical zone for Disk Pool
        /// resource; example: ["1"].</param>
        /// <param name="status">Operational status of the Disk Pool. Possible
        /// values include: 'Invalid', 'Unknown', 'Healthy', 'Unhealthy',
        /// 'Updating', 'Running', 'Stopped', 'Stopped (deallocated)'</param>
        /// <param name="subnetId">Azure Resource ID of a Subnet for the Disk
        /// Pool.</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="tier">Sku tier</param>
        /// <param name="disks">List of Azure Managed Disks to attach to a Disk
        /// Pool.</param>
        /// <param name="additionalCapabilities">List of additional
        /// capabilities for Disk Pool.</param>
        /// <param name="systemData">Resource metadata required by ARM
        /// RPC</param>
        public DiskPool(string location, string diskPoolName, string provisioningState, IList<string> availabilityZones, string status, string subnetId, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string tier = default(string), IList<Disk> disks = default(IList<Disk>), IList<string> additionalCapabilities = default(IList<string>), SystemMetadata systemData = default(SystemMetadata))
            : base(location, id, name, type, tags)
        {
            DiskPoolName = diskPoolName;
            Tier = tier;
            ProvisioningState = provisioningState;
            AvailabilityZones = availabilityZones;
            Status = status;
            Disks = disks;
            SubnetId = subnetId;
            AdditionalCapabilities = additionalCapabilities;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sku name
        /// </summary>
        [JsonProperty(PropertyName = "sku.name")]
        public string DiskPoolName { get; set; }

        /// <summary>
        /// Gets or sets sku tier
        /// </summary>
        [JsonProperty(PropertyName = "sku.tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets state of the operation on the resource. Possible
        /// values include: 'Invalid', 'Succeeded', 'Failed', 'Canceled',
        /// 'Pending', 'Creating', 'Updating', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets logical zone for Disk Pool resource; example: ["1"].
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilityZones")]
        public IList<string> AvailabilityZones { get; set; }

        /// <summary>
        /// Gets or sets operational status of the Disk Pool. Possible values
        /// include: 'Invalid', 'Unknown', 'Healthy', 'Unhealthy', 'Updating',
        /// 'Running', 'Stopped', 'Stopped (deallocated)'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets list of Azure Managed Disks to attach to a Disk Pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disks")]
        public IList<Disk> Disks { get; set; }

        /// <summary>
        /// Gets or sets azure Resource ID of a Subnet for the Disk Pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets list of additional capabilities for Disk Pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalCapabilities")]
        public IList<string> AdditionalCapabilities { get; set; }

        /// <summary>
        /// Gets resource metadata required by ARM RPC
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemMetadata SystemData { get; private set; }

    }
}