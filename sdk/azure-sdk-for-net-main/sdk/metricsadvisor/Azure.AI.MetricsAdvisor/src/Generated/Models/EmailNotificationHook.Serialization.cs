// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class EmailNotificationHook : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hookParameter");
            writer.WriteObjectValue(HookParameter);
            writer.WritePropertyName("hookType");
            writer.WriteStringValue(HookKind.ToString());
            writer.WritePropertyName("hookName");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(InternalExternalLink))
            {
                writer.WritePropertyName("externalLink");
                writer.WriteStringValue(InternalExternalLink);
            }
            if (Optional.IsCollectionDefined(Administrators))
            {
                writer.WritePropertyName("admins");
                writer.WriteStartArray();
                foreach (var item in Administrators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EmailNotificationHook DeserializeEmailNotificationHook(JsonElement element)
        {
            EmailHookParameter hookParameter = default;
            NotificationHookKind hookType = default;
            Optional<string> hookId = default;
            string hookName = default;
            Optional<string> description = default;
            Optional<string> externalLink = default;
            Optional<IList<string>> admins = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hookParameter"))
                {
                    hookParameter = EmailHookParameter.DeserializeEmailHookParameter(property.Value);
                    continue;
                }
                if (property.NameEquals("hookType"))
                {
                    hookType = new NotificationHookKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hookId"))
                {
                    hookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hookName"))
                {
                    hookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("externalLink"))
                {
                    externalLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("admins"))
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
                    admins = array;
                    continue;
                }
            }
            return new EmailNotificationHook(hookType, hookId.Value, hookName, description.Value, externalLink.Value, Optional.ToList(admins), hookParameter);
        }
    }
}