// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the DataWarehouseUserActivities data model. </summary>
    public partial class DataWarehouseUserActivitiesData : Resource
    {
        /// <summary> Initializes a new instance of DataWarehouseUserActivitiesData. </summary>
        public DataWarehouseUserActivitiesData()
        {
        }

        /// <summary> Initializes a new instance of DataWarehouseUserActivitiesData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="activeQueriesCount"> Count of running and suspended queries. </param>
        internal DataWarehouseUserActivitiesData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, int? activeQueriesCount) : base(id, name, type, systemData)
        {
            ActiveQueriesCount = activeQueriesCount;
        }

        /// <summary> Count of running and suspended queries. </summary>
        public int? ActiveQueriesCount { get; }
    }
}