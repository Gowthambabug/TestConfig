// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerCache : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageConnectionString))
            {
                writer.WritePropertyName("storageConnectionString");
                writer.WriteStringValue(StorageConnectionString);
            }
            if (Optional.IsDefined(EnableReprocessing))
            {
                if (EnableReprocessing != null)
                {
                    writer.WritePropertyName("enableReprocessing");
                    writer.WriteBooleanValue(EnableReprocessing.Value);
                }
                else
                {
                    writer.WriteNull("enableReprocessing");
                }
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerCache DeserializeSearchIndexerCache(JsonElement element)
        {
            Optional<string> storageConnectionString = default;
            Optional<bool?> enableReprocessing = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageConnectionString"))
                {
                    storageConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableReprocessing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableReprocessing = null;
                        continue;
                    }
                    enableReprocessing = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SearchIndexerCache(storageConnectionString.Value, Optional.ToNullable(enableReprocessing));
        }
    }
}