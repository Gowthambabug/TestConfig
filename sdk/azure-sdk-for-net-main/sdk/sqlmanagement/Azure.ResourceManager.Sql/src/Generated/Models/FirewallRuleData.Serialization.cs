// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    public partial class FirewallRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StartIpAddress))
            {
                writer.WritePropertyName("startIpAddress");
                writer.WriteStringValue(StartIpAddress);
            }
            if (Optional.IsDefined(EndIpAddress))
            {
                writer.WritePropertyName("endIpAddress");
                writer.WriteStringValue(EndIpAddress);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FirewallRuleData DeserializeFirewallRuleData(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> startIpAddress = default;
            Optional<string> endIpAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startIpAddress"))
                        {
                            startIpAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endIpAddress"))
                        {
                            endIpAddress = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FirewallRuleData(id.Value, name.Value, type.Value, startIpAddress.Value, endIpAddress.Value);
        }
    }
}