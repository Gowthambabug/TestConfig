// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The WafRankingsResponseDataItem. </summary>
    public partial class WafRankingsResponseDataItem
    {
        /// <summary> Initializes a new instance of WafRankingsResponseDataItem. </summary>
        internal WafRankingsResponseDataItem()
        {
            GroupValues = new ChangeTrackingList<string>();
            Metrics = new ChangeTrackingList<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems>();
        }

        /// <summary> Initializes a new instance of WafRankingsResponseDataItem. </summary>
        /// <param name="groupValues"></param>
        /// <param name="metrics"></param>
        internal WafRankingsResponseDataItem(IReadOnlyList<string> groupValues, IReadOnlyList<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems> metrics)
        {
            GroupValues = groupValues;
            Metrics = metrics;
        }

        /// <summary> Gets the group values. </summary>
        public IReadOnlyList<string> GroupValues { get; }
        /// <summary> Gets the metrics. </summary>
        public IReadOnlyList<ComponentsKpo1PjSchemasWafrankingsresponsePropertiesDataItemsPropertiesMetricsItems> Metrics { get; }
    }
}