// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobInventoryPolicyDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Filters))
            {
                writer.WritePropertyName("filters");
                writer.WriteObjectValue(Filters);
            }
            writer.WritePropertyName("format");
            writer.WriteStringValue(Format.ToString());
            writer.WritePropertyName("schedule");
            writer.WriteStringValue(Schedule.ToString());
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType.ToString());
            writer.WritePropertyName("schemaFields");
            writer.WriteStartArray();
            foreach (var item in SchemaFields)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static BlobInventoryPolicyDefinition DeserializeBlobInventoryPolicyDefinition(JsonElement element)
        {
            Optional<BlobInventoryPolicyFilter> filters = default;
            Format format = default;
            Schedule schedule = default;
            ObjectType objectType = default;
            IList<string> schemaFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filters = BlobInventoryPolicyFilter.DeserializeBlobInventoryPolicyFilter(property.Value);
                    continue;
                }
                if (property.NameEquals("format"))
                {
                    format = new Format(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedule"))
                {
                    schedule = new Schedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = new ObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schemaFields"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    schemaFields = array;
                    continue;
                }
            }
            return new BlobInventoryPolicyDefinition(filters.Value, format, schedule, objectType, schemaFields);
        }
    }
}