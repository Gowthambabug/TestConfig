// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AnalysisData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(DetectorDefinition))
            {
                writer.WritePropertyName("detectorDefinition");
                writer.WriteObjectValue(DetectorDefinition);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics");
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DetectorMetaData))
            {
                writer.WritePropertyName("detectorMetaData");
                writer.WriteObjectValue(DetectorMetaData);
            }
            writer.WriteEndObject();
        }

        internal static AnalysisData DeserializeAnalysisData(JsonElement element)
        {
            Optional<string> source = default;
            Optional<DetectorDefinition> detectorDefinition = default;
            Optional<IList<DiagnosticMetricSet>> metrics = default;
            Optional<IList<IList<NameValuePair>>> data = default;
            Optional<ResponseMetaData> detectorMetaData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectorDefinition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    detectorDefinition = DetectorDefinition.DeserializeDetectorDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("metrics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DiagnosticMetricSet> array = new List<DiagnosticMetricSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticMetricSet.DeserializeDiagnosticMetricSet(item));
                    }
                    metrics = array;
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<NameValuePair>> array = new List<IList<NameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<NameValuePair> array0 = new List<NameValuePair>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(NameValuePair.DeserializeNameValuePair(item0));
                        }
                        array.Add(array0);
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("detectorMetaData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    detectorMetaData = ResponseMetaData.DeserializeResponseMetaData(property.Value);
                    continue;
                }
            }
            return new AnalysisData(source.Value, detectorDefinition.Value, Optional.ToList(metrics), Optional.ToList(data), detectorMetaData.Value);
        }
    }
}