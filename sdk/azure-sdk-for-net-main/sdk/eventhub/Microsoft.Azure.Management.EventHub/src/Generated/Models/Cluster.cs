// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single Event Hubs Cluster resource in List or Get operations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">Properties of the cluster SKU.</param>
        /// <param name="systemData">The system meta data relating to this
        /// resource.</param>
        /// <param name="createdAt">The UTC time when the Event Hubs Cluster
        /// was created.</param>
        /// <param name="updatedAt">The UTC time when the Event Hubs Cluster
        /// was last updated.</param>
        /// <param name="metricId">The metric ID of the cluster resource.
        /// Provided by the service and not modifiable by the user.</param>
        /// <param name="status">Status of the Cluster resource</param>
        public Cluster(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ClusterSku sku = default(ClusterSku), SystemData systemData = default(SystemData), string createdAt = default(string), string updatedAt = default(string), string metricId = default(string), string status = default(string))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            SystemData = systemData;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            MetricId = metricId;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the cluster SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ClusterSku Sku { get; set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets the UTC time when the Event Hubs Cluster was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Gets the UTC time when the Event Hubs Cluster was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public string UpdatedAt { get; private set; }

        /// <summary>
        /// Gets the metric ID of the cluster resource. Provided by the service
        /// and not modifiable by the user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricId")]
        public string MetricId { get; private set; }

        /// <summary>
        /// Gets status of the Cluster resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}