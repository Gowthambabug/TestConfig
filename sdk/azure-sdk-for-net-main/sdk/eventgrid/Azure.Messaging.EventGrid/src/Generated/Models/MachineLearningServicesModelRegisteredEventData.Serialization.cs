// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MachineLearningServicesModelRegisteredEventDataConverter))]
    public partial class MachineLearningServicesModelRegisteredEventData
    {
        internal static MachineLearningServicesModelRegisteredEventData DeserializeMachineLearningServicesModelRegisteredEventData(JsonElement element)
        {
            Optional<string> modelName = default;
            Optional<string> modelVersion = default;
            Optional<object> modelTags = default;
            Optional<object> modelProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelName"))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelVersion"))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelTags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modelTags = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modelProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modelProperties = property.Value.GetObject();
                    continue;
                }
            }
            return new MachineLearningServicesModelRegisteredEventData(modelName.Value, modelVersion.Value, modelTags.Value, modelProperties.Value);
        }

        internal partial class MachineLearningServicesModelRegisteredEventDataConverter : JsonConverter<MachineLearningServicesModelRegisteredEventData>
        {
            public override void Write(Utf8JsonWriter writer, MachineLearningServicesModelRegisteredEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MachineLearningServicesModelRegisteredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMachineLearningServicesModelRegisteredEventData(document.RootElement);
            }
        }
    }
}