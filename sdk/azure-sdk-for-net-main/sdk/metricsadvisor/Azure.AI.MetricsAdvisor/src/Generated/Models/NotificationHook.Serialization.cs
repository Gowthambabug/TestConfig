// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class NotificationHook : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
    }
}