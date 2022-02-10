﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;

using Azure.Core.Pipeline;

using OpenTelemetry;
using OpenTelemetry.Metrics;

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    [AggregationTemporality(AggregationTemporality.Delta)]
    internal class AzureMonitorMetricExporter : BaseExporter<Metric>
    {
        private readonly ITransmitter Transmitter;
        private readonly AzureMonitorExporterOptions options;
        private readonly string instrumentationKey;
        private readonly ResourceParser resourceParser;

        public AzureMonitorMetricExporter(AzureMonitorExporterOptions options) : this(options, new AzureMonitorTransmitter(options))
        {
        }

        internal AzureMonitorMetricExporter(AzureMonitorExporterOptions options, ITransmitter transmitter)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
            ConnectionString.ConnectionStringParser.GetValues(this.options.ConnectionString, out this.instrumentationKey, out _);
            this.Transmitter = transmitter;
            resourceParser = new ResourceParser();
        }

        /// <inheritdoc/>
        public override ExportResult Export(in Batch<Metric> batch)
        {
            // Prevent Azure Monitor's HTTP operations from being instrumented.
            using var scope = SuppressInstrumentationScope.Begin();

            try
            {
                var resource = this.ParentProvider.GetResource();
                resourceParser.UpdateRoleNameAndInstance(resource);
                var telemetryItems = MetricHelper.OtelToAzureMonitorMetrics(batch, resourceParser.RoleName, resourceParser.RoleInstance, instrumentationKey);

                // TODO: Handle return value, it can be converted as metrics.
                // TODO: Validate CancellationToken and async pattern here.
                this.Transmitter.TrackAsync(telemetryItems, false, CancellationToken.None).EnsureCompleted();
                return ExportResult.Success;
            }
            catch (Exception ex)
            {
                AzureMonitorExporterEventSource.Log.Write($"FailedToExport{EventLevelSuffix.Error}", ex.LogAsyncException());
                return ExportResult.Failure;
            }
        }
    }
}