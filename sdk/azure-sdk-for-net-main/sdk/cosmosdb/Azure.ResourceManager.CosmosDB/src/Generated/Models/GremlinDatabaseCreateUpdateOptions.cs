// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB Gremlin database. </summary>
    public partial class GremlinDatabaseCreateUpdateOptions : TrackedResource
    {
        /// <summary> Initializes a new instance of GremlinDatabaseCreateUpdateOptions. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Gremlin database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public GremlinDatabaseCreateUpdateOptions(AzureLocation location, GremlinDatabaseResource resource) : base(location)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            Resource = resource;
        }

        /// <summary> Initializes a new instance of GremlinDatabaseCreateUpdateOptions. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Gremlin database. </param>
        /// <param name="options"> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </param>
        internal GremlinDatabaseCreateUpdateOptions(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, GremlinDatabaseResource resource, CreateUpdateOptions options) : base(id, name, type, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
        }

        /// <summary> The standard JSON format of a Gremlin database. </summary>
        public GremlinDatabaseResource Resource { get; set; }
        /// <summary> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </summary>
        public CreateUpdateOptions Options { get; set; }
    }
}