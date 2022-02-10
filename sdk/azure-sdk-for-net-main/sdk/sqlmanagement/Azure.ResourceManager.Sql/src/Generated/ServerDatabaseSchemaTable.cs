// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ServerDatabaseSchemaTable along with the instance operations that can be performed on it. </summary>
    public partial class ServerDatabaseSchemaTable : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerDatabaseSchemaTable"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverDatabaseSchemaTableDatabaseTablesClientDiagnostics;
        private readonly DatabaseTablesRestOperations _serverDatabaseSchemaTableDatabaseTablesRestClient;
        private readonly DatabaseTableData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaTable"/> class for mocking. </summary>
        protected ServerDatabaseSchemaTable()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerDatabaseSchemaTable"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerDatabaseSchemaTable(ArmClient client, DatabaseTableData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaTable"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerDatabaseSchemaTable(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDatabaseSchemaTableDatabaseTablesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string serverDatabaseSchemaTableDatabaseTablesApiVersion);
            _serverDatabaseSchemaTableDatabaseTablesRestClient = new DatabaseTablesRestOperations(_serverDatabaseSchemaTableDatabaseTablesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverDatabaseSchemaTableDatabaseTablesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/schemas/tables";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseTableData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ServerDatabaseSchemaTableColumns in the ServerDatabaseSchemaTableColumn. </summary>
        /// <returns> An object representing collection of ServerDatabaseSchemaTableColumns and their operations over a ServerDatabaseSchemaTableColumn. </returns>
        public virtual ServerDatabaseSchemaTableColumnCollection GetServerDatabaseSchemaTableColumns()
        {
            return new ServerDatabaseSchemaTableColumnCollection(Client, Id);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: DatabaseTables_Get
        /// <summary> Get database table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerDatabaseSchemaTable>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableDatabaseTablesClientDiagnostics.CreateScope("ServerDatabaseSchemaTable.Get");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaTableDatabaseTablesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverDatabaseSchemaTableDatabaseTablesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}
        /// OperationId: DatabaseTables_Get
        /// <summary> Get database table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerDatabaseSchemaTable> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverDatabaseSchemaTableDatabaseTablesClientDiagnostics.CreateScope("ServerDatabaseSchemaTable.Get");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaTableDatabaseTablesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _serverDatabaseSchemaTableDatabaseTablesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchemaTable(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}