// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SingleSignOnConfigurationsOperations.
    /// </summary>
    public static partial class SingleSignOnConfigurationsOperationsExtensions
    {
            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            public static IPage<DatadogSingleSignOnResource> List(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName)
            {
                return operations.ListAsync(resourceGroupName, monitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DatadogSingleSignOnResource>> ListAsync(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, monitorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// Configuration name
            /// </param>
            /// <param name='properties'>
            /// </param>
            public static DatadogSingleSignOnResource CreateOrUpdate(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName, string configurationName, DatadogSingleSignOnProperties properties = default(DatadogSingleSignOnProperties))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, monitorName, configurationName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// Configuration name
            /// </param>
            /// <param name='properties'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatadogSingleSignOnResource> CreateOrUpdateAsync(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName, string configurationName, DatadogSingleSignOnProperties properties = default(DatadogSingleSignOnProperties), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, monitorName, configurationName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the datadog single sign-on resource for the given Monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// Configuration name
            /// </param>
            public static DatadogSingleSignOnResource Get(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName, string configurationName)
            {
                return operations.GetAsync(resourceGroupName, monitorName, configurationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the datadog single sign-on resource for the given Monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// Configuration name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatadogSingleSignOnResource> GetAsync(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName, string configurationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, monitorName, configurationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// Configuration name
            /// </param>
            /// <param name='properties'>
            /// </param>
            public static DatadogSingleSignOnResource BeginCreateOrUpdate(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName, string configurationName, DatadogSingleSignOnProperties properties = default(DatadogSingleSignOnProperties))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, monitorName, configurationName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Configures single-sign-on for this resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='monitorName'>
            /// Monitor resource name
            /// </param>
            /// <param name='configurationName'>
            /// Configuration name
            /// </param>
            /// <param name='properties'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatadogSingleSignOnResource> BeginCreateOrUpdateAsync(this ISingleSignOnConfigurationsOperations operations, string resourceGroupName, string monitorName, string configurationName, DatadogSingleSignOnProperties properties = default(DatadogSingleSignOnProperties), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, monitorName, configurationName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DatadogSingleSignOnResource> ListNext(this ISingleSignOnConfigurationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the single sign-on configurations for a given monitor resource.
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
            public static async Task<IPage<DatadogSingleSignOnResource>> ListNextAsync(this ISingleSignOnConfigurationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}