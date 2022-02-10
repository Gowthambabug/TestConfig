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
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IncidentCommentsOperations.
    /// </summary>
    public static partial class IncidentCommentsOperationsExtensions
    {
            /// <summary>
            /// Gets all incident comments.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            public static IPage<IncidentComment> List(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, ODataQuery<IncidentComment> odataQuery = default(ODataQuery<IncidentComment>), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, incidentId, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all incident comments.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IncidentComment>> ListAsync(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, ODataQuery<IncidentComment> odataQuery = default(ODataQuery<IncidentComment>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, incidentId, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an incident comment.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            public static IncidentComment Get(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an incident comment.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IncidentComment> GetAsync(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the incident comment.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            /// <param name='message'>
            /// The comment message
            /// </param>
            /// <param name='etag'>
            /// Etag of the azure resource
            /// </param>
            public static IncidentComment CreateOrUpdate(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId, string message, string etag = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId, message, etag).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the incident comment.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            /// <param name='message'>
            /// The comment message
            /// </param>
            /// <param name='etag'>
            /// Etag of the azure resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IncidentComment> CreateOrUpdateAsync(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId, string message, string etag = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId, message, etag, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the incident comment.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            public static void Delete(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the incident comment.
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
            /// <param name='incidentId'>
            /// Incident ID
            /// </param>
            /// <param name='incidentCommentId'>
            /// Incident comment ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIncidentCommentsOperations operations, string resourceGroupName, string workspaceName, string incidentId, string incidentCommentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, incidentId, incidentCommentId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all incident comments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IncidentComment> ListNext(this IIncidentCommentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all incident comments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IncidentComment>> ListNextAsync(this IIncidentCommentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}