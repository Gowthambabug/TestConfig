// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExpressRouteGatewaysOperations.
    /// </summary>
    public static partial class ExpressRouteGatewaysOperationsExtensions
    {
            /// <summary>
            /// Lists ExpressRoute gateways under a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ExpressRouteGatewayList ListBySubscription(this IExpressRouteGatewaysOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists ExpressRoute gateways under a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteGatewayList> ListBySubscriptionAsync(this IExpressRouteGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists ExpressRoute gateways in a given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static ExpressRouteGatewayList ListByResourceGroup(this IExpressRouteGatewaysOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists ExpressRoute gateways in a given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteGatewayList> ListByResourceGroupAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a ExpressRoute gateway in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            /// <param name='putExpressRouteGatewayParameters'>
            /// Parameters required in an ExpressRoute gateway PUT operation.
            /// </param>
            public static ExpressRouteGateway CreateOrUpdate(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, ExpressRouteGateway putExpressRouteGatewayParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a ExpressRoute gateway in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            /// <param name='putExpressRouteGatewayParameters'>
            /// Parameters required in an ExpressRoute gateway PUT operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteGateway> CreateOrUpdateAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, ExpressRouteGateway putExpressRouteGatewayParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates express route gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the ExpressRouteGateway.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='expressRouteGatewayParameters'>
            /// Parameters supplied to update a virtual wan express route gateway tags.
            /// </param>
            public static ExpressRouteGateway UpdateTags(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, TagsObject expressRouteGatewayParameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, expressRouteGatewayName, expressRouteGatewayParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates express route gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the ExpressRouteGateway.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='expressRouteGatewayParameters'>
            /// Parameters supplied to update a virtual wan express route gateway tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteGateway> UpdateTagsAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, TagsObject expressRouteGatewayParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, expressRouteGatewayName, expressRouteGatewayParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fetches the details of a ExpressRoute gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            public static ExpressRouteGateway Get(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName)
            {
                return operations.GetAsync(resourceGroupName, expressRouteGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetches the details of a ExpressRoute gateway in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteGateway> GetAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, expressRouteGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified ExpressRoute gateway in a resource group. An
            /// ExpressRoute gateway resource can only be deleted when there are no
            /// connection subresources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            public static void Delete(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName)
            {
                operations.DeleteAsync(resourceGroupName, expressRouteGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified ExpressRoute gateway in a resource group. An
            /// ExpressRoute gateway resource can only be deleted when there are no
            /// connection subresources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, expressRouteGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a ExpressRoute gateway in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            /// <param name='putExpressRouteGatewayParameters'>
            /// Parameters required in an ExpressRoute gateway PUT operation.
            /// </param>
            public static ExpressRouteGateway BeginCreateOrUpdate(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, ExpressRouteGateway putExpressRouteGatewayParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a ExpressRoute gateway in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            /// <param name='putExpressRouteGatewayParameters'>
            /// Parameters required in an ExpressRoute gateway PUT operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteGateway> BeginCreateOrUpdateAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, ExpressRouteGateway putExpressRouteGatewayParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates express route gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the ExpressRouteGateway.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='expressRouteGatewayParameters'>
            /// Parameters supplied to update a virtual wan express route gateway tags.
            /// </param>
            public static ExpressRouteGateway BeginUpdateTags(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, TagsObject expressRouteGatewayParameters)
            {
                return operations.BeginUpdateTagsAsync(resourceGroupName, expressRouteGatewayName, expressRouteGatewayParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates express route gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the ExpressRouteGateway.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='expressRouteGatewayParameters'>
            /// Parameters supplied to update a virtual wan express route gateway tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteGateway> BeginUpdateTagsAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, TagsObject expressRouteGatewayParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, expressRouteGatewayName, expressRouteGatewayParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified ExpressRoute gateway in a resource group. An
            /// ExpressRoute gateway resource can only be deleted when there are no
            /// connection subresources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            public static void BeginDelete(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName)
            {
                operations.BeginDeleteAsync(resourceGroupName, expressRouteGatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified ExpressRoute gateway in a resource group. An
            /// ExpressRoute gateway resource can only be deleted when there are no
            /// connection subresources.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRouteGatewayName'>
            /// The name of the ExpressRoute gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExpressRouteGatewaysOperations operations, string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, expressRouteGatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}