// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The result data of a query. </summary>
    public partial class MetricResult
    {
        /// <summary> Initializes a new instance of MetricResult. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="resourceType"> the resource type of the metric resource. </param>
        /// <param name="localizedName"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="timeSeries"> the time series returned when a data query is performed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="resourceType"/>, <paramref name="localizedName"/>, or <paramref name="timeSeries"/> is null. </exception>
        internal MetricResult(string id, string resourceType, LocalizableString localizedName, MetricUnit unit, IEnumerable<MetricTimeSeriesElement> timeSeries)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            if (localizedName == null)
            {
                throw new ArgumentNullException(nameof(localizedName));
            }
            if (timeSeries == null)
            {
                throw new ArgumentNullException(nameof(timeSeries));
            }

            Id = id;
            ResourceType = resourceType;
            LocalizedName = localizedName;
            Unit = unit;
            TimeSeries = timeSeries.ToList();
        }

        /// <summary> Initializes a new instance of MetricResult. </summary>
        /// <param name="id"> the metric Id. </param>
        /// <param name="resourceType"> the resource type of the metric resource. </param>
        /// <param name="localizedName"> the name and the display name of the metric, i.e. it is localizable string. </param>
        /// <param name="description"> Detailed description of this metric. </param>
        /// <param name="errorCode"> &apos;Success&apos; or the error details on query failures for this metric. </param>
        /// <param name="errorMessage"> Error message encountered querying this specific metric. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="timeSeries"> the time series returned when a data query is performed. </param>
        internal MetricResult(string id, string resourceType, LocalizableString localizedName, string description, string errorCode, string errorMessage, MetricUnit unit, IReadOnlyList<MetricTimeSeriesElement> timeSeries)
        {
            Id = id;
            ResourceType = resourceType;
            LocalizedName = localizedName;
            Description = description;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Unit = unit;
            TimeSeries = timeSeries;
        }

        /// <summary> the metric Id. </summary>
        public string Id { get; }
        /// <summary> The unit of the metric. </summary>
        public MetricUnit Unit { get; }
    }
}