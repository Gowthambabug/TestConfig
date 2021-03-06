// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ApiDefinitionInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Url);
            }
            writer.WriteEndObject();
        }

        internal static ApiDefinitionInfo DeserializeApiDefinitionInfo(JsonElement element)
        {
            Optional<string> url = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
            }
            return new ApiDefinitionInfo(url.Value);
        }
    }
}
