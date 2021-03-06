// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AlertRuleIncidentsOperations.
    /// </summary>
    public static partial class AlertRuleIncidentsOperationsExtensions
    {
            /// <summary>
            /// Gets an incident associated to an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='incidentName'>
            /// The name of the incident to retrieve.
            /// </param>
            public static Incident Get(this IAlertRuleIncidentsOperations operations, string resourceGroupName, string ruleName, string incidentName)
            {
                return operations.GetAsync(resourceGroupName, ruleName, incidentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an incident associated to an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='incidentName'>
            /// The name of the incident to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Incident> GetAsync(this IAlertRuleIncidentsOperations operations, string resourceGroupName, string ruleName, string incidentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, ruleName, incidentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of incidents associated to an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            public static IEnumerable<Incident> ListByAlertRule(this IAlertRuleIncidentsOperations operations, string resourceGroupName, string ruleName)
            {
                return operations.ListByAlertRuleAsync(resourceGroupName, ruleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of incidents associated to an alert rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='ruleName'>
            /// The name of the rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Incident>> ListByAlertRuleAsync(this IAlertRuleIncidentsOperations operations, string resourceGroupName, string ruleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAlertRuleWithHttpMessagesAsync(resourceGroupName, ruleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
