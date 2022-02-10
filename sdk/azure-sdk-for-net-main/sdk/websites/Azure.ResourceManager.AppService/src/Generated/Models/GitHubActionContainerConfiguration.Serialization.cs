// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class GitHubActionContainerConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerUrl))
            {
                writer.WritePropertyName("serverUrl");
                writer.WriteStringValue(ServerUrl);
            }
            if (Optional.IsDefined(ImageName))
            {
                writer.WritePropertyName("imageName");
                writer.WriteStringValue(ImageName);
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username");
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            writer.WriteEndObject();
        }

        internal static GitHubActionContainerConfiguration DeserializeGitHubActionContainerConfiguration(JsonElement element)
        {
            Optional<string> serverUrl = default;
            Optional<string> imageName = default;
            Optional<string> username = default;
            Optional<string> password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverUrl"))
                {
                    serverUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
            }
            return new GitHubActionContainerConfiguration(serverUrl.Value, imageName.Value, username.Value, password.Value);
        }
    }
}