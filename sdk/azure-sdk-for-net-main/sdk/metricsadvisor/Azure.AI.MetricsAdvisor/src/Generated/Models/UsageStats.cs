// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The UsageStats. </summary>
    internal partial class UsageStats
    {
        /// <summary> Initializes a new instance of UsageStats. </summary>
        internal UsageStats()
        {
        }

        /// <summary> Initializes a new instance of UsageStats. </summary>
        /// <param name="timestamp"> The timestamp of the stats. </param>
        /// <param name="activeSeriesCount"> The active series count. </param>
        /// <param name="allSeriesCount"> All series count under non deleted data feed. </param>
        /// <param name="metricsCount"> The metrics count under non deleted data feed. </param>
        /// <param name="dataFeedCount"> The count of non deleted data feed. </param>
        internal UsageStats(DateTimeOffset? timestamp, int? activeSeriesCount, int? allSeriesCount, int? metricsCount, int? dataFeedCount)
        {
            Timestamp = timestamp;
            ActiveSeriesCount = activeSeriesCount;
            AllSeriesCount = allSeriesCount;
            MetricsCount = metricsCount;
            DataFeedCount = dataFeedCount;
        }

        /// <summary> The timestamp of the stats. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The active series count. </summary>
        public int? ActiveSeriesCount { get; }
        /// <summary> All series count under non deleted data feed. </summary>
        public int? AllSeriesCount { get; }
        /// <summary> The metrics count under non deleted data feed. </summary>
        public int? MetricsCount { get; }
        /// <summary> The count of non deleted data feed. </summary>
        public int? DataFeedCount { get; }
    }
}