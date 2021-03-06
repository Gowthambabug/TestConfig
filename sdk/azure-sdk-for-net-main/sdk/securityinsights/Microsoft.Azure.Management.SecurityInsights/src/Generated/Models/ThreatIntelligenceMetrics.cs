// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Threat intelligence metrics.
    /// </summary>
    public partial class ThreatIntelligenceMetrics
    {
        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceMetrics class.
        /// </summary>
        public ThreatIntelligenceMetrics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThreatIntelligenceMetrics class.
        /// </summary>
        /// <param name="properties">Threat intelligence metrics.</param>
        public ThreatIntelligenceMetrics(ThreatIntelligenceMetric properties = default(ThreatIntelligenceMetric))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets threat intelligence metrics.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ThreatIntelligenceMetric Properties { get; set; }

    }
}
