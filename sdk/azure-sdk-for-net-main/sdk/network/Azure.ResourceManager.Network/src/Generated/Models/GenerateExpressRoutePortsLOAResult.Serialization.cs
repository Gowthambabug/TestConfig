// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GenerateExpressRoutePortsLOAResult
    {
        internal static GenerateExpressRoutePortsLOAResult DeserializeGenerateExpressRoutePortsLOAResult(JsonElement element)
        {
            Optional<string> encodedContent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedContent"))
                {
                    encodedContent = property.Value.GetString();
                    continue;
                }
            }
            return new GenerateExpressRoutePortsLOAResult(encodedContent.Value);
        }
    }
}
