// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ImmutableStorageAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(ImmutabilityPolicy))
            {
                writer.WritePropertyName("immutabilityPolicy");
                writer.WriteObjectValue(ImmutabilityPolicy);
            }
            writer.WriteEndObject();
        }

        internal static ImmutableStorageAccount DeserializeImmutableStorageAccount(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<AccountImmutabilityPolicyProperties> immutabilityPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("immutabilityPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    immutabilityPolicy = AccountImmutabilityPolicyProperties.DeserializeAccountImmutabilityPolicyProperties(property.Value);
                    continue;
                }
            }
            return new ImmutableStorageAccount(Optional.ToNullable(enabled), immutabilityPolicy.Value);
        }
    }
}