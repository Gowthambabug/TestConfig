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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a RestorableDatabaseAccount along with the instance operations that can be performed on it. </summary>
    public partial class RestorableDatabaseAccount : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RestorableDatabaseAccount"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _restorableDatabaseAccountClientDiagnostics;
        private readonly RestorableDatabaseAccountsRestOperations _restorableDatabaseAccountRestClient;
        private readonly ClientDiagnostics _restorableSqlDatabasesClientDiagnostics;
        private readonly RestorableSqlDatabasesRestOperations _restorableSqlDatabasesRestClient;
        private readonly ClientDiagnostics _restorableSqlContainersClientDiagnostics;
        private readonly RestorableSqlContainersRestOperations _restorableSqlContainersRestClient;
        private readonly ClientDiagnostics _restorableSqlResourcesClientDiagnostics;
        private readonly RestorableSqlResourcesRestOperations _restorableSqlResourcesRestClient;
        private readonly ClientDiagnostics _restorableMongodbDatabasesClientDiagnostics;
        private readonly RestorableMongodbDatabasesRestOperations _restorableMongodbDatabasesRestClient;
        private readonly ClientDiagnostics _restorableMongodbCollectionsClientDiagnostics;
        private readonly RestorableMongodbCollectionsRestOperations _restorableMongodbCollectionsRestClient;
        private readonly ClientDiagnostics _restorableMongodbResourcesClientDiagnostics;
        private readonly RestorableMongodbResourcesRestOperations _restorableMongodbResourcesRestClient;
        private readonly RestorableDatabaseAccountData _data;

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccount"/> class for mocking. </summary>
        protected RestorableDatabaseAccount()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RestorableDatabaseAccount"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RestorableDatabaseAccount(ArmClient client, RestorableDatabaseAccountData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableDatabaseAccount"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RestorableDatabaseAccount(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableDatabaseAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string restorableDatabaseAccountApiVersion);
            _restorableDatabaseAccountRestClient = new RestorableDatabaseAccountsRestOperations(_restorableDatabaseAccountClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, restorableDatabaseAccountApiVersion);
            _restorableSqlDatabasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _restorableSqlDatabasesRestClient = new RestorableSqlDatabasesRestOperations(_restorableSqlDatabasesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
            _restorableSqlContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _restorableSqlContainersRestClient = new RestorableSqlContainersRestOperations(_restorableSqlContainersClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
            _restorableSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _restorableSqlResourcesRestClient = new RestorableSqlResourcesRestOperations(_restorableSqlResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
            _restorableMongodbDatabasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _restorableMongodbDatabasesRestClient = new RestorableMongodbDatabasesRestOperations(_restorableMongodbDatabasesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
            _restorableMongodbCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _restorableMongodbCollectionsRestClient = new RestorableMongodbCollectionsRestOperations(_restorableMongodbCollectionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
            _restorableMongodbResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _restorableMongodbResourcesRestClient = new RestorableMongodbResourcesRestOperations(_restorableMongodbResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/locations/restorableDatabaseAccounts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RestorableDatabaseAccountData Data
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

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<RestorableDatabaseAccount>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccount.Get");
            scope.Start();
            try
            {
                var response = await _restorableDatabaseAccountRestClient.GetByLocationAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _restorableDatabaseAccountClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RestorableDatabaseAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorableDatabaseAccount> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableDatabaseAccountClientDiagnostics.CreateScope("RestorableDatabaseAccount.Get");
            scope.Start();
            try
            {
                var response = _restorableDatabaseAccountRestClient.GetByLocation(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _restorableDatabaseAccountClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableDatabaseAccount(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableSqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableSqlDatabase> GetRestorableSqlDatabasesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableSqlDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlDatabasesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableSqlDatabases");
                scope.Start();
                try
                {
                    var response = await _restorableSqlDatabasesRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableSqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableSqlDatabase> GetRestorableSqlDatabases(CancellationToken cancellationToken = default)
        {
            Page<RestorableSqlDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlDatabasesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableSqlDatabases");
                scope.Start();
                try
                {
                    var response = _restorableSqlDatabasesRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL containers under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restorableSqlDatabaseRid"> The resource ID of the SQL database. </param>
        /// <param name="startTime"> The snapshot create timestamp after which snapshots need to be listed. </param>
        /// <param name="endTime"> The snapshot create timestamp before which snapshots need to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableSqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableSqlContainer> GetRestorableSqlContainersAsync(string restorableSqlDatabaseRid = null, string startTime = null, string endTime = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableSqlContainer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlContainersClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableSqlContainers");
                scope.Start();
                try
                {
                    var response = await _restorableSqlContainersRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, restorableSqlDatabaseRid, startTime, endTime, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL containers under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restorableSqlDatabaseRid"> The resource ID of the SQL database. </param>
        /// <param name="startTime"> The snapshot create timestamp after which snapshots need to be listed. </param>
        /// <param name="endTime"> The snapshot create timestamp before which snapshots need to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableSqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableSqlContainer> GetRestorableSqlContainers(string restorableSqlDatabaseRid = null, string startTime = null, string endTime = null, CancellationToken cancellationToken = default)
        {
            Page<RestorableSqlContainer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlContainersClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableSqlContainers");
                scope.Start();
                try
                {
                    var response = _restorableSqlContainersRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, restorableSqlDatabaseRid, startTime, endTime, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Return a list of database and container combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseRestoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseRestoreResource> GetRestorableSqlResourcesAsync(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DatabaseRestoreResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlResourcesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableSqlResources");
                scope.Start();
                try
                {
                    var response = await _restorableSqlResourcesRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Return a list of database and container combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseRestoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseRestoreResource> GetRestorableSqlResources(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            Page<DatabaseRestoreResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlResourcesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableSqlResources");
                scope.Start();
                try
                {
                    var response = _restorableSqlResourcesRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires  &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableMongodbDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableMongodbDatabase> GetRestorableMongodbDatabasesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableMongodbDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongodbDatabasesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableMongodbDatabases");
                scope.Start();
                try
                {
                    var response = await _restorableMongodbDatabasesRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires  &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableMongodbDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableMongodbDatabase> GetRestorableMongodbDatabases(CancellationToken cancellationToken = default)
        {
            Page<RestorableMongodbDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongodbDatabasesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableMongodbDatabases");
                scope.Start();
                try
                {
                    var response = _restorableMongodbDatabasesRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB collections under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restorableMongodbDatabaseRid"> The resource ID of the MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableMongodbCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableMongodbCollection> GetRestorableMongodbCollectionsAsync(string restorableMongodbDatabaseRid = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableMongodbCollection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongodbCollectionsClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableMongodbCollections");
                scope.Start();
                try
                {
                    var response = await _restorableMongodbCollectionsRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, restorableMongodbDatabaseRid, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB collections under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restorableMongodbDatabaseRid"> The resource ID of the MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableMongodbCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableMongodbCollection> GetRestorableMongodbCollections(string restorableMongodbDatabaseRid = null, CancellationToken cancellationToken = default)
        {
            Page<RestorableMongodbCollection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongodbCollectionsClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableMongodbCollections");
                scope.Start();
                try
                {
                    var response = _restorableMongodbCollectionsRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, restorableMongodbDatabaseRid, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseRestoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseRestoreResource> GetRestorableMongodbResourcesAsync(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DatabaseRestoreResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongodbResourcesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableMongodbResources");
                scope.Start();
                try
                {
                    var response = await _restorableMongodbResourcesRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseRestoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseRestoreResource> GetRestorableMongodbResources(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            Page<DatabaseRestoreResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongodbResourcesClientDiagnostics.CreateScope("RestorableDatabaseAccount.GetRestorableMongodbResources");
                scope.Start();
                try
                {
                    var response = _restorableMongodbResourcesRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}