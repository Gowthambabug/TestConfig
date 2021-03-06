// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApplicationClientDetails
    {
        internal static ApplicationClientDetails DeserializeApplicationClientDetails(JsonElement element)
        {
            Optional<string> oid = default;
            Optional<string> puid = default;
            Optional<string> applicationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oid"))
                {
                    oid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("puid"))
                {
                    puid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationClientDetails(oid.Value, puid.Value, applicationId.Value);
        }
    }
}
