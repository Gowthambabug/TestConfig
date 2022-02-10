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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdOriginGroup and their operations over its parent. </summary>
    public partial class AfdOriginGroupCollection : ArmCollection, IEnumerable<AfdOriginGroup>, IAsyncEnumerable<AfdOriginGroup>
    {
        private readonly ClientDiagnostics _afdOriginGroupClientDiagnostics;
        private readonly AfdOriginGroupsRestOperations _afdOriginGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdOriginGroupCollection"/> class for mocking. </summary>
        protected AfdOriginGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdOriginGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AfdOriginGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdOriginGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", AfdOriginGroup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(AfdOriginGroup.ResourceType, out string afdOriginGroupApiVersion);
            _afdOriginGroupRestClient = new AfdOriginGroupsRestOperations(_afdOriginGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdOriginGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Profile.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Profile.ResourceType), nameof(id));
        }

        /// <summary> Creates a new origin group within the specified profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroup"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="originGroup"/> is null. </exception>
        public async virtual Task<AfdOriginGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string originGroupName, AfdOriginGroupData originGroup, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdOriginGroupRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, originGroup, cancellationToken).ConfigureAwait(false);
                var operation = new AfdOriginGroupCreateOrUpdateOperation(Client, _afdOriginGroupClientDiagnostics, Pipeline, _afdOriginGroupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, originGroup).Request, response);
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

        /// <summary> Creates a new origin group within the specified profile. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="originGroup"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> or <paramref name="originGroup"/> is null. </exception>
        public virtual AfdOriginGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string originGroupName, AfdOriginGroupData originGroup, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));
            if (originGroup == null)
            {
                throw new ArgumentNullException(nameof(originGroup));
            }

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdOriginGroupRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, originGroup, cancellationToken);
                var operation = new AfdOriginGroupCreateOrUpdateOperation(Client, _afdOriginGroupClientDiagnostics, Pipeline, _afdOriginGroupRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, originGroup).Request, response);
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

        /// <summary> Gets an existing origin group within a profile. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public async virtual Task<Response<AfdOriginGroup>> GetAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _afdOriginGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdOriginGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing origin group within a profile. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<AfdOriginGroup> Get(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _afdOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken);
                if (response.Value == null)
                    throw _afdOriginGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdOriginGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing origin groups within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdOriginGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdOriginGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdOriginGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdOriginGroupRestClient.ListByProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdOriginGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdOriginGroupRestClient.ListByProfileNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing origin groups within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdOriginGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdOriginGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdOriginGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdOriginGroupRestClient.ListByProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdOriginGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdOriginGroupRestClient.ListByProfileNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(originGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(originGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public async virtual Task<Response<AfdOriginGroup>> GetIfExistsAsync(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdOriginGroup>(null, response.GetRawResponse());
                return Response.FromValue(new AfdOriginGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="originGroupName"> Name of the origin group which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originGroupName"/> is null. </exception>
        public virtual Response<AfdOriginGroup> GetIfExists(string originGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originGroupName, nameof(originGroupName));

            using var scope = _afdOriginGroupClientDiagnostics.CreateScope("AfdOriginGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, originGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdOriginGroup>(null, response.GetRawResponse());
                return Response.FromValue(new AfdOriginGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AfdOriginGroup> IEnumerable<AfdOriginGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdOriginGroup> IAsyncEnumerable<AfdOriginGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}