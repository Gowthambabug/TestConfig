// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The ExtractiveSummarizationResult. </summary>
    internal partial class ExtractiveSummarizationResult
    {
        /// <summary> Initializes a new instance of ExtractiveSummarizationResult. </summary>
        /// <param name="documents"> Response by document. </param>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documents"/>, <paramref name="errors"/>, or <paramref name="modelVersion"/> is null. </exception>
        internal ExtractiveSummarizationResult(IEnumerable<ExtractedDocumentSummary> documents, IEnumerable<DocumentError> errors, string modelVersion)
        {
            if (documents == null)
            {
                throw new ArgumentNullException(nameof(documents));
            }
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }
            if (modelVersion == null)
            {
                throw new ArgumentNullException(nameof(modelVersion));
            }

            Documents = documents.ToList();
            Errors = errors.ToList();
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of ExtractiveSummarizationResult. </summary>
        /// <param name="documents"> Response by document. </param>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        internal ExtractiveSummarizationResult(IReadOnlyList<ExtractedDocumentSummary> documents, IReadOnlyList<DocumentError> errors, TextDocumentBatchStatistics statistics, string modelVersion)
        {
            Documents = documents;
            Errors = errors;
            Statistics = statistics;
            ModelVersion = modelVersion;
        }

        /// <summary> Response by document. </summary>
        public IReadOnlyList<ExtractedDocumentSummary> Documents { get; }
        /// <summary> Errors by document id. </summary>
        public IReadOnlyList<DocumentError> Errors { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public TextDocumentBatchStatistics Statistics { get; }
        /// <summary> This field indicates which model is used for scoring. </summary>
        public string ModelVersion { get; }
    }
}