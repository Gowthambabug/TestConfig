// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorableTimeRangesOperations.
    /// </summary>
    public static partial class RestorableTimeRangesOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupInstanceName'>
            /// The name of the backup instance
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static AzureBackupFindRestorableTimeRangesResponseResource Find(this IRestorableTimeRangesOperations operations, string vaultName, string resourceGroupName, string backupInstanceName, AzureBackupFindRestorableTimeRangesRequest parameters)
            {
                return operations.FindAsync(vaultName, resourceGroupName, backupInstanceName, parameters).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the backup vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the backup vault is present.
            /// </param>
            /// <param name='backupInstanceName'>
            /// The name of the backup instance
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AzureBackupFindRestorableTimeRangesResponseResource> FindAsync(this IRestorableTimeRangesOperations operations, string vaultName, string resourceGroupName, string backupInstanceName, AzureBackupFindRestorableTimeRangesRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FindWithHttpMessagesAsync(vaultName, resourceGroupName, backupInstanceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
