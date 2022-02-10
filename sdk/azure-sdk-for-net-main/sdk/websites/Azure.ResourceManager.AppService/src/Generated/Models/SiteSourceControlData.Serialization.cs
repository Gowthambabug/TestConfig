// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteSourceControlData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RepoUrl))
            {
                writer.WritePropertyName("repoUrl");
                writer.WriteStringValue(RepoUrl);
            }
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch");
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(IsManualIntegration))
            {
                writer.WritePropertyName("isManualIntegration");
                writer.WriteBooleanValue(IsManualIntegration.Value);
            }
            if (Optional.IsDefined(IsGitHubAction))
            {
                writer.WritePropertyName("isGitHubAction");
                writer.WriteBooleanValue(IsGitHubAction.Value);
            }
            if (Optional.IsDefined(DeploymentRollbackEnabled))
            {
                writer.WritePropertyName("deploymentRollbackEnabled");
                writer.WriteBooleanValue(DeploymentRollbackEnabled.Value);
            }
            if (Optional.IsDefined(IsMercurial))
            {
                writer.WritePropertyName("isMercurial");
                writer.WriteBooleanValue(IsMercurial.Value);
            }
            if (Optional.IsDefined(GitHubActionConfiguration))
            {
                if (GitHubActionConfiguration != null)
                {
                    writer.WritePropertyName("gitHubActionConfiguration");
                    writer.WriteObjectValue(GitHubActionConfiguration);
                }
                else
                {
                    writer.WriteNull("gitHubActionConfiguration");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SiteSourceControlData DeserializeSiteSourceControlData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> repoUrl = default;
            Optional<string> branch = default;
            Optional<bool> isManualIntegration = default;
            Optional<bool> isGitHubAction = default;
            Optional<bool> deploymentRollbackEnabled = default;
            Optional<bool> isMercurial = default;
            Optional<GitHubActionConfiguration> gitHubActionConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("repoUrl"))
                        {
                            repoUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("branch"))
                        {
                            branch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isManualIntegration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isManualIntegration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isGitHubAction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isGitHubAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deploymentRollbackEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentRollbackEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isMercurial"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isMercurial = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gitHubActionConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gitHubActionConfiguration = null;
                                continue;
                            }
                            gitHubActionConfiguration = GitHubActionConfiguration.DeserializeGitHubActionConfiguration(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SiteSourceControlData(id, name, type, systemData, kind.Value, repoUrl.Value, branch.Value, Optional.ToNullable(isManualIntegration), Optional.ToNullable(isGitHubAction), Optional.ToNullable(deploymentRollbackEnabled), Optional.ToNullable(isMercurial), gitHubActionConfiguration.Value);
        }
    }
}