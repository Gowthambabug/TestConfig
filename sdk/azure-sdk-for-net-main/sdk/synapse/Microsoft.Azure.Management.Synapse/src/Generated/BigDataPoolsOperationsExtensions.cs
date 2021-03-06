// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BigDataPoolsOperations.
    /// </summary>
    public static partial class BigDataPoolsOperationsExtensions
    {
            /// <summary>
            /// Get Big Data pool
            /// </summary>
            /// <remarks>
            /// Get a Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            public static BigDataPoolResourceInfo Get(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, bigDataPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get Big Data pool
            /// </summary>
            /// <remarks>
            /// Get a Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BigDataPoolResourceInfo> GetAsync(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, bigDataPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Patch a Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='bigDataPoolPatchInfo'>
            /// The updated Big Data pool properties
            /// </param>
            public static BigDataPoolResourceInfo Update(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, BigDataPoolPatchInfo bigDataPoolPatchInfo)
            {
                return operations.UpdateAsync(resourceGroupName, workspaceName, bigDataPoolName, bigDataPoolPatchInfo).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Patch a Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='bigDataPoolPatchInfo'>
            /// The updated Big Data pool properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BigDataPoolResourceInfo> UpdateAsync(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, BigDataPoolPatchInfo bigDataPoolPatchInfo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, bigDataPoolName, bigDataPoolPatchInfo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Create a new Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='bigDataPoolInfo'>
            /// The Big Data pool to create.
            /// </param>
            /// <param name='force'>
            /// Whether to stop any running jobs in the Big Data pool
            /// </param>
            public static BigDataPoolResourceInfo CreateOrUpdate(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, BigDataPoolResourceInfo bigDataPoolInfo, bool? force = false)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, bigDataPoolName, bigDataPoolInfo, force).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Create a new Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='bigDataPoolInfo'>
            /// The Big Data pool to create.
            /// </param>
            /// <param name='force'>
            /// Whether to stop any running jobs in the Big Data pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BigDataPoolResourceInfo> CreateOrUpdateAsync(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, BigDataPoolResourceInfo bigDataPoolInfo, bool? force = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, bigDataPoolName, bigDataPoolInfo, force, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Delete a Big Data pool from the workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            public static object Delete(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName)
            {
                return operations.DeleteAsync(resourceGroupName, workspaceName, bigDataPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Delete a Big Data pool from the workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteAsync(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, bigDataPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the Big Data pools in a workspace.
            /// </summary>
            /// <remarks>
            /// List Big Data pools in a workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IPage<BigDataPoolResourceInfo> ListByWorkspace(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName)
            {
                return operations.ListByWorkspaceAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the Big Data pools in a workspace.
            /// </summary>
            /// <remarks>
            /// List Big Data pools in a workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BigDataPoolResourceInfo>> ListByWorkspaceAsync(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Create a new Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='bigDataPoolInfo'>
            /// The Big Data pool to create.
            /// </param>
            /// <param name='force'>
            /// Whether to stop any running jobs in the Big Data pool
            /// </param>
            public static BigDataPoolResourceInfo BeginCreateOrUpdate(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, BigDataPoolResourceInfo bigDataPoolInfo, bool? force = false)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, bigDataPoolName, bigDataPoolInfo, force).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Create a new Big Data pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='bigDataPoolInfo'>
            /// The Big Data pool to create.
            /// </param>
            /// <param name='force'>
            /// Whether to stop any running jobs in the Big Data pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BigDataPoolResourceInfo> BeginCreateOrUpdateAsync(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, BigDataPoolResourceInfo bigDataPoolInfo, bool? force = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, bigDataPoolName, bigDataPoolInfo, force, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Delete a Big Data pool from the workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            public static object BeginDelete(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, workspaceName, bigDataPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Big Data pool.
            /// </summary>
            /// <remarks>
            /// Delete a Big Data pool from the workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bigDataPoolName'>
            /// Big Data pool name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> BeginDeleteAsync(this IBigDataPoolsOperations operations, string resourceGroupName, string workspaceName, string bigDataPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, bigDataPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the Big Data pools in a workspace.
            /// </summary>
            /// <remarks>
            /// List Big Data pools in a workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BigDataPoolResourceInfo> ListByWorkspaceNext(this IBigDataPoolsOperations operations, string nextPageLink)
            {
                return operations.ListByWorkspaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the Big Data pools in a workspace.
            /// </summary>
            /// <remarks>
            /// List Big Data pools in a workspace.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BigDataPoolResourceInfo>> ListByWorkspaceNextAsync(this IBigDataPoolsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByWorkspaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
