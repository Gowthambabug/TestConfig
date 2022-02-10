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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceOperation along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceOperation : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceOperation"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string operationId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceOperationClientDiagnostics;
        private readonly ManagedInstanceRestOperations _managedInstanceOperationRestClient;
        private readonly ManagedInstanceOperationData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceOperation"/> class for mocking. </summary>
        protected ManagedInstanceOperation()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceOperation"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceOperation(ArmClient client, ManagedInstanceOperationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceOperation"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceOperation(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceOperationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string managedInstanceOperationApiVersion);
            _managedInstanceOperationRestClient = new ManagedInstanceRestOperations(_managedInstanceOperationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceOperationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/operations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedInstanceOperationData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// OperationId: ManagedInstanceOperations_Get
        /// <summary> Gets a management operation on a managed instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceOperation>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperation.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceOperationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managedInstanceOperationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceOperation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// OperationId: ManagedInstanceOperations_Get
        /// <summary> Gets a management operation on a managed instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceOperation> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperation.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceOperationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw _managedInstanceOperationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceOperation(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}/cancel
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// OperationId: ManagedInstanceOperations_Cancel
        /// <summary> Cancels the asynchronous operation on the managed instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperation.Cancel");
            scope.Start();
            try
            {
                var response = await _managedInstanceOperationRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}/cancel
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// OperationId: ManagedInstanceOperations_Cancel
        /// <summary> Cancels the asynchronous operation on the managed instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperation.Cancel");
            scope.Start();
            try
            {
                var response = _managedInstanceOperationRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}