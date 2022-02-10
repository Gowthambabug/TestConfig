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
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A Class representing a PrivateEndpointConnection along with the instance operations that can be performed on it. </summary>
    public partial class PrivateEndpointConnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PrivateEndpointConnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/webPubSub/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics;
        private readonly WebPubSubPrivateEndpointConnectionsRestOperations _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient;
        private readonly PrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnection"/> class for mocking. </summary>
        protected PrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateEndpointConnection(ArmClient client, PrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateEndpointConnection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.WebPubSub", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string privateEndpointConnectionWebPubSubPrivateEndpointConnectionsApiVersion);
            _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient = new WebPubSubPrivateEndpointConnectionsRestOperations(_privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, privateEndpointConnectionWebPubSubPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SignalRService/webPubSub/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateEndpointConnectionData Data
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

        /// <summary> Get the specified private endpoint connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PrivateEndpointConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified private endpoint connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateEndpointConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the specified private endpoint connection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<PrivateEndpointConnectionDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateEndpointConnectionDeleteOperation(_privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// <summary> Delete the specified private endpoint connection. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PrivateEndpointConnectionDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new PrivateEndpointConnectionDeleteOperation(_privateEndpointConnectionWebPubSubPrivateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionWebPubSubPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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
    }
}