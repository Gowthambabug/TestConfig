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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing collection of ServiceBusAuthorizationRule and their operations over its parent. </summary>
    public partial class NamespaceDisasterRecoveryAuthorizationRuleCollection : ArmCollection, IEnumerable<NamespaceDisasterRecoveryAuthorizationRule>, IAsyncEnumerable<NamespaceDisasterRecoveryAuthorizationRule>
    {
        private readonly ClientDiagnostics _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics;
        private readonly DisasterRecoveryAuthorizationRulesRestOperations _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NamespaceDisasterRecoveryAuthorizationRuleCollection"/> class for mocking. </summary>
        protected NamespaceDisasterRecoveryAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceDisasterRecoveryAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NamespaceDisasterRecoveryAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", NamespaceDisasterRecoveryAuthorizationRule.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NamespaceDisasterRecoveryAuthorizationRule.ResourceType, out string namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesApiVersion);
            _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient = new DisasterRecoveryAuthorizationRulesRestOperations(_namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DisasterRecovery.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DisasterRecovery.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_Get
        /// <summary> Gets an authorization rule for a namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<NamespaceDisasterRecoveryAuthorizationRule>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NamespaceDisasterRecoveryAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_Get
        /// <summary> Gets an authorization rule for a namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceDisasterRecoveryAuthorizationRule> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceDisasterRecoveryAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_List
        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NamespaceDisasterRecoveryAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NamespaceDisasterRecoveryAuthorizationRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NamespaceDisasterRecoveryAuthorizationRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceDisasterRecoveryAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NamespaceDisasterRecoveryAuthorizationRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceDisasterRecoveryAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_List
        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NamespaceDisasterRecoveryAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NamespaceDisasterRecoveryAuthorizationRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NamespaceDisasterRecoveryAuthorizationRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceDisasterRecoveryAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NamespaceDisasterRecoveryAuthorizationRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NamespaceDisasterRecoveryAuthorizationRule(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<NamespaceDisasterRecoveryAuthorizationRule>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NamespaceDisasterRecoveryAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new NamespaceDisasterRecoveryAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}
        /// OperationId: DisasterRecoveryAuthorizationRules_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<NamespaceDisasterRecoveryAuthorizationRule> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesClientDiagnostics.CreateScope("NamespaceDisasterRecoveryAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _namespaceDisasterRecoveryAuthorizationRuleDisasterRecoveryAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NamespaceDisasterRecoveryAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new NamespaceDisasterRecoveryAuthorizationRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NamespaceDisasterRecoveryAuthorizationRule> IEnumerable<NamespaceDisasterRecoveryAuthorizationRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NamespaceDisasterRecoveryAuthorizationRule> IAsyncEnumerable<NamespaceDisasterRecoveryAuthorizationRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}