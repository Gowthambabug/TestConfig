// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    public partial class PersonalizerPolicyResult
    {
        internal static PersonalizerPolicyResult DeserializePersonalizerPolicyResult(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> arguments = default;
            Optional<PersonalizerPolicySource> policySource = default;
            Optional<IReadOnlyList<PersonalizerPolicyResultSummary>> summary = default;
            Optional<PersonalizerPolicyResultSummary> totalSummary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"))
                {
                    arguments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policySource = new PersonalizerPolicySource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("summary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PersonalizerPolicyResultSummary> array = new List<PersonalizerPolicyResultSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PersonalizerPolicyResultSummary.DeserializePersonalizerPolicyResultSummary(item));
                    }
                    summary = array;
                    continue;
                }
                if (property.NameEquals("totalSummary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalSummary = PersonalizerPolicyResultSummary.DeserializePersonalizerPolicyResultSummary(property.Value);
                    continue;
                }
            }
            return new PersonalizerPolicyResult(name.Value, arguments.Value, Optional.ToNullable(policySource), Optional.ToList(summary), totalSummary.Value);
        }
    }
}