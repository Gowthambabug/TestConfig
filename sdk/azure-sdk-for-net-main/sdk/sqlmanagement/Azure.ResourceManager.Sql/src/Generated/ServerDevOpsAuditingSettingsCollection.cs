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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ServerDevOpsAuditingSettings and their operations over its parent. </summary>
    public partial class ServerDevOpsAuditingSettingsCollection : ArmCollection, IEnumerable<ServerDevOpsAuditingSettings>, IAsyncEnumerable<ServerDevOpsAuditingSettings>
    {
        private readonly ClientDiagnostics _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics;
        private readonly ServerDevOpsAuditSettingsRestOperations _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerDevOpsAuditingSettingsCollection"/> class for mocking. </summary>
        protected ServerDevOpsAuditingSettingsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerDevOpsAuditingSettingsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerDevOpsAuditingSettingsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerDevOpsAuditingSettings.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ServerDevOpsAuditingSettings.ResourceType, out string serverDevOpsAuditingSettingsServerDevOpsAuditSettingsApiVersion);
            _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient = new ServerDevOpsAuditSettingsRestOperations(_serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverDevOpsAuditingSettingsServerDevOpsAuditSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServer.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_CreateOrUpdate
        /// <summary> Creates or updates a server&apos;s DevOps audit settings. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="parameters"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServerDevOpsAuditingSettingsCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServerDevOpsAuditingSettingsCreateOrUpdateOperation(Client, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_CreateOrUpdate
        /// <summary> Creates or updates a server&apos;s DevOps audit settings. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="parameters"> Properties of DevOps audit settings. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ServerDevOpsAuditingSettingsCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string devOpsAuditingSettingsName, ServerDevOpsAuditingSettingsData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters, cancellationToken);
                var operation = new ServerDevOpsAuditingSettingsCreateOrUpdateOperation(Client, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics, Pipeline, _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Gets a server&apos;s DevOps audit settings. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public async virtual Task<Response<ServerDevOpsAuditingSettings>> GetAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Gets a server&apos;s DevOps audit settings. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<ServerDevOpsAuditingSettings> Get(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken);
                if (response.Value == null)
                    throw _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_ListByServer
        /// <summary> Lists DevOps audit settings of a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerDevOpsAuditingSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerDevOpsAuditingSettings> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServerDevOpsAuditingSettings>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServerDevOpsAuditingSettings>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_ListByServer
        /// <summary> Lists DevOps audit settings of a server. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerDevOpsAuditingSettings" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerDevOpsAuditingSettings> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServerDevOpsAuditingSettings> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServerDevOpsAuditingSettings> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServerDevOpsAuditingSettings(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(devOpsAuditingSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<bool> Exists(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(devOpsAuditingSettingsName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public async virtual Task<Response<ServerDevOpsAuditingSettings>> GetIfExistsAsync(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerDevOpsAuditingSettings>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/devOpsAuditingSettings/{devOpsAuditingSettingsName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}
        /// OperationId: ServerDevOpsAuditSettings_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="devOpsAuditingSettingsName"> The name of the devops audit settings. This should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="devOpsAuditingSettingsName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="devOpsAuditingSettingsName"/> is null. </exception>
        public virtual Response<ServerDevOpsAuditingSettings> GetIfExists(string devOpsAuditingSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(devOpsAuditingSettingsName, nameof(devOpsAuditingSettingsName));

            using var scope = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsClientDiagnostics.CreateScope("ServerDevOpsAuditingSettingsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverDevOpsAuditingSettingsServerDevOpsAuditSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, devOpsAuditingSettingsName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerDevOpsAuditingSettings>(null, response.GetRawResponse());
                return Response.FromValue(new ServerDevOpsAuditingSettings(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerDevOpsAuditingSettings> IEnumerable<ServerDevOpsAuditingSettings>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerDevOpsAuditingSettings> IAsyncEnumerable<ServerDevOpsAuditingSettings>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}