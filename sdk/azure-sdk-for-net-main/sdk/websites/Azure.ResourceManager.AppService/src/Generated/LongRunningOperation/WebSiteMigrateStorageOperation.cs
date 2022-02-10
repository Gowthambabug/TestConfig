// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Restores a web app. </summary>
    public partial class WebSiteMigrateStorageOperation : Operation<StorageMigrationResponse>, IOperationSource<StorageMigrationResponse>
    {
        private readonly OperationInternals<StorageMigrationResponse> _operation;

        /// <summary> Initializes a new instance of WebSiteMigrateStorageOperation for mocking. </summary>
        protected WebSiteMigrateStorageOperation()
        {
        }

        internal WebSiteMigrateStorageOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<StorageMigrationResponse>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WebSiteMigrateStorageOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override StorageMigrationResponse Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<StorageMigrationResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<StorageMigrationResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        StorageMigrationResponse IOperationSource<StorageMigrationResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return StorageMigrationResponse.DeserializeStorageMigrationResponse(document.RootElement);
        }

        async ValueTask<StorageMigrationResponse> IOperationSource<StorageMigrationResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return StorageMigrationResponse.DeserializeStorageMigrationResponse(document.RootElement);
        }
    }
}