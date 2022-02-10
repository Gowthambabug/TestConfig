// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the JobAgent data model. </summary>
    public partial class JobAgentData : TrackedResource
    {
        /// <summary> Initializes a new instance of JobAgentData. </summary>
        /// <param name="location"> The location. </param>
        public JobAgentData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of JobAgentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The name and tier of the SKU. </param>
        /// <param name="databaseId"> Resource ID of the database to store job metadata in. </param>
        /// <param name="state"> The state of the job agent. </param>
        internal JobAgentData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Models.Sku sku, string databaseId, JobAgentState? state) : base(id, name, type, systemData, tags, location)
        {
            Sku = sku;
            DatabaseId = databaseId;
            State = state;
        }

        /// <summary> The name and tier of the SKU. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> Resource ID of the database to store job metadata in. </summary>
        public string DatabaseId { get; set; }
        /// <summary> The state of the job agent. </summary>
        public JobAgentState? State { get; }
    }
}