// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    internal partial class ZoneListResult
    {
        internal static ZoneListResult DeserializeZoneListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Zone>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Zone> array = new List<Zone>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Zone.DeserializeZone(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ZoneListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}