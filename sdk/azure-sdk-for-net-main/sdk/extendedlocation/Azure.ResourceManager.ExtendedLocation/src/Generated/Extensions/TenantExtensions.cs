// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.ResourceManager.ExtendedLocation.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ExtendedLocation
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        private static TenantExtensionClient GetExtensionClient(Tenant tenant)
        {
            return tenant.GetCachedClient((client) =>
            {
                return new TenantExtensionClient(client, tenant.Id);
            }
            );
        }

        /// RequestPath: /providers/Microsoft.ExtendedLocation/operations
        /// ContextualPath: /
        /// OperationId: CustomLocations_ListOperations
        /// <summary> Lists all available Custom Locations operations. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomLocationOperation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CustomLocationOperation> GetOperationsCustomLocationsAsync(this Tenant tenant, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenant).GetOperationsCustomLocationsAsync(cancellationToken);
        }

        /// RequestPath: /providers/Microsoft.ExtendedLocation/operations
        /// ContextualPath: /
        /// OperationId: CustomLocations_ListOperations
        /// <summary> Lists all available Custom Locations operations. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomLocationOperation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CustomLocationOperation> GetOperationsCustomLocations(this Tenant tenant, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenant).GetOperationsCustomLocations(cancellationToken);
        }
    }
}