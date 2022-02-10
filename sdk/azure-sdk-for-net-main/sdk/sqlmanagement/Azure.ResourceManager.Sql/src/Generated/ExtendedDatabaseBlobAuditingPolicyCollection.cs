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
    /// <summary> A class representing collection of ExtendedDatabaseBlobAuditingPolicy and their operations over its parent. </summary>
    public partial class ExtendedDatabaseBlobAuditingPolicyCollection : ArmCollection, IEnumerable<ExtendedDatabaseBlobAuditingPolicy>, IAsyncEnumerable<ExtendedDatabaseBlobAuditingPolicy>
    {
        private readonly ClientDiagnostics _extendedDatabaseBlobAuditingPolicyClientDiagnostics;
        private readonly ExtendedDatabaseBlobAuditingPoliciesRestOperations _extendedDatabaseBlobAuditingPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExtendedDatabaseBlobAuditingPolicyCollection"/> class for mocking. </summary>
        protected ExtendedDatabaseBlobAuditingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExtendedDatabaseBlobAuditingPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExtendedDatabaseBlobAuditingPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _extendedDatabaseBlobAuditingPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ExtendedDatabaseBlobAuditingPolicy.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ExtendedDatabaseBlobAuditingPolicy.ResourceType, out string extendedDatabaseBlobAuditingPolicyApiVersion);
            _extendedDatabaseBlobAuditingPolicyRestClient = new ExtendedDatabaseBlobAuditingPoliciesRestOperations(_extendedDatabaseBlobAuditingPolicyClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, extendedDatabaseBlobAuditingPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabase.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_CreateOrUpdate
        /// <summary> Creates or updates an extended database&apos;s blob auditing policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> The extended database blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, BlobAuditingPolicyName blobAuditingPolicyName, ExtendedDatabaseBlobAuditingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _extendedDatabaseBlobAuditingPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobAuditingPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_CreateOrUpdate
        /// <summary> Creates or updates an extended database&apos;s blob auditing policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="parameters"> The extended database blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, BlobAuditingPolicyName blobAuditingPolicyName, ExtendedDatabaseBlobAuditingPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _extendedDatabaseBlobAuditingPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobAuditingPolicyName, parameters, cancellationToken);
                var operation = new ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_Get
        /// <summary> Gets an extended database&apos;s blob auditing policy. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExtendedDatabaseBlobAuditingPolicy>> GetAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _extendedDatabaseBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobAuditingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExtendedDatabaseBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_Get
        /// <summary> Gets an extended database&apos;s blob auditing policy. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExtendedDatabaseBlobAuditingPolicy> Get(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _extendedDatabaseBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobAuditingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExtendedDatabaseBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_ListByDatabase
        /// <summary> Lists extended auditing settings of a database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExtendedDatabaseBlobAuditingPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExtendedDatabaseBlobAuditingPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExtendedDatabaseBlobAuditingPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _extendedDatabaseBlobAuditingPolicyRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedDatabaseBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExtendedDatabaseBlobAuditingPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _extendedDatabaseBlobAuditingPolicyRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedDatabaseBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_ListByDatabase
        /// <summary> Lists extended auditing settings of a database. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExtendedDatabaseBlobAuditingPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExtendedDatabaseBlobAuditingPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExtendedDatabaseBlobAuditingPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _extendedDatabaseBlobAuditingPolicyRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedDatabaseBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExtendedDatabaseBlobAuditingPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _extendedDatabaseBlobAuditingPolicyRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExtendedDatabaseBlobAuditingPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(blobAuditingPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExtendedDatabaseBlobAuditingPolicy>> GetIfExistsAsync(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _extendedDatabaseBlobAuditingPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ExtendedDatabaseBlobAuditingPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ExtendedDatabaseBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/extendedAuditingSettings/{blobAuditingPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: ExtendedDatabaseBlobAuditingPolicies_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExtendedDatabaseBlobAuditingPolicy> GetIfExists(BlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _extendedDatabaseBlobAuditingPolicyClientDiagnostics.CreateScope("ExtendedDatabaseBlobAuditingPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _extendedDatabaseBlobAuditingPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ExtendedDatabaseBlobAuditingPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ExtendedDatabaseBlobAuditingPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExtendedDatabaseBlobAuditingPolicy> IEnumerable<ExtendedDatabaseBlobAuditingPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExtendedDatabaseBlobAuditingPolicy> IAsyncEnumerable<ExtendedDatabaseBlobAuditingPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}