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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualWAN and their operations over its parent. </summary>
    public partial class VirtualWANCollection : ArmCollection, IEnumerable<VirtualWAN>, IAsyncEnumerable<VirtualWAN>
    {
        private readonly ClientDiagnostics _virtualWANVirtualWansClientDiagnostics;
        private readonly VirtualWansRestOperations _virtualWANVirtualWansRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualWANCollection"/> class for mocking. </summary>
        protected VirtualWANCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualWANCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualWANCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualWANVirtualWansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualWAN.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(VirtualWAN.ResourceType, out string virtualWANVirtualWansApiVersion);
            _virtualWANVirtualWansRestClient = new VirtualWansRestOperations(_virtualWANVirtualWansClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualWANVirtualWansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public async virtual Task<VirtualWANCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualWANName, VirtualWANData wANParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualWANVirtualWansRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, wANParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualWANCreateOrUpdateOperation(Client, _virtualWANVirtualWansClientDiagnostics, Pipeline, _virtualWANVirtualWansRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, wANParameters).Request, response);
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

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public virtual VirtualWANCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualWANName, VirtualWANData wANParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualWANVirtualWansRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, wANParameters, cancellationToken);
                var operation = new VirtualWANCreateOrUpdateOperation(Client, _virtualWANVirtualWansClientDiagnostics, Pipeline, _virtualWANVirtualWansRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, wANParameters).Request, response);
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

        /// <summary> Retrieves the details of a VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> is null. </exception>
        public async virtual Task<Response<VirtualWAN>> GetAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualWANVirtualWansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualWANVirtualWansClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualWAN(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> is null. </exception>
        public virtual Response<VirtualWAN> Get(string virtualWANName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualWANVirtualWansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, cancellationToken);
                if (response.Value == null)
                    throw _virtualWANVirtualWansClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualWAN(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualWAN" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualWAN> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualWAN>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualWANVirtualWansRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualWAN>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualWANVirtualWansRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualWAN" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualWAN> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualWAN> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualWANVirtualWansRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualWAN> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualWANVirtualWansRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualWANName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualWANName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> is null. </exception>
        public async virtual Task<Response<VirtualWAN>> GetIfExistsAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualWANVirtualWansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualWAN>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualWAN(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWANName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> is null. </exception>
        public virtual Response<VirtualWAN> GetIfExists(string virtualWANName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWANName, nameof(virtualWANName));

            using var scope = _virtualWANVirtualWansClientDiagnostics.CreateScope("VirtualWANCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualWANVirtualWansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualWAN>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualWAN(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualWAN> IEnumerable<VirtualWAN>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualWAN> IAsyncEnumerable<VirtualWAN>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}