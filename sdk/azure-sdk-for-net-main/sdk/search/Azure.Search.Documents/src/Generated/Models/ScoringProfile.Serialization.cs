// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ScoringProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(TextWeights))
            {
                if (TextWeights != null)
                {
                    writer.WritePropertyName("text");
                    writer.WriteObjectValue(TextWeights);
                }
                else
                {
                    writer.WriteNull("text");
                }
            }
            if (Optional.IsCollectionDefined(Functions))
            {
                writer.WritePropertyName("functions");
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FunctionAggregation))
            {
                if (FunctionAggregation != null)
                {
                    writer.WritePropertyName("functionAggregation");
                    writer.WriteStringValue(FunctionAggregation.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("functionAggregation");
                }
            }
            writer.WriteEndObject();
        }

        internal static ScoringProfile DeserializeScoringProfile(JsonElement element)
        {
            string name = default;
            Optional<TextWeights> text = default;
            Optional<IList<ScoringFunction>> functions = default;
            Optional<ScoringFunctionAggregation?> functionAggregation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        text = null;
                        continue;
                    }
                    text = TextWeights.DeserializeTextWeights(property.Value);
                    continue;
                }
                if (property.NameEquals("functions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ScoringFunction> array = new List<ScoringFunction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScoringFunction.DeserializeScoringFunction(item));
                    }
                    functions = array;
                    continue;
                }
                if (property.NameEquals("functionAggregation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        functionAggregation = null;
                        continue;
                    }
                    functionAggregation = property.Value.GetString().ToScoringFunctionAggregation();
                    continue;
                }
            }
            return new ScoringProfile(name, text.Value, Optional.ToList(functions), Optional.ToNullable(functionAggregation));
        }
    }
}