// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class NetworkIsolationSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId");
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(SqlServerResourceId))
            {
                writer.WritePropertyName("sqlServerResourceId");
                writer.WriteStringValue(SqlServerResourceId);
            }
            writer.WriteEndObject();
        }
    }
}