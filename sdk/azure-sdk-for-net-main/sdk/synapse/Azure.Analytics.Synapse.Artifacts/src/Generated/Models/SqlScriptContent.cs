// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The content of the SQL script. </summary>
    public partial class SqlScriptContent
    {
        /// <summary> Initializes a new instance of SqlScriptContent. </summary>
        /// <param name="query"> SQL query to execute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="query"/> is null. </exception>
        public SqlScriptContent(string query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            Query = query;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of SqlScriptContent. </summary>
        /// <param name="query"> SQL query to execute. </param>
        /// <param name="currentConnection"> The connection used to execute the SQL script. </param>
        /// <param name="resultLimit"> Limit of results, &apos;-1&apos; for no limit. </param>
        /// <param name="metadata"> The metadata of the SQL script. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SqlScriptContent(string query, SqlConnection currentConnection, int? resultLimit, SqlScriptMetadata metadata, IDictionary<string, object> additionalProperties)
        {
            Query = query;
            CurrentConnection = currentConnection;
            ResultLimit = resultLimit;
            Metadata = metadata;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> SQL query to execute. </summary>
        public string Query { get; set; }
        /// <summary> The connection used to execute the SQL script. </summary>
        public SqlConnection CurrentConnection { get; set; }
        /// <summary> Limit of results, &apos;-1&apos; for no limit. </summary>
        public int? ResultLimit { get; set; }
        /// <summary> The metadata of the SQL script. </summary>
        public SqlScriptMetadata Metadata { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}