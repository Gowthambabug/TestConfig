// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Creates or updates a pipeline. </summary>
    public partial class PipelineCreateOrUpdatePipelineOperation : Operation<PipelineResource>, IOperationSource<PipelineResource>
    {
        private readonly OperationInternals<PipelineResource> _operation;

        /// <summary> Initializes a new instance of PipelineCreateOrUpdatePipelineOperation for mocking. </summary>
        protected PipelineCreateOrUpdatePipelineOperation()
        {
        }

        internal PipelineCreateOrUpdatePipelineOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<PipelineResource>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "PipelineCreateOrUpdatePipelineOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PipelineResource Value => _operation.Value;

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
        public override ValueTask<Response<PipelineResource>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PipelineResource>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PipelineResource IOperationSource<PipelineResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return PipelineResource.DeserializePipelineResource(document.RootElement);
        }

        async ValueTask<PipelineResource> IOperationSource<PipelineResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return PipelineResource.DeserializePipelineResource(document.RootElement);
        }
    }
}