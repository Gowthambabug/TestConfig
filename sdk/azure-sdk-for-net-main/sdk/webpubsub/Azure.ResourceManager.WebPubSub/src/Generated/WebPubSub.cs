// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A Class representing a WebPubSub along with the instance operations that can be performed on it. </summary>
    public partial class WebPubSub : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebPubSub"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webPubSubClientDiagnostics;
        private readonly WebPubSubRestOperations _webPubSubRestClient;
        private readonly ClientDiagnostics _webPubSubPrivateLinkResourcesClientDiagnostics;
        private readonly WebPubSubPrivateLinkResourcesRestOperations _webPubSubPrivateLinkResourcesRestClient;
        private readonly WebPubSubData _data;

        /// <summary> Initializes a new instance of the <see cref="WebPubSub"/> class for mocking. </summary>
        protected WebPubSub()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebPubSub"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebPubSub(ArmClient client, WebPubSubData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WebPubSub"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebPubSub(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webPubSubClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WebPubSub", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string webPubSubApiVersion);
            _webPubSubRestClient = new WebPubSubRestOperations(_webPubSubClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, webPubSubApiVersion);
            _webPubSubPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WebPubSub", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _webPubSubPrivateLinkResourcesRestClient = new WebPubSubPrivateLinkResourcesRestOperations(_webPubSubPrivateLinkResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SignalRService/webPubSub";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WebPubSubData Data
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

        /// <summary> Gets a collection of WebPubSubHubs in the WebPubSubHub. </summary>
        /// <returns> An object representing collection of WebPubSubHubs and their operations over a WebPubSubHub. </returns>
        public virtual WebPubSubHubCollection GetWebPubSubHubs()
        {
            return new WebPubSubHubCollection(Client, Id);
        }

        /// <summary> Gets a collection of PrivateEndpointConnections in the PrivateEndpointConnection. </summary>
        /// <returns> An object representing collection of PrivateEndpointConnections and their operations over a PrivateEndpointConnection. </returns>
        public virtual PrivateEndpointConnectionCollection GetPrivateEndpointConnections()
        {
            return new PrivateEndpointConnectionCollection(Client, Id);
        }

        /// <summary> Gets a collection of SharedPrivateLinks in the SharedPrivateLink. </summary>
        /// <returns> An object representing collection of SharedPrivateLinks and their operations over a SharedPrivateLink. </returns>
        public virtual SharedPrivateLinkCollection GetSharedPrivateLinks()
        {
            return new SharedPrivateLinkCollection(Client, Id);
        }

        /// <summary> Get the resource and its properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<WebPubSub>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Get");
            scope.Start();
            try
            {
                var response = await _webPubSubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _webPubSubClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WebPubSub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the resource and its properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebPubSub> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Get");
            scope.Start();
            try
            {
                var response = _webPubSubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _webPubSubClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebPubSub(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to delete a resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<WebPubSubDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Delete");
            scope.Start();
            try
            {
                var response = await _webPubSubRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubDeleteOperation(_webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to delete a resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual WebPubSubDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Delete");
            scope.Start();
            try
            {
                var response = _webPubSubRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new WebPubSubDeleteOperation(_webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to update an exiting resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WebPubSubUpdateOperation> UpdateAsync(bool waitForCompletion, WebPubSubData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Update");
            scope.Start();
            try
            {
                var response = await _webPubSubRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubUpdateOperation(Client, _webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// <summary> Operation to update an exiting resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for the update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual WebPubSubUpdateOperation Update(bool waitForCompletion, WebPubSubData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Update");
            scope.Start();
            try
            {
                var response = _webPubSubRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                var operation = new WebPubSubUpdateOperation(Client, _webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// <summary> Get the access keys of the resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<WebPubSubKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.GetKeys");
            scope.Start();
            try
            {
                var response = await _webPubSubRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the access keys of the resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebPubSubKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.GetKeys");
            scope.Start();
            try
            {
                var response = _webPubSubRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Regenerate the access key for the resource. PrimaryKey and SecondaryKey cannot be regenerated at the same time. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameter that describes the Regenerate Key Operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WebPubSubRegenerateKeyOperation> RegenerateKeyAsync(bool waitForCompletion, RegenerateKeyParameters parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.RegenerateKey");
            scope.Start();
            try
            {
                var response = await _webPubSubRestClient.RegenerateKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubRegenerateKeyOperation(_webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateRegenerateKeyRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// <summary> Regenerate the access key for the resource. PrimaryKey and SecondaryKey cannot be regenerated at the same time. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameter that describes the Regenerate Key Operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual WebPubSubRegenerateKeyOperation RegenerateKey(bool waitForCompletion, RegenerateKeyParameters parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.RegenerateKey");
            scope.Start();
            try
            {
                var response = _webPubSubRestClient.RegenerateKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                var operation = new WebPubSubRegenerateKeyOperation(_webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateRegenerateKeyRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters).Request, response);
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

        /// <summary> Operation to restart a resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<WebPubSubRestartOperation> RestartAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Restart");
            scope.Start();
            try
            {
                var response = await _webPubSubRestClient.RestartAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new WebPubSubRestartOperation(_webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateRestartRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation to restart a resource. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual WebPubSubRestartOperation Restart(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.Restart");
            scope.Start();
            try
            {
                var response = _webPubSubRestClient.Restart(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new WebPubSubRestartOperation(_webPubSubClientDiagnostics, Pipeline, _webPubSubRestClient.CreateRestartRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all available skus of the resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Sku" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Sku> GetSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Sku>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.GetSkus");
                scope.Start();
                try
                {
                    var response = await _webPubSubRestClient.ListSkusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
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

        /// <summary> List all available skus of the resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Sku" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Sku> GetSkus(CancellationToken cancellationToken = default)
        {
            Page<Sku> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.GetSkus");
                scope.Start();
                try
                {
                    var response = _webPubSubRestClient.ListSkus(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
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

        /// <summary> Get the private link resources that need to be created for a resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateLink> GetWebPubSubPrivateLinkResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webPubSubPrivateLinkResourcesClientDiagnostics.CreateScope("WebPubSub.GetWebPubSubPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _webPubSubPrivateLinkResourcesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webPubSubPrivateLinkResourcesClientDiagnostics.CreateScope("WebPubSub.GetWebPubSubPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _webPubSubPrivateLinkResourcesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get the private link resources that need to be created for a resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateLink> GetWebPubSubPrivateLinkResources(CancellationToken cancellationToken = default)
        {
            Page<PrivateLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _webPubSubPrivateLinkResourcesClientDiagnostics.CreateScope("WebPubSub.GetWebPubSubPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _webPubSubPrivateLinkResourcesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _webPubSubPrivateLinkResourcesClientDiagnostics.CreateScope("WebPubSub.GetWebPubSubPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _webPubSubPrivateLinkResourcesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<WebPubSub>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _webPubSubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WebPubSub(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<WebPubSub> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _webPubSubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new WebPubSub(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<WebPubSub>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _webPubSubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WebPubSub(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<WebPubSub> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _webPubSubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new WebPubSub(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<WebPubSub>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _webPubSubRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WebPubSub(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<WebPubSub> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _webPubSubClientDiagnostics.CreateScope("WebPubSub.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _webPubSubRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new WebPubSub(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}