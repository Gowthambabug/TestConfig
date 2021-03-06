// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConfigurationsOperations.
    /// </summary>
    public static partial class ConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Updates a configuration of a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server configuration.
            /// </param>
            public static Configuration Update(this IConfigurationsOperations operations, string resourceGroupName, string serverName, string configurationName, Configuration parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serverName, configurationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a configuration of a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Configuration> UpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverName, string configurationName, Configuration parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, configurationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about a configuration of server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server configuration.
            /// </param>
            public static Configuration Get(this IConfigurationsOperations operations, string resourceGroupName, string serverName, string configurationName)
            {
                return operations.GetAsync(resourceGroupName, serverName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about a configuration of server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Configuration> GetAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            public static ConfigurationListResult BatchUpdate(this IConfigurationsOperations operations, string resourceGroupName, string serverName, ConfigurationListForBatchUpdate parameters)
            {
                return operations.BatchUpdateAsync(resourceGroupName, serverName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationListResult> BatchUpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverName, ConfigurationListForBatchUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BatchUpdateWithHttpMessagesAsync(resourceGroupName, serverName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IPage<Configuration> ListByServer(this IConfigurationsOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Configuration>> ListByServerAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a configuration of a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server configuration.
            /// </param>
            public static Configuration BeginUpdate(this IConfigurationsOperations operations, string resourceGroupName, string serverName, string configurationName, Configuration parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serverName, configurationName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a configuration of a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='configurationName'>
            /// The name of the server configuration.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for updating a server configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Configuration> BeginUpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverName, string configurationName, Configuration parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, configurationName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            public static ConfigurationListResult BeginBatchUpdate(this IConfigurationsOperations operations, string resourceGroupName, string serverName, ConfigurationListForBatchUpdate parameters)
            {
                return operations.BeginBatchUpdateAsync(resourceGroupName, serverName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a list of configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for updating a list of server configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationListResult> BeginBatchUpdateAsync(this IConfigurationsOperations operations, string resourceGroupName, string serverName, ConfigurationListForBatchUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginBatchUpdateWithHttpMessagesAsync(resourceGroupName, serverName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the configurations in a given server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Configuration> ListByServerNext(this IConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the configurations in a given server.
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
            public static async Task<IPage<Configuration>> ListByServerNextAsync(this IConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
