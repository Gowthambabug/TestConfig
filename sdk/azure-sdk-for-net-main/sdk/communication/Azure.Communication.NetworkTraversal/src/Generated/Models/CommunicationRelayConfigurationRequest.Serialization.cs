// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.NetworkTraversal
{
    internal partial class CommunicationRelayConfigurationRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(RouteType))
            {
                writer.WritePropertyName("routeType");
                writer.WriteStringValue(RouteType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}