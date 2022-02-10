// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class HostingEnvironmentDiagnostics
    {
        internal static HostingEnvironmentDiagnostics DeserializeHostingEnvironmentDiagnostics(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> diagnosticsOutput = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diagnosticsOutput"))
                {
                    diagnosticsOutput = property.Value.GetString();
                    continue;
                }
            }
            return new HostingEnvironmentDiagnostics(name.Value, diagnosticsOutput.Value);
        }
    }
}