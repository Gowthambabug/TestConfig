// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of pipeline resources. </summary>
    internal partial class PipelineListResponse
    {
        /// <summary> Initializes a new instance of PipelineListResponse. </summary>
        /// <param name="value"> List of pipelines. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal PipelineListResponse(IEnumerable<PipelineResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of PipelineListResponse. </summary>
        /// <param name="value"> List of pipelines. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal PipelineListResponse(IReadOnlyList<PipelineResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of pipelines. </summary>
        public IReadOnlyList<PipelineResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}