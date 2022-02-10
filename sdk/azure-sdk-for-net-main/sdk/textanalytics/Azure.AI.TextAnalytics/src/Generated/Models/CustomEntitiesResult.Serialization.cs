// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class CustomEntitiesResult
    {
        internal static CustomEntitiesResult DeserializeCustomEntitiesResult(JsonElement element)
        {
            IReadOnlyList<DocumentEntities> documents = default;
            IReadOnlyList<DocumentError> errors = default;
            Optional<TextDocumentBatchStatistics> statistics = default;
            string projectName = default;
            string deploymentName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"))
                {
                    List<DocumentEntities> array = new List<DocumentEntities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentEntities.DeserializeDocumentEntities(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("projectName"))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentName"))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
            }
            return new CustomEntitiesResult(documents, errors, statistics.Value, projectName, deploymentName);
        }
    }
}