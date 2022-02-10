// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    internal partial class ActionGroupsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ActionGroupsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public ActionGroupsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string actionGroupName, ActionGroupResource actionGroup)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/actionGroups/", false);
            uri.AppendPath(actionGroupName, true);
            uri.AppendQuery("api-version", "2019-06-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(actionGroup);
            request.Content = content;
            return message;
        }

        /// <summary> Create a new action group or update an existing one. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="actionGroup"> The action group to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="actionGroupName"/>, or <paramref name="actionGroup"/> is null. </exception>
        public async Task<Response<ActionGroupResource>> CreateOrUpdateAsync(string resourceGroupName, string actionGroupName, ActionGroupResource actionGroup, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }
            if (actionGroup == null)
            {
                throw new ArgumentNullException(nameof(actionGroup));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, actionGroupName, actionGroup);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ActionGroupResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActionGroupResource.DeserializeActionGroupResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create a new action group or update an existing one. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="actionGroup"> The action group to create or use for the update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="actionGroupName"/>, or <paramref name="actionGroup"/> is null. </exception>
        public Response<ActionGroupResource> CreateOrUpdate(string resourceGroupName, string actionGroupName, ActionGroupResource actionGroup, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }
            if (actionGroup == null)
            {
                throw new ArgumentNullException(nameof(actionGroup));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, actionGroupName, actionGroup);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ActionGroupResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActionGroupResource.DeserializeActionGroupResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string actionGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/actionGroups/", false);
            uri.AppendPath(actionGroupName, true);
            uri.AppendQuery("api-version", "2019-06-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get an action group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="actionGroupName"/> is null. </exception>
        public async Task<Response<ActionGroupResource>> GetAsync(string resourceGroupName, string actionGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }

            using var message = CreateGetRequest(resourceGroupName, actionGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActionGroupResource.DeserializeActionGroupResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get an action group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="actionGroupName"/> is null. </exception>
        public Response<ActionGroupResource> Get(string resourceGroupName, string actionGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }

            using var message = CreateGetRequest(resourceGroupName, actionGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActionGroupResource.DeserializeActionGroupResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string actionGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/actionGroups/", false);
            uri.AppendPath(actionGroupName, true);
            uri.AppendQuery("api-version", "2019-06-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete an action group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="actionGroupName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string actionGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, actionGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete an action group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="actionGroupName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string actionGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, actionGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string actionGroupName, ActionGroupPatchBody actionGroupPatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/actionGroups/", false);
            uri.AppendPath(actionGroupName, true);
            uri.AppendQuery("api-version", "2019-06-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(actionGroupPatch);
            request.Content = content;
            return message;
        }

        /// <summary> Updates an existing action group&apos;s tags. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="actionGroupPatch"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="actionGroupName"/>, or <paramref name="actionGroupPatch"/> is null. </exception>
        public async Task<Response<ActionGroupResource>> UpdateAsync(string resourceGroupName, string actionGroupName, ActionGroupPatchBody actionGroupPatch, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }
            if (actionGroupPatch == null)
            {
                throw new ArgumentNullException(nameof(actionGroupPatch));
            }

            using var message = CreateUpdateRequest(resourceGroupName, actionGroupName, actionGroupPatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupResource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActionGroupResource.DeserializeActionGroupResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates an existing action group&apos;s tags. To update other fields use the CreateOrUpdate method. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="actionGroupPatch"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="actionGroupName"/>, or <paramref name="actionGroupPatch"/> is null. </exception>
        public Response<ActionGroupResource> Update(string resourceGroupName, string actionGroupName, ActionGroupPatchBody actionGroupPatch, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }
            if (actionGroupPatch == null)
            {
                throw new ArgumentNullException(nameof(actionGroupPatch));
            }

            using var message = CreateUpdateRequest(resourceGroupName, actionGroupName, actionGroupPatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupResource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActionGroupResource.DeserializeActionGroupResource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionIdRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/microsoft.insights/actionGroups", false);
            uri.AppendQuery("api-version", "2019-06-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a list of all action groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ActionGroupList>> ListBySubscriptionIdAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListBySubscriptionIdRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActionGroupList.DeserializeActionGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a list of all action groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ActionGroupList> ListBySubscriptionId(CancellationToken cancellationToken = default)
        {
            using var message = CreateListBySubscriptionIdRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActionGroupList.DeserializeActionGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/actionGroups", false);
            uri.AppendQuery("api-version", "2019-06-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get a list of all action groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<ActionGroupList>> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ActionGroupList.DeserializeActionGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a list of all action groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<ActionGroupList> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ActionGroupList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ActionGroupList.DeserializeActionGroupList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateEnableReceiverRequest(string resourceGroupName, string actionGroupName, EnableRequest enableRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/microsoft.insights/actionGroups/", false);
            uri.AppendPath(actionGroupName, true);
            uri.AppendPath("/subscribe", false);
            uri.AppendQuery("api-version", "2019-06-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(enableRequest);
            request.Content = content;
            return message;
        }

        /// <summary> Enable a receiver in an action group. This changes the receiver&apos;s status from Disabled to Enabled. This operation is only supported for Email or SMS receivers. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="enableRequest"> The receiver to re-enable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="actionGroupName"/>, or <paramref name="enableRequest"/> is null. </exception>
        public async Task<Response> EnableReceiverAsync(string resourceGroupName, string actionGroupName, EnableRequest enableRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }
            if (enableRequest == null)
            {
                throw new ArgumentNullException(nameof(enableRequest));
            }

            using var message = CreateEnableReceiverRequest(resourceGroupName, actionGroupName, enableRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 409:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Enable a receiver in an action group. This changes the receiver&apos;s status from Disabled to Enabled. This operation is only supported for Email or SMS receivers. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="actionGroupName"> The name of the action group. </param>
        /// <param name="enableRequest"> The receiver to re-enable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="actionGroupName"/>, or <paramref name="enableRequest"/> is null. </exception>
        public Response EnableReceiver(string resourceGroupName, string actionGroupName, EnableRequest enableRequest, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (actionGroupName == null)
            {
                throw new ArgumentNullException(nameof(actionGroupName));
            }
            if (enableRequest == null)
            {
                throw new ArgumentNullException(nameof(enableRequest));
            }

            using var message = CreateEnableReceiverRequest(resourceGroupName, actionGroupName, enableRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 409:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}