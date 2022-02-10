// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    public partial class HeaderCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteStringValue(Key);
            }
            if (Optional.IsDefined(ValueRegex))
            {
                writer.WritePropertyName("valueRegex");
                writer.WriteStringValue(ValueRegex);
            }
            writer.WriteEndObject();
        }
    }
}