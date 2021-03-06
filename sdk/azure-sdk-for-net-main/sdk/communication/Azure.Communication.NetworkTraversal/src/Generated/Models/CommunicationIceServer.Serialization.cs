// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.NetworkTraversal
{
    public partial class CommunicationIceServer
    {
        internal static CommunicationIceServer DeserializeCommunicationIceServer(JsonElement element)
        {
            IReadOnlyList<string> urls = default;
            string username = default;
            string credential = default;
            RouteType routeType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("urls"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    urls = array;
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credential"))
                {
                    credential = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routeType"))
                {
                    routeType = new RouteType(property.Value.GetString());
                    continue;
                }
            }
            return new CommunicationIceServer(urls, username, credential, routeType);
        }
    }
}
