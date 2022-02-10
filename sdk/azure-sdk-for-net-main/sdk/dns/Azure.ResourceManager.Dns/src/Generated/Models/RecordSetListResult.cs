// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> The response to a record set List operation. </summary>
    internal partial class RecordSetListResult
    {
        /// <summary> Initializes a new instance of RecordSetListResult. </summary>
        internal RecordSetListResult()
        {
            Value = new ChangeTrackingList<RecordSet>();
        }

        /// <summary> Initializes a new instance of RecordSetListResult. </summary>
        /// <param name="value"> Information about the record sets in the response. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        internal RecordSetListResult(IReadOnlyList<RecordSet> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Information about the record sets in the response. </summary>
        public IReadOnlyList<RecordSet> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}