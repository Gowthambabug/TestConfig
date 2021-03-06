// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BookmarkOperations.
    /// </summary>
    public static partial class BookmarkOperationsExtensions
    {
            /// <summary>
            /// Expand an bookmark
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute an expand operation on the given
            /// bookmark.
            /// </param>
            public static BookmarkExpandResponse Expand(this IBookmarkOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, BookmarkExpandParameters parameters)
            {
                return operations.ExpandAsync(resourceGroupName, workspaceName, bookmarkId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Expand an bookmark
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='bookmarkId'>
            /// Bookmark ID
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute an expand operation on the given
            /// bookmark.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BookmarkExpandResponse> ExpandAsync(this IBookmarkOperations operations, string resourceGroupName, string workspaceName, string bookmarkId, BookmarkExpandParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExpandWithHttpMessagesAsync(resourceGroupName, workspaceName, bookmarkId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
