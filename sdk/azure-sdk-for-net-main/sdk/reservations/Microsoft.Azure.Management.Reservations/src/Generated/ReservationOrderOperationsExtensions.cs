// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReservationOrderOperations.
    /// </summary>
    public static partial class ReservationOrderOperationsExtensions
    {
            /// <summary>
            /// Calculate price for a `ReservationOrder`.
            /// </summary>
            /// <remarks>
            /// Calculate price for placing a `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Information needed for calculate or purchase reservation
            /// </param>
            public static CalculatePriceResponse Calculate(this IReservationOrderOperations operations, PurchaseRequest body)
            {
                return operations.CalculateAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Calculate price for a `ReservationOrder`.
            /// </summary>
            /// <remarks>
            /// Calculate price for placing a `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Information needed for calculate or purchase reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CalculatePriceResponse> CalculateAsync(this IReservationOrderOperations operations, PurchaseRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CalculateWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ReservationOrderResponse> List(this IReservationOrderOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationOrderResponse>> ListAsync(this IReservationOrderOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Purchase `ReservationOrder`
            /// </summary>
            /// <remarks>
            /// Purchase `ReservationOrder` and create resource under the specified URI.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for calculate or purchase reservation
            /// </param>
            public static ReservationOrderResponse Purchase(this IReservationOrderOperations operations, string reservationOrderId, PurchaseRequest body)
            {
                return operations.PurchaseAsync(reservationOrderId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purchase `ReservationOrder`
            /// </summary>
            /// <remarks>
            /// Purchase `ReservationOrder` and create resource under the specified URI.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for calculate or purchase reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationOrderResponse> PurchaseAsync(this IReservationOrderOperations operations, string reservationOrderId, PurchaseRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PurchaseWithHttpMessagesAsync(reservationOrderId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a specific `ReservationOrder`.
            /// </summary>
            /// <remarks>
            /// Get the details of the `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the planInformation.
            /// </param>
            public static ReservationOrderResponse Get(this IReservationOrderOperations operations, string reservationOrderId, string expand = default(string))
            {
                return operations.GetAsync(reservationOrderId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a specific `ReservationOrder`.
            /// </summary>
            /// <remarks>
            /// Get the details of the `ReservationOrder`.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the planInformation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationOrderResponse> GetAsync(this IReservationOrderOperations operations, string reservationOrderId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(reservationOrderId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Purchase `ReservationOrder`
            /// </summary>
            /// <remarks>
            /// Purchase `ReservationOrder` and create resource under the specified URI.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for calculate or purchase reservation
            /// </param>
            public static ReservationOrderResponse BeginPurchase(this IReservationOrderOperations operations, string reservationOrderId, PurchaseRequest body)
            {
                return operations.BeginPurchaseAsync(reservationOrderId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purchase `ReservationOrder`
            /// </summary>
            /// <remarks>
            /// Purchase `ReservationOrder` and create resource under the specified URI.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='body'>
            /// Information needed for calculate or purchase reservation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReservationOrderResponse> BeginPurchaseAsync(this IReservationOrderOperations operations, string reservationOrderId, PurchaseRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPurchaseWithHttpMessagesAsync(reservationOrderId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationOrderResponse> ListNext(this IReservationOrderOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all `ReservationOrder`s.
            /// </summary>
            /// <remarks>
            /// List of all the `ReservationOrder`s that the user has access to in the
            /// current tenant.
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
            public static async Task<IPage<ReservationOrderResponse>> ListNextAsync(this IReservationOrderOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}