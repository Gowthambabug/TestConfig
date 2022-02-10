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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a ServerfarmVirtualNetworkConnectionGateway along with the instance operations that can be performed on it. </summary>
    public partial class ServerfarmVirtualNetworkConnectionGateway : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServerfarmVirtualNetworkConnectionGateway"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName, string gatewayName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics;
        private readonly AppServicePlansRestOperations _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient;
        private readonly VnetGatewayData _data;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionGateway"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionGateway()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServerfarmVirtualNetworkConnectionGateway"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnectionGateway(ArmClient client, VnetGatewayData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionGateway"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServerfarmVirtualNetworkConnectionGateway(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string serverfarmVirtualNetworkConnectionGatewayAppServicePlansApiVersion);
            _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient = new AppServicePlansRestOperations(_serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serverfarmVirtualNetworkConnectionGatewayAppServicePlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/serverfarms/virtualNetworkConnections/gateways";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VnetGatewayData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Description for Get a Virtual Network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnectionGateway>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGateway.Get");
            scope.Start();
            try
            {
                var response = await _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Description for Get a Virtual Network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerfarmVirtualNetworkConnectionGateway> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGateway.Get");
            scope.Start();
            try
            {
                var response = _serverfarmVirtualNetworkConnectionGatewayAppServicePlansRestClient.GetVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _serverfarmVirtualNetworkConnectionGatewayAppServicePlansClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}