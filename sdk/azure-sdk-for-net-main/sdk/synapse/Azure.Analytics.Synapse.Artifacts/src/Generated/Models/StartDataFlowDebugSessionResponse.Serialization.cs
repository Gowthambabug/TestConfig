// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(StartDataFlowDebugSessionResponseConverter))]
    public partial class StartDataFlowDebugSessionResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(JobVersion))
            {
                writer.WritePropertyName("jobVersion");
                writer.WriteStringValue(JobVersion);
            }
            writer.WriteEndObject();
        }

        internal static StartDataFlowDebugSessionResponse DeserializeStartDataFlowDebugSessionResponse(JsonElement element)
        {
            Optional<string> jobVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobVersion"))
                {
                    jobVersion = property.Value.GetString();
                    continue;
                }
            }
            return new StartDataFlowDebugSessionResponse(jobVersion.Value);
        }

        internal partial class StartDataFlowDebugSessionResponseConverter : JsonConverter<StartDataFlowDebugSessionResponse>
        {
            public override void Write(Utf8JsonWriter writer, StartDataFlowDebugSessionResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StartDataFlowDebugSessionResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStartDataFlowDebugSessionResponse(document.RootElement);
            }
        }
    }
}