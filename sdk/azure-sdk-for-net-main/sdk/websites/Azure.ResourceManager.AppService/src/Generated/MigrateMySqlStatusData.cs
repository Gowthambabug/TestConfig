// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the MigrateMySqlStatus data model. </summary>
    public partial class MigrateMySqlStatusData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of MigrateMySqlStatusData. </summary>
        public MigrateMySqlStatusData()
        {
        }

        /// <summary> Initializes a new instance of MigrateMySqlStatusData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="migrationOperationStatus"> Status of the migration task. </param>
        /// <param name="operationId"> Operation ID for the migration task. </param>
        /// <param name="localMySqlEnabled"> True if the web app has in app MySql enabled. </param>
        internal MigrateMySqlStatusData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, OperationStatus? migrationOperationStatus, string operationId, bool? localMySqlEnabled) : base(id, name, type, systemData, kind)
        {
            MigrationOperationStatus = migrationOperationStatus;
            OperationId = operationId;
            LocalMySqlEnabled = localMySqlEnabled;
        }

        /// <summary> Status of the migration task. </summary>
        public OperationStatus? MigrationOperationStatus { get; }
        /// <summary> Operation ID for the migration task. </summary>
        public string OperationId { get; }
        /// <summary> True if the web app has in app MySql enabled. </summary>
        public bool? LocalMySqlEnabled { get; }
    }
}