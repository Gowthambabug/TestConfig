// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApplicationPackageContact
    {
        internal static ApplicationPackageContact DeserializeApplicationPackageContact(JsonElement element)
        {
            Optional<string> contactName = default;
            string email = default;
            string phone = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contactName"))
                {
                    contactName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phone"))
                {
                    phone = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationPackageContact(contactName.Value, email, phone);
        }
    }
}
