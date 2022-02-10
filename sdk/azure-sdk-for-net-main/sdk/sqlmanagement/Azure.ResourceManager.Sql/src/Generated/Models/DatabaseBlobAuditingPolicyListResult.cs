// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of database auditing settings. </summary>
    internal partial class DatabaseBlobAuditingPolicyListResult
    {
        /// <summary> Initializes a new instance of DatabaseBlobAuditingPolicyListResult. </summary>
        internal DatabaseBlobAuditingPolicyListResult()
        {
            Value = new ChangeTrackingList<DatabaseBlobAuditingPolicyData>();
        }

        /// <summary> Initializes a new instance of DatabaseBlobAuditingPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal DatabaseBlobAuditingPolicyListResult(IReadOnlyList<DatabaseBlobAuditingPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<DatabaseBlobAuditingPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}