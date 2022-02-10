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
    [JsonConverter(typeof(CustomerManagedKeyDetailsConverter))]
    public partial class CustomerManagedKeyDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteObjectValue(Key);
            }
            writer.WriteEndObject();
        }

        internal static CustomerManagedKeyDetails DeserializeCustomerManagedKeyDetails(JsonElement element)
        {
            Optional<string> status = default;
            Optional<WorkspaceKeyDetails> key = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    key = WorkspaceKeyDetails.DeserializeWorkspaceKeyDetails(property.Value);
                    continue;
                }
            }
            return new CustomerManagedKeyDetails(status.Value, key.Value);
        }

        internal partial class CustomerManagedKeyDetailsConverter : JsonConverter<CustomerManagedKeyDetails>
        {
            public override void Write(Utf8JsonWriter writer, CustomerManagedKeyDetails model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CustomerManagedKeyDetails Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCustomerManagedKeyDetails(document.RootElement);
            }
        }
    }
}