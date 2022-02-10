// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of DatabaseSchema and their operations over its parent. </summary>
    public partial class ServerDatabaseSchemaCollection : ArmCollection, IEnumerable<ServerDatabaseSchema>, IAsyncEnumerable<ServerDatabaseSchema>
    {
        private readonly ClientDiagnostics _serverDatabaseSchemaDatabaseSchemasClientDiagnostics;
        private readonly DatabaseSchemasRestOperations _serverDatabaseSchemaDatabaseSchemasRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaCollection"/> class for mocking. </summary>
        protected ServerDatabaseSchemaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDatabaseSchemaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerDatabaseSchemaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDatabaseSchemaDatabaseSchemasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerDatabaseSchema.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ServerDatabaseSchema.ResourceType, out string serverDatabaseSchemaDatabaseSchemasApiVersion);
            _serverDatabaseSchemaDatabaseSchemasRestClient = new DatabaseSchemasRestOperations(_serverDatabaseSchemaDatabaseSchemasClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverDatabaseSchemaDatabaseSchemasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_Get
        /// <summary> Get database schema. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public async virtual Task<Response<ServerDatabaseSchema>> GetAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaDatabaseSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_Get
        /// <summary> Get database schema. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<ServerDatabaseSchema> Get(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaDatabaseSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken);
                if (response.Value == null)
                    throw _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_ListByDatabase
        /// <summary> List database schemas. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDatabaseSchema" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDatabaseSchema> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDatabaseSchema>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDatabaseSchemaDatabaseSchemasRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchema(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDatabaseSchema>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDatabaseSchemaDatabaseSchemasRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchema(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_ListByDatabase
        /// <summary> List database schemas. </summary>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDatabaseSchema" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDatabaseSchema> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ServerDatabaseSchema> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDatabaseSchemaDatabaseSchemasRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchema(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDatabaseSchema> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDatabaseSchemaDatabaseSchemasRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDatabaseSchema(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(schemaName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public async virtual Task<Response<ServerDatabaseSchema>> GetIfExistsAsync(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverDatabaseSchemaDatabaseSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerDatabaseSchema>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/schemas/{schemaName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: DatabaseSchemas_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaName"/> is null. </exception>
        public virtual Response<ServerDatabaseSchema> GetIfExists(string schemaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));

            using var scope = _serverDatabaseSchemaDatabaseSchemasClientDiagnostics.CreateScope("ServerDatabaseSchemaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDatabaseSchemaDatabaseSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, schemaName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerDatabaseSchema>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDatabaseSchema(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerDatabaseSchema> IEnumerable<ServerDatabaseSchema>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDatabaseSchema> IAsyncEnumerable<ServerDatabaseSchema>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}