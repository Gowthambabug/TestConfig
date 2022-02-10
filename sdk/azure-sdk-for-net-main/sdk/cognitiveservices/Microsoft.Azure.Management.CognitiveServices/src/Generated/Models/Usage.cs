// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The usage data for a usage request.
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        /// <param name="unit">The unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond', 'Milliseconds'</param>
        /// <param name="name">The name information for the metric.</param>
        /// <param name="quotaPeriod">The quota period used to summarize the
        /// usage values.</param>
        /// <param name="limit">Maximum value for this metric.</param>
        /// <param name="currentValue">Current value for this metric.</param>
        /// <param name="nextResetTime">Next reset time for current
        /// quota.</param>
        /// <param name="status">Cognitive Services account quota usage status.
        /// Possible values include: 'Included', 'Blocked', 'InOverage',
        /// 'Unknown'</param>
        public Usage(string unit = default(string), MetricName name = default(MetricName), string quotaPeriod = default(string), double? limit = default(double?), double? currentValue = default(double?), string nextResetTime = default(string), string status = default(string))
        {
            Unit = unit;
            Name = name;
            QuotaPeriod = quotaPeriod;
            Limit = limit;
            CurrentValue = currentValue;
            NextResetTime = nextResetTime;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond', 'Milliseconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the name information for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; set; }

        /// <summary>
        /// Gets or sets the quota period used to summarize the usage values.
        /// </summary>
        [JsonProperty(PropertyName = "quotaPeriod")]
        public string QuotaPeriod { get; set; }

        /// <summary>
        /// Gets or sets maximum value for this metric.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Gets or sets current value for this metric.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets next reset time for current quota.
        /// </summary>
        [JsonProperty(PropertyName = "nextResetTime")]
        public string NextResetTime { get; set; }

        /// <summary>
        /// Gets or sets cognitive Services account quota usage status.
        /// Possible values include: 'Included', 'Blocked', 'InOverage',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}