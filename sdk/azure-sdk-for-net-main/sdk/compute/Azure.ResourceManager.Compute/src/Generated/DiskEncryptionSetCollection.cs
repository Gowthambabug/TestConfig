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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of DiskEncryptionSet and their operations over its parent. </summary>
    public partial class DiskEncryptionSetCollection : ArmCollection, IEnumerable<DiskEncryptionSet>, IAsyncEnumerable<DiskEncryptionSet>
    {
        private readonly ClientDiagnostics _diskEncryptionSetClientDiagnostics;
        private readonly DiskEncryptionSetsRestOperations _diskEncryptionSetRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskEncryptionSetCollection"/> class for mocking. </summary>
        protected DiskEncryptionSetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskEncryptionSetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskEncryptionSetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskEncryptionSetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", DiskEncryptionSet.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(DiskEncryptionSet.ResourceType, out string diskEncryptionSetApiVersion);
            _diskEncryptionSetRestClient = new DiskEncryptionSetsRestOperations(_diskEncryptionSetClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, diskEncryptionSetApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="diskEncryptionSet"/> is null. </exception>
        public async virtual Task<DiskEncryptionSetCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string diskEncryptionSetName, DiskEncryptionSetData diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken).ConfigureAwait(false);
                var operation = new DiskEncryptionSetCreateOrUpdateOperation(Client, _diskEncryptionSetClientDiagnostics, Pipeline, _diskEncryptionSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, response);
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

        /// <summary> Creates or updates a disk encryption set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="diskEncryptionSet"> disk encryption set object supplied in the body of the Put disk encryption set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> or <paramref name="diskEncryptionSet"/> is null. </exception>
        public virtual DiskEncryptionSetCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string diskEncryptionSetName, DiskEncryptionSetData diskEncryptionSet, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));
            if (diskEncryptionSet == null)
            {
                throw new ArgumentNullException(nameof(diskEncryptionSet));
            }

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet, cancellationToken);
                var operation = new DiskEncryptionSetCreateOrUpdateOperation(Client, _diskEncryptionSetClientDiagnostics, Pipeline, _diskEncryptionSetRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, diskEncryptionSet).Request, response);
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

        /// <summary> Gets information about a disk encryption set. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public async virtual Task<Response<DiskEncryptionSet>> GetAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _diskEncryptionSetClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiskEncryptionSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about a disk encryption set. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual Response<DiskEncryptionSet> Get(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Get");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken);
                if (response.Value == null)
                    throw _diskEncryptionSetClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the disk encryption sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskEncryptionSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskEncryptionSet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskEncryptionSet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskEncryptionSetRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DiskEncryptionSet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskEncryptionSetRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the disk encryption sets under a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskEncryptionSet" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskEncryptionSet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiskEncryptionSet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskEncryptionSetRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DiskEncryptionSet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskEncryptionSetRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskEncryptionSet(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(diskEncryptionSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public async virtual Task<Response<DiskEncryptionSet>> GetIfExistsAsync(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskEncryptionSetRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DiskEncryptionSet>(null, response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diskEncryptionSetName"> The name of the disk encryption set that is being created. The name can&apos;t be changed after the disk encryption set is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskEncryptionSetName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskEncryptionSetName"/> is null. </exception>
        public virtual Response<DiskEncryptionSet> GetIfExists(string diskEncryptionSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskEncryptionSetName, nameof(diskEncryptionSetName));

            using var scope = _diskEncryptionSetClientDiagnostics.CreateScope("DiskEncryptionSetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskEncryptionSetRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskEncryptionSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DiskEncryptionSet>(null, response.GetRawResponse());
                return Response.FromValue(new DiskEncryptionSet(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskEncryptionSet> IEnumerable<DiskEncryptionSet>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskEncryptionSet> IAsyncEnumerable<DiskEncryptionSet>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}