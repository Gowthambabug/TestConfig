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
using Azure.ResourceManager.ExtendedLocation.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ExtendedLocation
{
    /// <summary> A class representing collection of CustomLocation and their operations over its parent. </summary>
    public partial class CustomLocationCollection : ArmCollection, IEnumerable<CustomLocation>, IAsyncEnumerable<CustomLocation>
    {
        private readonly ClientDiagnostics _customLocationClientDiagnostics;
        private readonly CustomLocationsRestOperations _customLocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomLocationCollection"/> class for mocking. </summary>
        protected CustomLocationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomLocationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CustomLocationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customLocationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ExtendedLocation", CustomLocation.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(CustomLocation.ResourceType, out string customLocationApiVersion);
            _customLocationRestClient = new CustomLocationsRestOperations(_customLocationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, customLocationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_CreateOrUpdate
        /// <summary> Creates or updates a Custom Location in the specified Subscription and Resource Group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a Custom Location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<CustomLocationCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string resourceName, CustomLocationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customLocationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new CustomLocationCreateOrUpdateOperation(Client, _customLocationClientDiagnostics, Pipeline, _customLocationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_CreateOrUpdate
        /// <summary> Creates or updates a Custom Location in the specified Subscription and Resource Group. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="parameters"> Parameters supplied to create or update a Custom Location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual CustomLocationCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string resourceName, CustomLocationData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customLocationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters, cancellationToken);
                var operation = new CustomLocationCreateOrUpdateOperation(Client, _customLocationClientDiagnostics, Pipeline, _customLocationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_Get
        /// <summary> Gets the details of the customLocation with a specified resource group and name. </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public async virtual Task<Response<CustomLocation>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.Get");
            scope.Start();
            try
            {
                var response = await _customLocationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _customLocationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CustomLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_Get
        /// <summary> Gets the details of the customLocation with a specified resource group and name. </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<CustomLocation> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.Get");
            scope.Start();
            try
            {
                var response = _customLocationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw _customLocationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_ListByResourceGroup
        /// <summary> Gets a list of Custom Locations in the specified subscription and resource group. The operation returns properties of each Custom Location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomLocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomLocation> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CustomLocation>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _customLocationRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CustomLocation>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _customLocationRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_ListByResourceGroup
        /// <summary> Gets a list of Custom Locations in the specified subscription and resource group. The operation returns properties of each Custom Location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomLocation" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomLocation> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CustomLocation> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _customLocationRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CustomLocation> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _customLocationRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomLocation(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public async virtual Task<Response<CustomLocation>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _customLocationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CustomLocation>(null, response.GetRawResponse());
                return Response.FromValue(new CustomLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ExtendedLocation/customLocations/{resourceName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomLocations_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceName"> Custom Locations name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<CustomLocation> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _customLocationClientDiagnostics.CreateScope("CustomLocationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _customLocationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CustomLocation>(null, response.GetRawResponse());
                return Response.FromValue(new CustomLocation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CustomLocation> IEnumerable<CustomLocation>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomLocation> IAsyncEnumerable<CustomLocation>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}