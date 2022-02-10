// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    public partial class CorrelationChanges
    {
        internal static CorrelationChanges DeserializeCorrelationChanges(JsonElement element)
        {
            Optional<IReadOnlyList<string>> changedVariables = default;
            Optional<IReadOnlyList<float>> changedValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("changedVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    changedVariables = array;
                    continue;
                }
                if (property.NameEquals("changedValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    changedValues = array;
                    continue;
                }
            }
            return new CorrelationChanges(Optional.ToList(changedVariables), Optional.ToList(changedValues));
        }
    }
}