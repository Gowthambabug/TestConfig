// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class CdnEndpointData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OriginPath))
            {
                writer.WritePropertyName("originPath");
                writer.WriteStringValue(OriginPath);
            }
            if (Optional.IsCollectionDefined(ContentTypesToCompress))
            {
                writer.WritePropertyName("contentTypesToCompress");
                writer.WriteStartArray();
                foreach (var item in ContentTypesToCompress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader");
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(IsCompressionEnabled))
            {
                writer.WritePropertyName("isCompressionEnabled");
                writer.WriteBooleanValue(IsCompressionEnabled.Value);
            }
            if (Optional.IsDefined(IsHttpAllowed))
            {
                writer.WritePropertyName("isHttpAllowed");
                writer.WriteBooleanValue(IsHttpAllowed.Value);
            }
            if (Optional.IsDefined(IsHttpsAllowed))
            {
                writer.WritePropertyName("isHttpsAllowed");
                writer.WriteBooleanValue(IsHttpsAllowed.Value);
            }
            if (Optional.IsDefined(QueryStringCachingBehavior))
            {
                writer.WritePropertyName("queryStringCachingBehavior");
                writer.WriteStringValue(QueryStringCachingBehavior.Value.ToSerialString());
            }
            if (Optional.IsDefined(OptimizationType))
            {
                if (OptimizationType != null)
                {
                    writer.WritePropertyName("optimizationType");
                    writer.WriteStringValue(OptimizationType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("optimizationType");
                }
            }
            if (Optional.IsDefined(ProbePath))
            {
                writer.WritePropertyName("probePath");
                writer.WriteStringValue(ProbePath);
            }
            if (Optional.IsCollectionDefined(GeoFilters))
            {
                writer.WritePropertyName("geoFilters");
                writer.WriteStartArray();
                foreach (var item in GeoFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultOriginGroup))
            {
                if (DefaultOriginGroup != null)
                {
                    writer.WritePropertyName("defaultOriginGroup");
                    writer.WriteObjectValue(DefaultOriginGroup);
                }
                else
                {
                    writer.WriteNull("defaultOriginGroup");
                }
            }
            if (Optional.IsCollectionDefined(UrlSigningKeys))
            {
                if (UrlSigningKeys != null)
                {
                    writer.WritePropertyName("urlSigningKeys");
                    writer.WriteStartArray();
                    foreach (var item in UrlSigningKeys)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("urlSigningKeys");
                }
            }
            if (Optional.IsDefined(DeliveryPolicy))
            {
                if (DeliveryPolicy != null)
                {
                    writer.WritePropertyName("deliveryPolicy");
                    writer.WriteObjectValue(DeliveryPolicy);
                }
                else
                {
                    writer.WriteNull("deliveryPolicy");
                }
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                if (WebApplicationFirewallPolicyLink != null)
                {
                    writer.WritePropertyName("webApplicationFirewallPolicyLink");
                    writer.WriteObjectValue(WebApplicationFirewallPolicyLink);
                }
                else
                {
                    writer.WriteNull("webApplicationFirewallPolicyLink");
                }
            }
            if (Optional.IsCollectionDefined(Origins))
            {
                writer.WritePropertyName("origins");
                writer.WriteStartArray();
                foreach (var item in Origins)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OriginGroups))
            {
                writer.WritePropertyName("originGroups");
                writer.WriteStartArray();
                foreach (var item in OriginGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CdnEndpointData DeserializeCdnEndpointData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> originPath = default;
            Optional<IList<string>> contentTypesToCompress = default;
            Optional<string> originHostHeader = default;
            Optional<bool> isCompressionEnabled = default;
            Optional<bool> isHttpAllowed = default;
            Optional<bool> isHttpsAllowed = default;
            Optional<QueryStringCachingBehavior> queryStringCachingBehavior = default;
            Optional<OptimizationType?> optimizationType = default;
            Optional<string> probePath = default;
            Optional<IList<GeoFilter>> geoFilters = default;
            Optional<EndpointPropertiesUpdateParametersDefaultOriginGroup> defaultOriginGroup = default;
            Optional<IList<UrlSigningKey>> urlSigningKeys = default;
            Optional<EndpointPropertiesUpdateParametersDeliveryPolicy> deliveryPolicy = default;
            Optional<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink> webApplicationFirewallPolicyLink = default;
            Optional<string> hostName = default;
            Optional<IList<DeepCreatedOrigin>> origins = default;
            Optional<IList<DeepCreatedOriginGroup>> originGroups = default;
            Optional<EndpointResourceState> resourceState = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("originPath"))
                        {
                            originPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentTypesToCompress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            contentTypesToCompress = array;
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCompressionEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isCompressionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpAllowed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isHttpAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpsAllowed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isHttpsAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queryStringCachingBehavior"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryStringCachingBehavior = property0.Value.GetString().ToQueryStringCachingBehavior();
                            continue;
                        }
                        if (property0.NameEquals("optimizationType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                optimizationType = null;
                                continue;
                            }
                            optimizationType = new OptimizationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("probePath"))
                        {
                            probePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geoFilters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<GeoFilter> array = new List<GeoFilter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GeoFilter.DeserializeGeoFilter(item));
                            }
                            geoFilters = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultOriginGroup"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                defaultOriginGroup = null;
                                continue;
                            }
                            defaultOriginGroup = EndpointPropertiesUpdateParametersDefaultOriginGroup.DeserializeEndpointPropertiesUpdateParametersDefaultOriginGroup(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("urlSigningKeys"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                urlSigningKeys = null;
                                continue;
                            }
                            List<UrlSigningKey> array = new List<UrlSigningKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UrlSigningKey.DeserializeUrlSigningKey(item));
                            }
                            urlSigningKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("deliveryPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                deliveryPolicy = null;
                                continue;
                            }
                            deliveryPolicy = EndpointPropertiesUpdateParametersDeliveryPolicy.DeserializeEndpointPropertiesUpdateParametersDeliveryPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                webApplicationFirewallPolicyLink = null;
                                continue;
                            }
                            webApplicationFirewallPolicyLink = EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink.DeserializeEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("origins"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DeepCreatedOrigin> array = new List<DeepCreatedOrigin>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeepCreatedOrigin.DeserializeDeepCreatedOrigin(item));
                            }
                            origins = array;
                            continue;
                        }
                        if (property0.NameEquals("originGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DeepCreatedOriginGroup> array = new List<DeepCreatedOriginGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeepCreatedOriginGroup.DeserializeDeepCreatedOriginGroup(item));
                            }
                            originGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new EndpointResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CdnEndpointData(id, name, type, systemData, tags, location, originPath.Value, Optional.ToList(contentTypesToCompress), originHostHeader.Value, Optional.ToNullable(isCompressionEnabled), Optional.ToNullable(isHttpAllowed), Optional.ToNullable(isHttpsAllowed), Optional.ToNullable(queryStringCachingBehavior), Optional.ToNullable(optimizationType), probePath.Value, Optional.ToList(geoFilters), defaultOriginGroup.Value, Optional.ToList(urlSigningKeys), deliveryPolicy.Value, webApplicationFirewallPolicyLink.Value, hostName.Value, Optional.ToList(origins), Optional.ToList(originGroups), Optional.ToNullable(resourceState), provisioningState.Value);
        }
    }
}