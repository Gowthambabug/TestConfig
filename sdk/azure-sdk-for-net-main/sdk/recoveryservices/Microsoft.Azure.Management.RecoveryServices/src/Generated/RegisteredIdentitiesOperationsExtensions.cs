// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RegisteredIdentitiesOperations.
    /// </summary>
    public static partial class RegisteredIdentitiesOperationsExtensions
    {
            /// <summary>
            /// Unregisters the given container from your Recovery Services vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='identityName'>
            /// Name of the protection container to unregister.
            /// </param>
            public static void Delete(this IRegisteredIdentitiesOperations operations, string resourceGroupName, string vaultName, string identityName)
            {
                operations.DeleteAsync(resourceGroupName, vaultName, identityName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregisters the given container from your Recovery Services vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='identityName'>
            /// Name of the protection container to unregister.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRegisteredIdentitiesOperations operations, string resourceGroupName, string vaultName, string identityName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vaultName, identityName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}