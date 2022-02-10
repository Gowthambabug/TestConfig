// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PeerRouteList
    {
        internal static PeerRouteList DeserializePeerRouteList(JsonElement element)
        {
            Optional<IReadOnlyList<PeerRoute>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PeerRoute> array = new List<PeerRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeerRoute.DeserializePeerRoute(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PeerRouteList(Optional.ToList(value));
        }
    }
}