// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SkuInfos
    {
        internal static SkuInfos DeserializeSkuInfos(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<IReadOnlyList<GlobalCsmSkuDescription>> skus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GlobalCsmSkuDescription> array = new List<GlobalCsmSkuDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GlobalCsmSkuDescription.DeserializeGlobalCsmSkuDescription(item));
                    }
                    skus = array;
                    continue;
                }
            }
            return new SkuInfos(resourceType.Value, Optional.ToList(skus));
        }
    }
}
