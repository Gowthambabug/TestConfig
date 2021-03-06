// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    public partial class PersonalizerMultiSlotRankResult
    {
        internal static PersonalizerMultiSlotRankResult DeserializePersonalizerMultiSlotRankResult(JsonElement element)
        {
            Optional<IReadOnlyList<PersonalizerSlotResult>> slots = default;
            Optional<string> eventId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("slots"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PersonalizerSlotResult> array = new List<PersonalizerSlotResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PersonalizerSlotResult.DeserializePersonalizerSlotResult(item));
                    }
                    slots = array;
                    continue;
                }
                if (property.NameEquals("eventId"))
                {
                    eventId = property.Value.GetString();
                    continue;
                }
            }
            return new PersonalizerMultiSlotRankResult(Optional.ToList(slots), eventId.Value);
        }
    }
}
