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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceDatabaseBackupShortTermRetentionPolicy along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceDatabaseBackupShortTermRetentionPolicy : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicy"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string policyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics;
        private readonly ManagedBackupShortTermRetentionPoliciesRestOperations _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient;
        private readonly ManagedBackupShortTermRetentionPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicy"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseBackupShortTermRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceDatabaseBackupShortTermRetentionPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseBackupShortTermRetentionPolicy(ArmClient client, ManagedBackupShortTermRetentionPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseBackupShortTermRetentionPolicy"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseBackupShortTermRetentionPolicy(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesApiVersion);
            _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient = new ManagedBackupShortTermRetentionPoliciesRestOperations(_managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/backupShortTermRetentionPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedBackupShortTermRetentionPolicyData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Gets a managed database&apos;s short term retention policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicy.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Get
        /// <summary> Gets a managed database&apos;s short term retention policy. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseBackupShortTermRetentionPolicy> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicy.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseBackupShortTermRetentionPolicy(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Update
        /// <summary> Updates a managed database&apos;s short term retention policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedInstanceDatabaseBackupShortTermRetentionPolicyUpdateOperation> UpdateAsync(bool waitForCompletion, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicy.Update");
            scope.Start();
            try
            {
                var response = await _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedInstanceDatabaseBackupShortTermRetentionPolicyUpdateOperation(Client, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/backupShortTermRetentionPolicies/{policyName}
        /// OperationId: ManagedBackupShortTermRetentionPolicies_Update
        /// <summary> Updates a managed database&apos;s short term retention policy. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedInstanceDatabaseBackupShortTermRetentionPolicyUpdateOperation Update(bool waitForCompletion, ManagedBackupShortTermRetentionPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedInstanceDatabaseBackupShortTermRetentionPolicy.Update");
            scope.Start();
            try
            {
                var response = _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters, cancellationToken);
                var operation = new ManagedInstanceDatabaseBackupShortTermRetentionPolicyUpdateOperation(Client, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedInstanceDatabaseBackupShortTermRetentionPolicyManagedBackupShortTermRetentionPoliciesRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, parameters).Request, response);
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
    }
}