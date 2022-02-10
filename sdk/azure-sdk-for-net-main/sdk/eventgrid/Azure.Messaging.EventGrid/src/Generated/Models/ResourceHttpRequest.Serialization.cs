// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ResourceHttpRequest
    {
        internal static ResourceHttpRequest DeserializeResourceHttpRequest(JsonElement element)
        {
            Optional<string> clientRequestId = default;
            Optional<string> clientIpAddress = default;
            Optional<string> method = default;
            Optional<string> url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientIpAddress"))
                {
                    clientIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"))
                {
                    method = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceHttpRequest(clientRequestId.Value, clientIpAddress.Value, method.Value, url.Value);
        }
    }
}