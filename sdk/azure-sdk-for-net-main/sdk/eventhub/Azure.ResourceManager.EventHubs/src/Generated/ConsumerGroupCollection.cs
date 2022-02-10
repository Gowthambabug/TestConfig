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
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of ConsumerGroup and their operations over its parent. </summary>
    public partial class ConsumerGroupCollection : ArmCollection, IEnumerable<ConsumerGroup>, IAsyncEnumerable<ConsumerGroup>
    {
        private readonly ClientDiagnostics _consumerGroupClientDiagnostics;
        private readonly ConsumerGroupsRestOperations _consumerGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConsumerGroupCollection"/> class for mocking. </summary>
        protected ConsumerGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConsumerGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConsumerGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _consumerGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", ConsumerGroup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ConsumerGroup.ResourceType, out string consumerGroupApiVersion);
            _consumerGroupRestClient = new ConsumerGroupsRestOperations(_consumerGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, consumerGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHub.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates an Event Hubs consumer group as a nested resource within a Namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a consumer group resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ConsumerGroupCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string consumerGroupName, ConsumerGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _consumerGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ConsumerGroupCreateOrUpdateOperation(Client, response);
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

        /// <summary> Creates or updates an Event Hubs consumer group as a nested resource within a Namespace. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a consumer group resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ConsumerGroupCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string consumerGroupName, ConsumerGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _consumerGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, parameters, cancellationToken);
                var operation = new ConsumerGroupCreateOrUpdateOperation(Client, response);
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

        /// <summary> Gets a description for the specified consumer group. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public async virtual Task<Response<ConsumerGroup>> GetAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _consumerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _consumerGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ConsumerGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a description for the specified consumer group. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual Response<ConsumerGroup> Get(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _consumerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken);
                if (response.Value == null)
                    throw _consumerGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConsumerGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the consumer groups in a Namespace. An empty feed is returned if no consumer group exists in the Namespace. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConsumerGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConsumerGroup> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ConsumerGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _consumerGroupRestClient.ListByEventHubAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConsumerGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _consumerGroupRestClient.ListByEventHubNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the consumer groups in a Namespace. An empty feed is returned if no consumer group exists in the Namespace. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConsumerGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConsumerGroup> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ConsumerGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _consumerGroupRestClient.ListByEventHub(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConsumerGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _consumerGroupRestClient.ListByEventHubNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConsumerGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(consumerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(consumerGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public async virtual Task<Response<ConsumerGroup>> GetIfExistsAsync(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _consumerGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ConsumerGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ConsumerGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="consumerGroupName"> The consumer group name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="consumerGroupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="consumerGroupName"/> is null. </exception>
        public virtual Response<ConsumerGroup> GetIfExists(string consumerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(consumerGroupName, nameof(consumerGroupName));

            using var scope = _consumerGroupClientDiagnostics.CreateScope("ConsumerGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _consumerGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, consumerGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ConsumerGroup>(null, response.GetRawResponse());
                return Response.FromValue(new ConsumerGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConsumerGroup> IEnumerable<ConsumerGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConsumerGroup> IAsyncEnumerable<ConsumerGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}