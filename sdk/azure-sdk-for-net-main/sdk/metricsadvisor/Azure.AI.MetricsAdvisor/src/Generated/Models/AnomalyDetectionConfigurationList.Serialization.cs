// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AnomalyDetectionConfigurationList
    {
        internal static AnomalyDetectionConfigurationList DeserializeAnomalyDetectionConfigurationList(JsonElement element)
        {
            Optional<IReadOnlyList<AnomalyDetectionConfiguration>> value = default;
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
                    List<AnomalyDetectionConfiguration> array = new List<AnomalyDetectionConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnomalyDetectionConfiguration.DeserializeAnomalyDetectionConfiguration(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AnomalyDetectionConfigurationList(Optional.ToList(value), nextLink.Value);
        }
    }
}