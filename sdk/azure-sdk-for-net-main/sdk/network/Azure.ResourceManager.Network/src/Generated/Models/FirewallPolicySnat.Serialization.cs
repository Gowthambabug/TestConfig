// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicySnat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PrivateRanges))
            {
                writer.WritePropertyName("privateRanges");
                writer.WriteStartArray();
                foreach (var item in PrivateRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicySnat DeserializeFirewallPolicySnat(JsonElement element)
        {
            Optional<IList<string>> privateRanges = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateRanges"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    privateRanges = array;
                    continue;
                }
            }
            return new FirewallPolicySnat(Optional.ToList(privateRanges));
        }
    }
}