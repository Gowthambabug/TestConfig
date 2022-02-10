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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for KustoPoolAttachedDatabaseConfigurationsOperations.
    /// </summary>
    public static partial class KustoPoolAttachedDatabaseConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Returns the list of attached database configurations of the given Kusto
            /// Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IEnumerable<AttachedDatabaseConfiguration> ListByKustoPool(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string resourceGroupName)
            {
                return operations.ListByKustoPoolAsync(workspaceName, kustoPoolName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of attached database configurations of the given Kusto
            /// Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<AttachedDatabaseConfiguration>> ListByKustoPoolAsync(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByKustoPoolWithHttpMessagesAsync(workspaceName, kustoPoolName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns an attached database configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static AttachedDatabaseConfiguration Get(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName)
            {
                return operations.GetAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns an attached database configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttachedDatabaseConfiguration> GetAsync(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an attached database configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='parameters'>
            /// The database parameters supplied to the CreateOrUpdate operation.
            /// </param>
            public static AttachedDatabaseConfiguration CreateOrUpdate(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, AttachedDatabaseConfiguration parameters)
            {
                return operations.CreateOrUpdateAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an attached database configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='parameters'>
            /// The database parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttachedDatabaseConfiguration> CreateOrUpdateAsync(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, AttachedDatabaseConfiguration parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the attached database configuration with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static void Delete(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName)
            {
                operations.DeleteAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the attached database configuration with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates an attached database configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='parameters'>
            /// The database parameters supplied to the CreateOrUpdate operation.
            /// </param>
            public static AttachedDatabaseConfiguration BeginCreateOrUpdate(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, AttachedDatabaseConfiguration parameters)
            {
                return operations.BeginCreateOrUpdateAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an attached database configuration.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='parameters'>
            /// The database parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AttachedDatabaseConfiguration> BeginCreateOrUpdateAsync(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, AttachedDatabaseConfiguration parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the attached database configuration with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static void BeginDelete(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName)
            {
                operations.BeginDeleteAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the attached database configuration with the given name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='kustoPoolName'>
            /// The name of the Kusto pool.
            /// </param>
            /// <param name='attachedDatabaseConfigurationName'>
            /// The name of the attached database configuration.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IKustoPoolAttachedDatabaseConfigurationsOperations operations, string workspaceName, string kustoPoolName, string attachedDatabaseConfigurationName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(workspaceName, kustoPoolName, attachedDatabaseConfigurationName, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}