// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class ConnectionDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static ConnectionDetails DeserializeConnectionDetails(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> privateIpAddress = default;
            Optional<string> linkIdentifier = default;
            Optional<string> groupId = default;
            Optional<string> memberName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"))
                {
                    privateIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkIdentifier"))
                {
                    linkIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memberName"))
                {
                    memberName = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectionDetails(id.Value, privateIpAddress.Value, linkIdentifier.Value, groupId.Value, memberName.Value);
        }
    }
}