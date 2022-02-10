// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesTypeOperationResult
    {
        internal static TimeSeriesTypeOperationResult DeserializeTimeSeriesTypeOperationResult(JsonElement element)
        {
            Optional<TimeSeriesType> timeSeriesType = default;
            Optional<TimeSeriesOperationError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeSeriesType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeSeriesType = TimeSeriesType.DeserializeTimeSeriesType(property.Value);
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = TimeSeriesOperationError.DeserializeTimeSeriesOperationError(property.Value);
                    continue;
                }
            }
            return new TimeSeriesTypeOperationResult(timeSeriesType.Value, error.Value);
        }
    }
}