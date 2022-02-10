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
    [JsonConverter(typeof(LibraryResourcePropertiesConverter))]
    public partial class LibraryResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static LibraryResourceProperties DeserializeLibraryResourceProperties(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> path = default;
            Optional<string> containerName = default;
            Optional<string> uploadedTimestamp = default;
            Optional<string> type = default;
            Optional<string> provisioningStatus = default;
            Optional<string> creatorId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadedTimestamp"))
                {
                    uploadedTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"))
                {
                    provisioningStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creatorId"))
                {
                    creatorId = property.Value.GetString();
                    continue;
                }
            }
            return new LibraryResourceProperties(name.Value, path.Value, containerName.Value, uploadedTimestamp.Value, type.Value, provisioningStatus.Value, creatorId.Value);
        }

        internal partial class LibraryResourcePropertiesConverter : JsonConverter<LibraryResourceProperties>
        {
            public override void Write(Utf8JsonWriter writer, LibraryResourceProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LibraryResourceProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryResourceProperties(document.RootElement);
            }
        }
    }
}