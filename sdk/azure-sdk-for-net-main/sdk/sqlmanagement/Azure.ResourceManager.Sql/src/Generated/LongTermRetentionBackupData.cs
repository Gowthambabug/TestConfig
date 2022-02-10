// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the LongTermRetentionBackup data model. </summary>
    public partial class LongTermRetentionBackupData : Resource
    {
        /// <summary> Initializes a new instance of LongTermRetentionBackupData. </summary>
        public LongTermRetentionBackupData()
        {
        }

        /// <summary> Initializes a new instance of LongTermRetentionBackupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serverName"> The server name that the backup database belong to. </param>
        /// <param name="serverCreateTime"> The create time of the server. </param>
        /// <param name="databaseName"> The name of the database the backup belong to. </param>
        /// <param name="databaseDeletionTime"> The delete time of the database. </param>
        /// <param name="backupTime"> The time the backup was taken. </param>
        /// <param name="backupExpirationTime"> The time the long term retention backup will expire. </param>
        /// <param name="backupStorageRedundancy"> The storage redundancy type of the backup. </param>
        /// <param name="requestedBackupStorageRedundancy"> The storage redundancy type of the backup. </param>
        internal LongTermRetentionBackupData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string serverName, DateTimeOffset? serverCreateTime, string databaseName, DateTimeOffset? databaseDeletionTime, DateTimeOffset? backupTime, DateTimeOffset? backupExpirationTime, BackupStorageRedundancy? backupStorageRedundancy, BackupStorageRedundancy? requestedBackupStorageRedundancy) : base(id, name, type, systemData)
        {
            ServerName = serverName;
            ServerCreateTime = serverCreateTime;
            DatabaseName = databaseName;
            DatabaseDeletionTime = databaseDeletionTime;
            BackupTime = backupTime;
            BackupExpirationTime = backupExpirationTime;
            BackupStorageRedundancy = backupStorageRedundancy;
            RequestedBackupStorageRedundancy = requestedBackupStorageRedundancy;
        }

        /// <summary> The server name that the backup database belong to. </summary>
        public string ServerName { get; }
        /// <summary> The create time of the server. </summary>
        public DateTimeOffset? ServerCreateTime { get; }
        /// <summary> The name of the database the backup belong to. </summary>
        public string DatabaseName { get; }
        /// <summary> The delete time of the database. </summary>
        public DateTimeOffset? DatabaseDeletionTime { get; }
        /// <summary> The time the backup was taken. </summary>
        public DateTimeOffset? BackupTime { get; }
        /// <summary> The time the long term retention backup will expire. </summary>
        public DateTimeOffset? BackupExpirationTime { get; }
        /// <summary> The storage redundancy type of the backup. </summary>
        public BackupStorageRedundancy? BackupStorageRedundancy { get; }
        /// <summary> The storage redundancy type of the backup. </summary>
        public BackupStorageRedundancy? RequestedBackupStorageRedundancy { get; set; }
    }
}