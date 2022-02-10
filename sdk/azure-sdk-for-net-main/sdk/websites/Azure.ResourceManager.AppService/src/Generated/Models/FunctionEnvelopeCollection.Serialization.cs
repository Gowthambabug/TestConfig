// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class FunctionEnvelopeCollection
    {
        internal static FunctionEnvelopeCollection DeserializeFunctionEnvelopeCollection(JsonElement element)
        {
            IReadOnlyList<FunctionEnvelopeData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<FunctionEnvelopeData> array = new List<FunctionEnvelopeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FunctionEnvelopeData.DeserializeFunctionEnvelopeData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FunctionEnvelopeCollection(value, nextLink.Value);
        }
    }
}