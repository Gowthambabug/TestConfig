// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AliasOperations.
    /// </summary>
    public static partial class AliasOperationsExtensions
    {
            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SubscriptionAliasResponse Create(this IAliasOperations operations, string aliasName, PutAliasRequest body)
            {
                return operations.CreateAsync(aliasName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasResponse> CreateAsync(this IAliasOperations operations, string aliasName, PutAliasRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(aliasName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            public static SubscriptionAliasResponse Get(this IAliasOperations operations, string aliasName)
            {
                return operations.GetAsync(aliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasResponse> GetAsync(this IAliasOperations operations, string aliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(aliasName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete Alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            public static void Delete(this IAliasOperations operations, string aliasName)
            {
                operations.DeleteAsync(aliasName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete Alias.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAliasOperations operations, string aliasName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(aliasName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SubscriptionAliasListResult List(this IAliasOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasListResult> ListAsync(this IAliasOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static SubscriptionAliasResponse BeginCreate(this IAliasOperations operations, string aliasName, PutAliasRequest body)
            {
                return operations.BeginCreateAsync(aliasName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Alias Subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='aliasName'>
            /// AliasName is the name for the subscription creation request. Note that this
            /// is not the same as subscription name and this doesn’t have any other
            /// lifecycle need beyond the request for subscription creation.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionAliasResponse> BeginCreateAsync(this IAliasOperations operations, string aliasName, PutAliasRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(aliasName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
