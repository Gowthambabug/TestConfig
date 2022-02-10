// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs to Azure table storage configuration. </summary>
    public partial class AzureTableStorageApplicationLogsConfig
    {
        /// <summary> Initializes a new instance of AzureTableStorageApplicationLogsConfig. </summary>
        /// <param name="sasUrl"> SAS URL to an Azure table with add/query/delete permissions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sasUrl"/> is null. </exception>
        public AzureTableStorageApplicationLogsConfig(string sasUrl)
        {
            if (sasUrl == null)
            {
                throw new ArgumentNullException(nameof(sasUrl));
            }

            SasUrl = sasUrl;
        }

        /// <summary> Initializes a new instance of AzureTableStorageApplicationLogsConfig. </summary>
        /// <param name="level"> Log level. </param>
        /// <param name="sasUrl"> SAS URL to an Azure table with add/query/delete permissions. </param>
        internal AzureTableStorageApplicationLogsConfig(LogLevel? level, string sasUrl)
        {
            Level = level;
            SasUrl = sasUrl;
        }

        /// <summary> Log level. </summary>
        public LogLevel? Level { get; set; }
        /// <summary> SAS URL to an Azure table with add/query/delete permissions. </summary>
        public string SasUrl { get; set; }
    }
}