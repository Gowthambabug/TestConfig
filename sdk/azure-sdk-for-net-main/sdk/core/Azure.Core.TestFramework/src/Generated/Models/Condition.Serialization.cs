// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    public partial class Condition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UriRegex))
            {
                writer.WritePropertyName("uriRegex");
                writer.WriteStringValue(UriRegex);
            }
            if (Optional.IsDefined(ResponseHeader))
            {
                writer.WritePropertyName("responseHeader");
                writer.WriteObjectValue(ResponseHeader);
            }
            writer.WriteEndObject();
        }
    }
}