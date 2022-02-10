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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of BackupItem and their operations over its parent. </summary>
    public partial class SiteBackupCollection : ArmCollection, IEnumerable<SiteBackup>, IAsyncEnumerable<SiteBackup>
    {
        private readonly ClientDiagnostics _siteBackupWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteBackupWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteBackupCollection"/> class for mocking. </summary>
        protected SiteBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteBackupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteBackupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteBackupWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteBackup.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(SiteBackup.ResourceType, out string siteBackupWebAppsApiVersion);
            _siteBackupWebAppsRestClient = new WebAppsRestOperations(_siteBackupWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteBackupWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Description for Gets a backup of an app by its ID. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public async virtual Task<Response<SiteBackup>> GetAsync(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteBackupWebAppsRestClient.GetBackupStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteBackupWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Description for Gets a backup of an app by its ID. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<SiteBackup> Get(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _siteBackupWebAppsRestClient.GetBackupStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken);
                if (response.Value == null)
                    throw _siteBackupWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListBackups
        /// <summary> Description for Gets existing backups of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteBackup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteBackupWebAppsRestClient.ListBackupsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteBackupWebAppsRestClient.ListBackupsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListBackups
        /// <summary> Description for Gets existing backups of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteBackup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteBackupWebAppsRestClient.ListBackups(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteBackupWebAppsRestClient.ListBackupsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteBackup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<bool> Exists(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backupId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public async virtual Task<Response<SiteBackup>> GetIfExistsAsync(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteBackupWebAppsRestClient.GetBackupStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SiteBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/backups/{backupId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetBackupStatus
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupId"> ID of the backup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupId"/> is null. </exception>
        public virtual Response<SiteBackup> GetIfExists(string backupId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupId, nameof(backupId));

            using var scope = _siteBackupWebAppsClientDiagnostics.CreateScope("SiteBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteBackupWebAppsRestClient.GetBackupStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, backupId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SiteBackup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteBackup> IEnumerable<SiteBackup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteBackup> IAsyncEnumerable<SiteBackup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}