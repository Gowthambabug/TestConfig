// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorableSqlContainersOperations.
    /// </summary>
    public static partial class RestorableSqlContainersOperationsExtensions
    {
            /// <summary>
            /// Show the event feed of all mutations done on all the Azure Cosmos DB SQL
            /// containers under a specific database.  This helps in scenario where
            /// container was accidentally deleted.  This API requires
            /// 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read'
            /// permission
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='instanceId'>
            /// The instanceId GUID of a restorable database account.
            /// </param>
            /// <param name='restorableSqlDatabaseRid'>
            /// The resource ID of the SQL database.
            /// </param>
            /// <param name='startTime'>
            /// The snapshot create timestamp after which snapshots need to be listed.
            /// </param>
            /// <param name='endTime'>
            /// The snapshot create timestamp before which snapshots need to be listed.
            /// </param>
            public static IEnumerable<RestorableSqlContainerGetResult> List(this IRestorableSqlContainersOperations operations, string location, string instanceId, string restorableSqlDatabaseRid = default(string), string startTime = default(string), string endTime = default(string))
            {
                return operations.ListAsync(location, instanceId, restorableSqlDatabaseRid, startTime, endTime).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Show the event feed of all mutations done on all the Azure Cosmos DB SQL
            /// containers under a specific database.  This helps in scenario where
            /// container was accidentally deleted.  This API requires
            /// 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read'
            /// permission
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Cosmos DB region, with spaces between words and each word capitalized.
            /// </param>
            /// <param name='instanceId'>
            /// The instanceId GUID of a restorable database account.
            /// </param>
            /// <param name='restorableSqlDatabaseRid'>
            /// The resource ID of the SQL database.
            /// </param>
            /// <param name='startTime'>
            /// The snapshot create timestamp after which snapshots need to be listed.
            /// </param>
            /// <param name='endTime'>
            /// The snapshot create timestamp before which snapshots need to be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<RestorableSqlContainerGetResult>> ListAsync(this IRestorableSqlContainersOperations operations, string location, string instanceId, string restorableSqlDatabaseRid = default(string), string startTime = default(string), string endTime = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, instanceId, restorableSqlDatabaseRid, startTime, endTime, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}