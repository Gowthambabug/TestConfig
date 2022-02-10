// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricAvailability
    {
        internal static MetricAvailability DeserializeMetricAvailability(JsonElement element)
        {
            Optional<TimeSpan> timeGrain = default;
            Optional<TimeSpan> retention = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeGrain = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("retention"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retention = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new MetricAvailability(Optional.ToNullable(timeGrain), Optional.ToNullable(retention));
        }
    }
}