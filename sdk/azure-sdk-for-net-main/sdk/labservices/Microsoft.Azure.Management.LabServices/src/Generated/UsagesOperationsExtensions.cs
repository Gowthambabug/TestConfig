// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsagesOperations.
    /// </summary>
    public static partial class UsagesOperationsExtensions
    {
            /// <summary>
            /// Gets the list of usages.
            /// </summary>
            /// <remarks>
            /// Returns list of usage per SKU family for the specified subscription in the
            /// specified region.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply to the operation.
            /// </param>
            public static IPage<Usage> ListByLocation(this IUsagesOperations operations, string location, string filter = default(string))
            {
                return operations.ListByLocationAsync(location, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of usages.
            /// </summary>
            /// <remarks>
            /// Returns list of usage per SKU family for the specified subscription in the
            /// specified region.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Usage>> ListByLocationAsync(this IUsagesOperations operations, string location, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByLocationWithHttpMessagesAsync(location, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of usages.
            /// </summary>
            /// <remarks>
            /// Returns list of usage per SKU family for the specified subscription in the
            /// specified region.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Usage> ListByLocationNext(this IUsagesOperations operations, string nextPageLink)
            {
                return operations.ListByLocationNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of usages.
            /// </summary>
            /// <remarks>
            /// Returns list of usage per SKU family for the specified subscription in the
            /// specified region.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Usage>> ListByLocationNextAsync(this IUsagesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByLocationNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}