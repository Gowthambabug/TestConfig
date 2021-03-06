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
    /// Single item in List or Get Schema Group operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SchemaGroup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SchemaGroup class.
        /// </summary>
        public SchemaGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchemaGroup class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.EventHub/Namespaces" or
        /// "Microsoft.EventHub/Namespaces/EventHubs"</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="updatedAtUtc">Exact time the Schema Group was
        /// updated</param>
        /// <param name="createdAtUtc">Exact time the Schema Group was
        /// created.</param>
        /// <param name="eTag">The ETag value.</param>
        /// <param name="groupProperties">dictionary object for SchemaGroup
        /// group properties</param>
        /// <param name="schemaCompatibility">Possible values include: 'None',
        /// 'Backward', 'Forward'</param>
        /// <param name="schemaType">Possible values include: 'Unknown',
        /// 'Avro'</param>
        /// <param name="systemData">The system meta data relating to this
        /// resource.</param>
        public SchemaGroup(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.DateTime? updatedAtUtc = default(System.DateTime?), System.DateTime? createdAtUtc = default(System.DateTime?), System.Guid? eTag = default(System.Guid?), IDictionary<string, string> groupProperties = default(IDictionary<string, string>), string schemaCompatibility = default(string), string schemaType = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, location)
        {
            UpdatedAtUtc = updatedAtUtc;
            CreatedAtUtc = createdAtUtc;
            ETag = eTag;
            GroupProperties = groupProperties;
            SchemaCompatibility = schemaCompatibility;
            SchemaType = schemaType;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets exact time the Schema Group was updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAtUtc")]
        public System.DateTime? UpdatedAtUtc { get; private set; }

        /// <summary>
        /// Gets exact time the Schema Group was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAtUtc")]
        public System.DateTime? CreatedAtUtc { get; private set; }

        /// <summary>
        /// Gets the ETag value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eTag")]
        public System.Guid? ETag { get; private set; }

        /// <summary>
        /// Gets or sets dictionary object for SchemaGroup group properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupProperties")]
        public IDictionary<string, string> GroupProperties { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Backward', 'Forward'
        /// </summary>
        [JsonProperty(PropertyName = "properties.schemaCompatibility")]
        public string SchemaCompatibility { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Unknown', 'Avro'
        /// </summary>
        [JsonProperty(PropertyName = "properties.schemaType")]
        public string SchemaType { get; set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
