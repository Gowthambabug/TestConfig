// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure Table sink. </summary>
    public partial class AzureTableSink : CopySink
    {
        /// <summary> Initializes a new instance of AzureTableSink. </summary>
        public AzureTableSink()
        {
            Type = "AzureTableSink";
        }

        /// <summary> Initializes a new instance of AzureTableSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="azureTableDefaultPartitionKeyValue"> Azure Table default partition key value. Type: string (or Expression with resultType string). </param>
        /// <param name="azureTablePartitionKeyName"> Azure Table partition key name. Type: string (or Expression with resultType string). </param>
        /// <param name="azureTableRowKeyName"> Azure Table row key name. Type: string (or Expression with resultType string). </param>
        /// <param name="azureTableInsertType"> Azure Table insert type. Type: string (or Expression with resultType string). </param>
        internal AzureTableSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object azureTableDefaultPartitionKeyValue, object azureTablePartitionKeyName, object azureTableRowKeyName, object azureTableInsertType) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            AzureTableDefaultPartitionKeyValue = azureTableDefaultPartitionKeyValue;
            AzureTablePartitionKeyName = azureTablePartitionKeyName;
            AzureTableRowKeyName = azureTableRowKeyName;
            AzureTableInsertType = azureTableInsertType;
            Type = type ?? "AzureTableSink";
        }

        /// <summary> Azure Table default partition key value. Type: string (or Expression with resultType string). </summary>
        public object AzureTableDefaultPartitionKeyValue { get; set; }
        /// <summary> Azure Table partition key name. Type: string (or Expression with resultType string). </summary>
        public object AzureTablePartitionKeyName { get; set; }
        /// <summary> Azure Table row key name. Type: string (or Expression with resultType string). </summary>
        public object AzureTableRowKeyName { get; set; }
        /// <summary> Azure Table insert type. Type: string (or Expression with resultType string). </summary>
        public object AzureTableInsertType { get; set; }
    }
}