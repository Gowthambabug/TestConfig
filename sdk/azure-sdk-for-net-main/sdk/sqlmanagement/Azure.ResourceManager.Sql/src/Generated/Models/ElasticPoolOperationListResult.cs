// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The response to a list elastic pool operations request. </summary>
    internal partial class ElasticPoolOperationListResult
    {
        /// <summary> Initializes a new instance of ElasticPoolOperationListResult. </summary>
        internal ElasticPoolOperationListResult()
        {
            Value = new ChangeTrackingList<ElasticPoolOperation>();
        }

        /// <summary> Initializes a new instance of ElasticPoolOperationListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ElasticPoolOperationListResult(IReadOnlyList<ElasticPoolOperation> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ElasticPoolOperation> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}