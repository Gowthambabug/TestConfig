// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchResourceCounter
    {
        internal static SearchResourceCounter DeserializeSearchResourceCounter(JsonElement element)
        {
            long usage = default;
            Optional<long?> quota = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usage"))
                {
                    usage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("quota"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        quota = null;
                        continue;
                    }
                    quota = property.Value.GetInt64();
                    continue;
                }
            }
            return new SearchResourceCounter(usage, Optional.ToNullable(quota));
        }
    }
}