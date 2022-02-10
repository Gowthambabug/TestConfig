// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure File Storage write settings. </summary>
    public partial class AzureFileStorageWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of AzureFileStorageWriteSettings. </summary>
        public AzureFileStorageWriteSettings()
        {
            Type = "AzureFileStorageWriteSettings";
        }

        /// <summary> Initializes a new instance of AzureFileStorageWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal AzureFileStorageWriteSettings(string type, object maxConcurrentConnections, object copyBehavior, IDictionary<string, object> additionalProperties) : base(type, maxConcurrentConnections, copyBehavior, additionalProperties)
        {
            Type = type ?? "AzureFileStorageWriteSettings";
        }
    }
}