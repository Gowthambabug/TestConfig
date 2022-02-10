// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RtspSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Transport))
            {
                writer.WritePropertyName("transport");
                writer.WriteStringValue(Transport.Value.ToString());
            }
            writer.WritePropertyName("endpoint");
            writer.WriteObjectValue(Endpoint);
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static RtspSource DeserializeRtspSource(JsonElement element)
        {
            Optional<RtspTransport> transport = default;
            EndpointBase endpoint = default;
            string type = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transport"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    transport = new RtspTransport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpoint"))
                {
                    endpoint = EndpointBase.DeserializeEndpointBase(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new RtspSource(type, name, Optional.ToNullable(transport), endpoint);
        }
    }
}