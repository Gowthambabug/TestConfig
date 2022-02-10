// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedDatabaseColumnsOperations.
    /// </summary>
    public static partial class ManagedDatabaseColumnsOperationsExtensions
    {
            /// <summary>
            /// List managed database columns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='schema'>
            /// </param>
            /// <param name='table'>
            /// </param>
            /// <param name='column'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='skiptoken'>
            /// An opaque token that identifies a starting point in the collection.
            /// </param>
            public static IPage<DatabaseColumn> ListByDatabase(this IManagedDatabaseColumnsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, IList<string> schema = default(IList<string>), IList<string> table = default(IList<string>), IList<string> column = default(IList<string>), IList<string> orderBy = default(IList<string>), string skiptoken = default(string))
            {
                return operations.ListByDatabaseAsync(resourceGroupName, managedInstanceName, databaseName, schema, table, column, orderBy, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List managed database columns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='schema'>
            /// </param>
            /// <param name='table'>
            /// </param>
            /// <param name='column'>
            /// </param>
            /// <param name='orderBy'>
            /// </param>
            /// <param name='skiptoken'>
            /// An opaque token that identifies a starting point in the collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DatabaseColumn>> ListByDatabaseAsync(this IManagedDatabaseColumnsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, IList<string> schema = default(IList<string>), IList<string> table = default(IList<string>), IList<string> column = default(IList<string>), IList<string> orderBy = default(IList<string>), string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, schema, table, column, orderBy, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List managed database columns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
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
            public static IPage<DatabaseColumn> ListByTable(this IManagedDatabaseColumnsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, ODataQuery<DatabaseColumn> odataQuery = default(ODataQuery<DatabaseColumn>))
            {
                return operations.ListByTableAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List managed database columns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
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
            public static async Task<IPage<DatabaseColumn>> ListByTableAsync(this IManagedDatabaseColumnsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, ODataQuery<DatabaseColumn> odataQuery = default(ODataQuery<DatabaseColumn>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTableWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get managed database column
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            public static DatabaseColumn Get(this IManagedDatabaseColumnsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get managed database column
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='schemaName'>
            /// The name of the schema.
            /// </param>
            /// <param name='tableName'>
            /// The name of the table.
            /// </param>
            /// <param name='columnName'>
            /// The name of the column.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatabaseColumn> GetAsync(this IManagedDatabaseColumnsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, schemaName, tableName, columnName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List managed database columns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DatabaseColumn> ListByDatabaseNext(this IManagedDatabaseColumnsOperations operations, string nextPageLink)
            {
                return operations.ListByDatabaseNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List managed database columns
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
            public static async Task<IPage<DatabaseColumn>> ListByDatabaseNextAsync(this IManagedDatabaseColumnsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List managed database columns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DatabaseColumn> ListByTableNext(this IManagedDatabaseColumnsOperations operations, string nextPageLink)
            {
                return operations.ListByTableNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List managed database columns
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
            public static async Task<IPage<DatabaseColumn>> ListByTableNextAsync(this IManagedDatabaseColumnsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTableNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}