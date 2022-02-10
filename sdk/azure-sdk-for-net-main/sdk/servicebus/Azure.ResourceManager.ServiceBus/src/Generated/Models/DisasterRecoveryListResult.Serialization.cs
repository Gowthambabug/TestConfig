// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    internal partial class DisasterRecoveryListResult
    {
        internal static DisasterRecoveryListResult DeserializeDisasterRecoveryListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DisasterRecoveryData>> value = default;
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
                    List<DisasterRecoveryData> array = new List<DisasterRecoveryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DisasterRecoveryData.DeserializeDisasterRecoveryData(item));
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
            return new DisasterRecoveryListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}