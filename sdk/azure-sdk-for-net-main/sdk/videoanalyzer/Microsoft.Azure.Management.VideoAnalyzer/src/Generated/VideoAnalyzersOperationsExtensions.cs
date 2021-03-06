// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VideoAnalyzersOperations.
    /// </summary>
    public static partial class VideoAnalyzersOperationsExtensions
    {
            /// <summary>
            /// List Video Analyzer accounts
            /// </summary>
            /// <remarks>
            /// Lists the Video Analyzer accounts in the specified resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static VideoAnalyzerCollection List(this IVideoAnalyzersOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Video Analyzer accounts
            /// </summary>
            /// <remarks>
            /// Lists the Video Analyzer accounts in the specified resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerCollection> ListAsync(this IVideoAnalyzersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Get the details of the specified Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            public static VideoAnalyzerAccount Get(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Get the details of the specified Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerAccount> GetAsync(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Create or update an instance of a Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static VideoAnalyzerAccount CreateOrUpdate(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerAccount parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Create or update an instance of a Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerAccount> CreateOrUpdateAsync(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerAccount parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Video Analyzer account.
            /// </summary>
            /// <remarks>
            /// Delete the specified Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            public static void Delete(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Video Analyzer account.
            /// </summary>
            /// <remarks>
            /// Delete the specified Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Updates an existing instance of Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static VideoAnalyzerAccount Update(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Updates an existing instance of Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerAccount> UpdateAsync(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Video Analyzer accounts
            /// </summary>
            /// <remarks>
            /// List all Video Analyzer accounts in the specified subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static VideoAnalyzerCollection ListBySubscription(this IVideoAnalyzersOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Video Analyzer accounts
            /// </summary>
            /// <remarks>
            /// List all Video Analyzer accounts in the specified subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerCollection> ListBySubscriptionAsync(this IVideoAnalyzersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Create or update an instance of a Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static VideoAnalyzerAccount BeginCreateOrUpdate(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerAccount parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Create or update an instance of a Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerAccount> BeginCreateOrUpdateAsync(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerAccount parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Updates an existing instance of Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static VideoAnalyzerAccount BeginUpdate(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Video Analyzer account
            /// </summary>
            /// <remarks>
            /// Updates an existing instance of Video Analyzer account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Video Analyzer account name.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VideoAnalyzerAccount> BeginUpdateAsync(this IVideoAnalyzersOperations operations, string resourceGroupName, string accountName, VideoAnalyzerUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
