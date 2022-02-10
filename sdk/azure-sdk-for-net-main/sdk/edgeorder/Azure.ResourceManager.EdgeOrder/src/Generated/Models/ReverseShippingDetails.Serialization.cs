// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ReverseShippingDetails
    {
        internal static ReverseShippingDetails DeserializeReverseShippingDetails(JsonElement element)
        {
            Optional<string> sasKeyForLabel = default;
            Optional<string> carrierName = default;
            Optional<string> carrierDisplayName = default;
            Optional<string> trackingId = default;
            Optional<string> trackingUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasKeyForLabel"))
                {
                    sasKeyForLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierName"))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierDisplayName"))
                {
                    carrierDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingUrl"))
                {
                    trackingUrl = property.Value.GetString();
                    continue;
                }
            }
            return new ReverseShippingDetails(sasKeyForLabel.Value, carrierName.Value, carrierDisplayName.Value, trackingId.Value, trackingUrl.Value);
        }
    }
}