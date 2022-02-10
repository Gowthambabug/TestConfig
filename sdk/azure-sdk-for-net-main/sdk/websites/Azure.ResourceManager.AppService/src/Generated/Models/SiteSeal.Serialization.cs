// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SiteSeal
    {
        internal static SiteSeal DeserializeSiteSeal(JsonElement element)
        {
            string html = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("html"))
                {
                    html = property.Value.GetString();
                    continue;
                }
            }
            return new SiteSeal(html);
        }
    }
}