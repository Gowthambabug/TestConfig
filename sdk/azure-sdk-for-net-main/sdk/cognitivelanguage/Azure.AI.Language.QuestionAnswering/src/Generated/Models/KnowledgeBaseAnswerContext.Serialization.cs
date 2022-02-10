// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class KnowledgeBaseAnswerContext : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("previousQnaId");
            writer.WriteNumberValue(PreviousQnaId);
            if (Optional.IsDefined(PreviousQuestion))
            {
                writer.WritePropertyName("previousUserQuery");
                writer.WriteStringValue(PreviousQuestion);
            }
            writer.WriteEndObject();
        }
    }
}