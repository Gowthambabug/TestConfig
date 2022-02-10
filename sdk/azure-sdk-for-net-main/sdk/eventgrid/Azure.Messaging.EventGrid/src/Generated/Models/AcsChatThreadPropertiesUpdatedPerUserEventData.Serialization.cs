// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadPropertiesUpdatedPerUserEventDataConverter))]
    public partial class AcsChatThreadPropertiesUpdatedPerUserEventData
    {
        internal static AcsChatThreadPropertiesUpdatedPerUserEventData DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(JsonElement element)
        {
            Optional<CommunicationIdentifierModel> editedByCommunicationIdentifier = default;
            Optional<DateTimeOffset> editTime = default;
            Optional<IReadOnlyDictionary<string, object>> properties = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<long> version = default;
            Optional<CommunicationIdentifierModel> recipientCommunicationIdentifier = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("editedByCommunicationIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    editedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("editTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    editTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("createTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recipientCommunicationIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recipientCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("transactionId"))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatThreadPropertiesUpdatedPerUserEventData(recipientCommunicationIdentifier.Value, transactionId.Value, threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version), editedByCommunicationIdentifier.Value, Optional.ToNullable(editTime), Optional.ToDictionary(properties));
        }

        internal partial class AcsChatThreadPropertiesUpdatedPerUserEventDataConverter : JsonConverter<AcsChatThreadPropertiesUpdatedPerUserEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadPropertiesUpdatedPerUserEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsChatThreadPropertiesUpdatedPerUserEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(document.RootElement);
            }
        }
    }
}