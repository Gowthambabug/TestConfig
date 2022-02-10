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
    /// <summary> A class representing collection of VirtualNetwork and their operations over its parent. </summary>
    public partial class VirtualNetworkCollection : ArmCollection, IEnumerable<VirtualNetwork>, IAsyncEnumerable<VirtualNetwork>
    {
        private readonly ClientDiagnostics _virtualNetworkClientDiagnostics;
        private readonly VirtualNetworksRestOperations _virtualNetworkRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkCollection"/> class for mocking. </summary>
        protected VirtualNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetwork.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(VirtualNetwork.ResourceType, out string virtualNetworkApiVersion);
            _virtualNetworkRestClient = new VirtualNetworksRestOperations(_virtualNetworkClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualNetworkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a virtual network in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string virtualNetworkName, VirtualNetworkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkCreateOrUpdateOperation(Client, _virtualNetworkClientDiagnostics, Pipeline, _virtualNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters).Request, response);
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

        /// <summary> Creates or updates a virtual network in the specified resource group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string virtualNetworkName, VirtualNetworkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters, cancellationToken);
                var operation = new VirtualNetworkCreateOrUpdateOperation(Client, _virtualNetworkClientDiagnostics, Pipeline, _virtualNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters).Request, response);
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

        /// <summary> Gets the specified virtual network by resource group. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetwork>> GetAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _virtualNetworkClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetwork(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified virtual network by resource group. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<VirtualNetwork> Get(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken);
                if (response.Value == null)
                    throw _virtualNetworkClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetwork(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all virtual networks in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetwork" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetwork> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetwork>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetwork>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all virtual networks in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetwork" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetwork> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetwork> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetwork> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkName, expand: expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetwork>> GetIfExistsAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetwork>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetwork(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<VirtualNetwork> GetIfExists(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkName, nameof(virtualNetworkName));

            using var scope = _virtualNetworkClientDiagnostics.CreateScope("VirtualNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetwork>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetwork(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetwork> IEnumerable<VirtualNetwork>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetwork> IAsyncEnumerable<VirtualNetwork>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}