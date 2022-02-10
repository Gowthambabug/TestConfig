// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the origin group. </summary>
    internal partial class OriginGroupUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of OriginGroupUpdatePropertiesParameters. </summary>
        internal OriginGroupUpdatePropertiesParameters()
        {
            Origins = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Health probe settings to the origin that is used to determine the health of the origin. </summary>
        public HealthProbeParameters HealthProbeSettings { get; }
        /// <summary> The source of the content being delivered via CDN within given origin group. </summary>
        public IReadOnlyList<WritableSubResource> Origins { get; }
        /// <summary> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </summary>
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; }
        /// <summary> The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported. </summary>
        public ResponseBasedOriginErrorDetectionParameters ResponseBasedOriginErrorDetectionSettings { get; }
    }
}