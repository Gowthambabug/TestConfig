// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RankingsResponseTablesPropertiesItemsItem. </summary>
    public partial class RankingsResponseTablesPropertiesItemsItem
    {
        /// <summary> Initializes a new instance of RankingsResponseTablesPropertiesItemsItem. </summary>
        internal RankingsResponseTablesPropertiesItemsItem()
        {
            Metrics = new ChangeTrackingList<RankingsResponseTablesPropertiesItemsMetricsItem>();
        }

        /// <summary> Initializes a new instance of RankingsResponseTablesPropertiesItemsItem. </summary>
        /// <param name="name"></param>
        /// <param name="metrics"></param>
        internal RankingsResponseTablesPropertiesItemsItem(string name, IReadOnlyList<RankingsResponseTablesPropertiesItemsMetricsItem> metrics)
        {
            Name = name;
            Metrics = metrics;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the metrics. </summary>
        public IReadOnlyList<RankingsResponseTablesPropertiesItemsMetricsItem> Metrics { get; }
    }
}