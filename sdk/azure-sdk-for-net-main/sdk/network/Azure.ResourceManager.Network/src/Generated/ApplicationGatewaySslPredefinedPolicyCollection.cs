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

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ApplicationGatewaySslPredefinedPolicy and their operations over its parent. </summary>
    public partial class ApplicationGatewaySslPredefinedPolicyCollection : ArmCollection, IEnumerable<ApplicationGatewaySslPredefinedPolicy>, IAsyncEnumerable<ApplicationGatewaySslPredefinedPolicy>
    {
        private readonly ClientDiagnostics _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics;
        private readonly ApplicationGatewaysRestOperations _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewaySslPredefinedPolicyCollection"/> class for mocking. </summary>
        protected ApplicationGatewaySslPredefinedPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApplicationGatewaySslPredefinedPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApplicationGatewaySslPredefinedPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ApplicationGatewaySslPredefinedPolicy.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ApplicationGatewaySslPredefinedPolicy.ResourceType, out string applicationGatewaySslPredefinedPolicyApplicationGatewaysApiVersion);
            _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient = new ApplicationGatewaysRestOperations(_applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, applicationGatewaySslPredefinedPolicyApplicationGatewaysApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApplicationGatewayAvailableSslOptions.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApplicationGatewayAvailableSslOptions.ResourceType), nameof(id));
        }

        /// <summary> Gets Ssl predefined policy with the specified policy name. </summary>
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predefinedPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public async virtual Task<Response<ApplicationGatewaySslPredefinedPolicy>> GetAsync(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predefinedPolicyName, nameof(predefinedPolicyName));

            using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.GetSslPredefinedPolicyAsync(Id.SubscriptionId, predefinedPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ApplicationGatewaySslPredefinedPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets Ssl predefined policy with the specified policy name. </summary>
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predefinedPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public virtual Response<ApplicationGatewaySslPredefinedPolicy> Get(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predefinedPolicyName, nameof(predefinedPolicyName));

            using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.GetSslPredefinedPolicy(Id.SubscriptionId, predefinedPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewaySslPredefinedPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all SSL predefined policies for configuring Ssl policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationGatewaySslPredefinedPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationGatewaySslPredefinedPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationGatewaySslPredefinedPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.ListAvailableSslPredefinedPoliciesAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewaySslPredefinedPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationGatewaySslPredefinedPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.ListAvailableSslPredefinedPoliciesNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewaySslPredefinedPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all SSL predefined policies for configuring Ssl policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationGatewaySslPredefinedPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationGatewaySslPredefinedPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationGatewaySslPredefinedPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.ListAvailableSslPredefinedPolicies(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewaySslPredefinedPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationGatewaySslPredefinedPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.ListAvailableSslPredefinedPoliciesNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationGatewaySslPredefinedPolicy(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predefinedPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predefinedPolicyName, nameof(predefinedPolicyName));

            using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(predefinedPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predefinedPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predefinedPolicyName, nameof(predefinedPolicyName));

            using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(predefinedPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predefinedPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public async virtual Task<Response<ApplicationGatewaySslPredefinedPolicy>> GetIfExistsAsync(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predefinedPolicyName, nameof(predefinedPolicyName));

            using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.GetSslPredefinedPolicyAsync(Id.SubscriptionId, predefinedPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ApplicationGatewaySslPredefinedPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewaySslPredefinedPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="predefinedPolicyName"> Name of Ssl predefined policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="predefinedPolicyName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="predefinedPolicyName"/> is null. </exception>
        public virtual Response<ApplicationGatewaySslPredefinedPolicy> GetIfExists(string predefinedPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(predefinedPolicyName, nameof(predefinedPolicyName));

            using var scope = _applicationGatewaySslPredefinedPolicyApplicationGatewaysClientDiagnostics.CreateScope("ApplicationGatewaySslPredefinedPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _applicationGatewaySslPredefinedPolicyApplicationGatewaysRestClient.GetSslPredefinedPolicy(Id.SubscriptionId, predefinedPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ApplicationGatewaySslPredefinedPolicy>(null, response.GetRawResponse());
                return Response.FromValue(new ApplicationGatewaySslPredefinedPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApplicationGatewaySslPredefinedPolicy> IEnumerable<ApplicationGatewaySslPredefinedPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApplicationGatewaySslPredefinedPolicy> IAsyncEnumerable<ApplicationGatewaySslPredefinedPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}