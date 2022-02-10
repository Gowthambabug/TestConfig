// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Performance tier properties
    /// </summary>
    public partial class PerformanceTierProperties
    {
        /// <summary>
        /// Initializes a new instance of the PerformanceTierProperties class.
        /// </summary>
        public PerformanceTierProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerformanceTierProperties class.
        /// </summary>
        /// <param name="id">ID of the performance tier.</param>
        /// <param name="maxBackupRetentionDays">Maximum Backup retention in
        /// days for the performance tier edition</param>
        /// <param name="minBackupRetentionDays">Minimum Backup retention in
        /// days for the performance tier edition</param>
        /// <param name="maxStorageMB">Max storage allowed for a
        /// server.</param>
        /// <param name="minLargeStorageMB">Max storage allowed for a
        /// server.</param>
        /// <param name="maxLargeStorageMB">Max storage allowed for a
        /// server.</param>
        /// <param name="minStorageMB">Max storage allowed for a
        /// server.</param>
        /// <param name="serviceLevelObjectives">Service level objectives
        /// associated with the performance tier</param>
        public PerformanceTierProperties(string id = default(string), int? maxBackupRetentionDays = default(int?), int? minBackupRetentionDays = default(int?), int? maxStorageMB = default(int?), int? minLargeStorageMB = default(int?), int? maxLargeStorageMB = default(int?), int? minStorageMB = default(int?), IList<PerformanceTierServiceLevelObjectives> serviceLevelObjectives = default(IList<PerformanceTierServiceLevelObjectives>))
        {
            Id = id;
            MaxBackupRetentionDays = maxBackupRetentionDays;
            MinBackupRetentionDays = minBackupRetentionDays;
            MaxStorageMB = maxStorageMB;
            MinLargeStorageMB = minLargeStorageMB;
            MaxLargeStorageMB = maxLargeStorageMB;
            MinStorageMB = minStorageMB;
            ServiceLevelObjectives = serviceLevelObjectives;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the performance tier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets maximum Backup retention in days for the performance
        /// tier edition
        /// </summary>
        [JsonProperty(PropertyName = "maxBackupRetentionDays")]
        public int? MaxBackupRetentionDays { get; set; }

        /// <summary>
        /// Gets or sets minimum Backup retention in days for the performance
        /// tier edition
        /// </summary>
        [JsonProperty(PropertyName = "minBackupRetentionDays")]
        public int? MinBackupRetentionDays { get; set; }

        /// <summary>
        /// Gets or sets max storage allowed for a server.
        /// </summary>
        [JsonProperty(PropertyName = "maxStorageMB")]
        public int? MaxStorageMB { get; set; }

        /// <summary>
        /// Gets or sets max storage allowed for a server.
        /// </summary>
        [JsonProperty(PropertyName = "minLargeStorageMB")]
        public int? MinLargeStorageMB { get; set; }

        /// <summary>
        /// Gets or sets max storage allowed for a server.
        /// </summary>
        [JsonProperty(PropertyName = "maxLargeStorageMB")]
        public int? MaxLargeStorageMB { get; set; }

        /// <summary>
        /// Gets or sets max storage allowed for a server.
        /// </summary>
        [JsonProperty(PropertyName = "minStorageMB")]
        public int? MinStorageMB { get; set; }

        /// <summary>
        /// Gets or sets service level objectives associated with the
        /// performance tier
        /// </summary>
        [JsonProperty(PropertyName = "serviceLevelObjectives")]
        public IList<PerformanceTierServiceLevelObjectives> ServiceLevelObjectives { get; set; }

    }
}