// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AutomationClient.
    /// </summary>
    public static partial class AutomationClientExtensions
    {
            /// <summary>
            /// Post operation to serialize or deserialize GraphRunbookContent
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='parameters'>
            /// Input data describing the graphical runbook.
            /// </param>
            public static GraphicalRunbookContent ConvertGraphRunbookContent(this IAutomationClient operations, string resourceGroupName, string automationAccountName, GraphicalRunbookContent parameters)
            {
                return operations.ConvertGraphRunbookContentAsync(resourceGroupName, automationAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post operation to serialize or deserialize GraphRunbookContent
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='parameters'>
            /// Input data describing the graphical runbook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GraphicalRunbookContent> ConvertGraphRunbookContentAsync(this IAutomationClient operations, string resourceGroupName, string automationAccountName, GraphicalRunbookContent parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ConvertGraphRunbookContentWithHttpMessagesAsync(resourceGroupName, automationAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
