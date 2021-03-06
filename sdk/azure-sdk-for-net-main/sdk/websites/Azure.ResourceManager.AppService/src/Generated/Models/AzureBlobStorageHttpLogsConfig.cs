// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Http logs to azure blob storage configuration. </summary>
    public partial class AzureBlobStorageHttpLogsConfig
    {
        /// <summary> Initializes a new instance of AzureBlobStorageHttpLogsConfig. </summary>
        public AzureBlobStorageHttpLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of AzureBlobStorageHttpLogsConfig. </summary>
        /// <param name="sasUrl"> SAS url to a azure blob container with read/write/list/delete permissions. </param>
        /// <param name="retentionInDays">
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </param>
        /// <param name="enabled"> True if configuration is enabled, false if it is disabled and null if configuration is not set. </param>
        internal AzureBlobStorageHttpLogsConfig(string sasUrl, int? retentionInDays, bool? enabled)
        {
            SasUrl = sasUrl;
            RetentionInDays = retentionInDays;
            Enabled = enabled;
        }

        /// <summary> SAS url to a azure blob container with read/write/list/delete permissions. </summary>
        public string SasUrl { get; set; }
        /// <summary>
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        public int? RetentionInDays { get; set; }
        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? Enabled { get; set; }
    }
}
