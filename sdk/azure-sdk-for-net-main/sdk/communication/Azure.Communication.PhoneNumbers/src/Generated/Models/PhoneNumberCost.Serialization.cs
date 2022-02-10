// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    public partial class PhoneNumberCost
    {
        internal static PhoneNumberCost DeserializePhoneNumberCost(JsonElement element)
        {
            double amount = default;
            string currencyCode = default;
            BillingFrequency billingFrequency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"))
                {
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("currencyCode"))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingFrequency"))
                {
                    billingFrequency = new BillingFrequency(property.Value.GetString());
                    continue;
                }
            }
            return new PhoneNumberCost(amount, currencyCode, billingFrequency);
        }
    }
}