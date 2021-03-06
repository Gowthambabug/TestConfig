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
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SqlPoolTableColumnsOperations.
    /// </summary>
    public static partial class SqlPoolTableColumnsOperationsExtensions
    {
            /// <summary>
            /// Gets columns in a given table in a SQL pool
            /// </summary>
            /// <remarks>
            /// Gets columns in a given table in a SQL pool.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<SqlPoolColumn> ListByTableName(this ISqlPoolTableColumnsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, ODataQuery<SqlPoolColumn> odataQuery = default(ODataQuery<SqlPoolColumn>))
            {
                return operations.ListByTableNameAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets columns in a given table in a SQL pool
            /// </summary>
            /// <remarks>
            /// Gets columns in a given table in a SQL pool.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SqlPoolColumn>> ListByTableNameAsync(this ISqlPoolTableColumnsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName, string tableName, ODataQuery<SqlPoolColumn> odataQuery = default(ODataQuery<SqlPoolColumn>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTableNameWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, schemaName, tableName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets columns in a given table in a SQL pool
            /// </summary>
            /// <remarks>
            /// Gets columns in a given table in a SQL pool.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SqlPoolColumn> ListByTableNameNext(this ISqlPoolTableColumnsOperations operations, string nextPageLink)
            {
                return operations.ListByTableNameNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets columns in a given table in a SQL pool
            /// </summary>
            /// <remarks>
            /// Gets columns in a given table in a SQL pool.
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
            public static async Task<IPage<SqlPoolColumn>> ListByTableNameNextAsync(this ISqlPoolTableColumnsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTableNameNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
