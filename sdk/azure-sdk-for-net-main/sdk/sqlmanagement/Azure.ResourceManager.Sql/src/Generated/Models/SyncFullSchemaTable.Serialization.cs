// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncFullSchemaTable
    {
        internal static SyncFullSchemaTable DeserializeSyncFullSchemaTable(JsonElement element)
        {
            Optional<IReadOnlyList<SyncFullSchemaTableColumn>> columns = default;
            Optional<string> errorId = default;
            Optional<bool> hasError = default;
            Optional<string> name = default;
            Optional<string> quotedName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SyncFullSchemaTableColumn> array = new List<SyncFullSchemaTableColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncFullSchemaTableColumn.DeserializeSyncFullSchemaTableColumn(item));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("errorId"))
                {
                    errorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hasError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotedName"))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
            }
            return new SyncFullSchemaTable(Optional.ToList(columns), errorId.Value, Optional.ToNullable(hasError), name.Value, quotedName.Value);
        }
    }
}