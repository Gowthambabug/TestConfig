// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of SqlTimeZone and their operations over its parent. </summary>
    public partial class SqlTimeZoneCollection : ArmCollection, IEnumerable<SqlTimeZone>, IAsyncEnumerable<SqlTimeZone>
    {
        private readonly ClientDiagnostics _sqlTimeZoneTimeZonesClientDiagnostics;
        private readonly TimeZonesRestOperations _sqlTimeZoneTimeZonesRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneCollection"/> class for mocking. </summary>
        protected SqlTimeZoneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlTimeZoneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        internal SqlTimeZoneCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _sqlTimeZoneTimeZonesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlTimeZone.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SqlTimeZone.ResourceType, out string sqlTimeZoneTimeZonesApiVersion);
            _sqlTimeZoneTimeZonesRestClient = new TimeZonesRestOperations(_sqlTimeZoneTimeZonesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sqlTimeZoneTimeZonesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Gets a managed instance time zone. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public async virtual Task<Response<SqlTimeZone>> GetAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlTimeZoneTimeZonesRestClient.GetAsync(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sqlTimeZoneTimeZonesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlTimeZone(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Gets a managed instance time zone. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<SqlTimeZone> Get(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlTimeZoneTimeZonesRestClient.Get(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken);
                if (response.Value == null)
                    throw _sqlTimeZoneTimeZonesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlTimeZone(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_ListByLocation
        /// <summary> Gets a list of managed instance time zones by location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlTimeZone" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlTimeZone> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlTimeZone>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlTimeZoneTimeZonesRestClient.ListByLocationAsync(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SqlTimeZone>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlTimeZoneTimeZonesRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_ListByLocation
        /// <summary> Gets a list of managed instance time zones by location. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlTimeZone" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlTimeZone> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlTimeZone> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlTimeZoneTimeZonesRestClient.ListByLocation(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SqlTimeZone> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlTimeZoneTimeZonesRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlTimeZone(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(timeZoneId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<bool> Exists(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(timeZoneId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public async virtual Task<Response<SqlTimeZone>> GetIfExistsAsync(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlTimeZoneTimeZonesRestClient.GetAsync(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlTimeZone>(null, response.GetRawResponse());
                return Response.FromValue(new SqlTimeZone(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/timeZones/{timeZoneId}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: TimeZones_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="timeZoneId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="timeZoneId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZoneId"/> is null. </exception>
        public virtual Response<SqlTimeZone> GetIfExists(string timeZoneId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(timeZoneId, nameof(timeZoneId));

            using var scope = _sqlTimeZoneTimeZonesClientDiagnostics.CreateScope("SqlTimeZoneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlTimeZoneTimeZonesRestClient.Get(Id.SubscriptionId, _locationName, timeZoneId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlTimeZone>(null, response.GetRawResponse());
                return Response.FromValue(new SqlTimeZone(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlTimeZone> IEnumerable<SqlTimeZone>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlTimeZone> IAsyncEnumerable<SqlTimeZone>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}