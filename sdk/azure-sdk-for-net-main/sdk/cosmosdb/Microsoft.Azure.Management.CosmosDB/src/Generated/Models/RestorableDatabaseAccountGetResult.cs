// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Azure Cosmos DB restorable database account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RestorableDatabaseAccountGetResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RestorableDatabaseAccountGetResult class.
        /// </summary>
        public RestorableDatabaseAccountGetResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RestorableDatabaseAccountGetResult class.
        /// </summary>
        /// <param name="accountName">The name of the global database
        /// account</param>
        /// <param name="creationTime">The creation time of the restorable
        /// database account (ISO-8601 format).</param>
        /// <param name="deletionTime">The time at which the restorable
        /// database account has been deleted (ISO-8601 format).</param>
        /// <param name="apiType">The API type of the restorable database
        /// account. Possible values include: 'MongoDB', 'Gremlin',
        /// 'Cassandra', 'Table', 'Sql', 'GremlinV2'</param>
        /// <param name="restorableLocations">List of regions where the of the
        /// database account can be restored from.</param>
        /// <param name="id">The unique resource identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        public RestorableDatabaseAccountGetResult(string accountName = default(string), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? deletionTime = default(System.DateTime?), string apiType = default(string), IList<RestorableLocationResource> restorableLocations = default(IList<RestorableLocationResource>), string id = default(string), string name = default(string), string type = default(string), string location = default(string))
        {
            AccountName = accountName;
            CreationTime = creationTime;
            DeletionTime = deletionTime;
            ApiType = apiType;
            RestorableLocations = restorableLocations;
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the global database account
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the restorable database account
        /// (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the restorable database account has
        /// been deleted (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.deletionTime")]
        public System.DateTime? DeletionTime { get; set; }

        /// <summary>
        /// Gets the API type of the restorable database account. Possible
        /// values include: 'MongoDB', 'Gremlin', 'Cassandra', 'Table', 'Sql',
        /// 'GremlinV2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiType")]
        public string ApiType { get; private set; }

        /// <summary>
        /// Gets list of regions where the of the database account can be
        /// restored from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorableLocations")]
        public IList<RestorableLocationResource> RestorableLocations { get; private set; }

        /// <summary>
        /// Gets the unique resource identifier of the ARM resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the ARM resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of Azure resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the location of the resource group to which the
        /// resource belongs.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}