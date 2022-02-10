// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Insights.Models;

namespace Azure.ResourceManager.Insights
{
    /// <summary> The MetricAlertsStatus service client. </summary>
    public partial class MetricAlertsStatusOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal MetricAlertsStatusRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of MetricAlertsStatusOperations for mocking. </summary>
        protected MetricAlertsStatusOperations()
        {
        }

        /// <summary> Initializes a new instance of MetricAlertsStatusOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The Azure subscription Id. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal MetricAlertsStatusOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new MetricAlertsStatusRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieve an alert rule status. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetricAlertStatusCollection>> ListAsync(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsStatusOperations.List");
            scope.Start();
            try
            {
                return await RestClient.ListAsync(resourceGroupName, ruleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve an alert rule status. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetricAlertStatusCollection> List(string resourceGroupName, string ruleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsStatusOperations.List");
            scope.Start();
            try
            {
                return RestClient.List(resourceGroupName, ruleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve an alert rule status. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="statusName"> The name of the status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MetricAlertStatusCollection>> ListByNameAsync(string resourceGroupName, string ruleName, string statusName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsStatusOperations.ListByName");
            scope.Start();
            try
            {
                return await RestClient.ListByNameAsync(resourceGroupName, ruleName, statusName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve an alert rule status. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="statusName"> The name of the status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MetricAlertStatusCollection> ListByName(string resourceGroupName, string ruleName, string statusName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MetricAlertsStatusOperations.ListByName");
            scope.Start();
            try
            {
                return RestClient.ListByName(resourceGroupName, ruleName, statusName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}