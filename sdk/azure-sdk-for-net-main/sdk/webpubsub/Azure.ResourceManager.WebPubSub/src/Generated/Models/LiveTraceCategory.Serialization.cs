// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class LiveTraceCategory : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteStringValue(Enabled);
            }
            writer.WriteEndObject();
        }

        internal static LiveTraceCategory DeserializeLiveTraceCategory(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> enabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetString();
                    continue;
                }
            }
            return new LiveTraceCategory(name.Value, enabled.Value);
        }
    }
}