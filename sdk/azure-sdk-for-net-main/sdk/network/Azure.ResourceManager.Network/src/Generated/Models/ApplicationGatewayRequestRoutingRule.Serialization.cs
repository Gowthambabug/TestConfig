// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayRequestRoutingRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RuleType))
            {
                writer.WritePropertyName("ruleType");
                writer.WriteStringValue(RuleType.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool");
                JsonSerializer.Serialize(writer, BackendAddressPool);
            }
            if (Optional.IsDefined(BackendHttpSettings))
            {
                writer.WritePropertyName("backendHttpSettings");
                JsonSerializer.Serialize(writer, BackendHttpSettings);
            }
            if (Optional.IsDefined(HttpListener))
            {
                writer.WritePropertyName("httpListener");
                JsonSerializer.Serialize(writer, HttpListener);
            }
            if (Optional.IsDefined(UrlPathMap))
            {
                writer.WritePropertyName("urlPathMap");
                JsonSerializer.Serialize(writer, UrlPathMap);
            }
            if (Optional.IsDefined(RewriteRuleSet))
            {
                writer.WritePropertyName("rewriteRuleSet");
                JsonSerializer.Serialize(writer, RewriteRuleSet);
            }
            if (Optional.IsDefined(RedirectConfiguration))
            {
                writer.WritePropertyName("redirectConfiguration");
                JsonSerializer.Serialize(writer, RedirectConfiguration);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayRequestRoutingRule DeserializeApplicationGatewayRequestRoutingRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<ApplicationGatewayRequestRoutingRuleType> ruleType = default;
            Optional<int> priority = default;
            Optional<WritableSubResource> backendAddressPool = default;
            Optional<WritableSubResource> backendHttpSettings = default;
            Optional<WritableSubResource> httpListener = default;
            Optional<WritableSubResource> urlPathMap = default;
            Optional<WritableSubResource> rewriteRuleSet = default;
            Optional<WritableSubResource> redirectConfiguration = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("ruleType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ruleType = new ApplicationGatewayRequestRoutingRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPool"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backendAddressPool = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("backendHttpSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backendHttpSettings = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("httpListener"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpListener = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("urlPathMap"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            urlPathMap = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("rewriteRuleSet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rewriteRuleSet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("redirectConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            redirectConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayRequestRoutingRule(id.Value, name.Value, etag.Value, type.Value, Optional.ToNullable(ruleType), Optional.ToNullable(priority), backendAddressPool, backendHttpSettings, httpListener, urlPathMap, rewriteRuleSet, redirectConfiguration, Optional.ToNullable(provisioningState));
        }
    }
}