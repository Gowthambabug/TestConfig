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
    /// <summary> Creates a data flow debug session. </summary>
    public partial class DataFlowDebugSessionCreateDataFlowDebugSessionOperation : Operation<CreateDataFlowDebugSessionResponse>, IOperationSource<CreateDataFlowDebugSessionResponse>
    {
        private readonly OperationInternals<CreateDataFlowDebugSessionResponse> _operation;

        /// <summary> Initializes a new instance of DataFlowDebugSessionCreateDataFlowDebugSessionOperation for mocking. </summary>
        protected DataFlowDebugSessionCreateDataFlowDebugSessionOperation()
        {
        }

        internal DataFlowDebugSessionCreateDataFlowDebugSessionOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CreateDataFlowDebugSessionResponse>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DataFlowDebugSessionCreateDataFlowDebugSessionOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CreateDataFlowDebugSessionResponse Value => _operation.Value;

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
        public override ValueTask<Response<CreateDataFlowDebugSessionResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CreateDataFlowDebugSessionResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CreateDataFlowDebugSessionResponse IOperationSource<CreateDataFlowDebugSessionResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return CreateDataFlowDebugSessionResponse.DeserializeCreateDataFlowDebugSessionResponse(document.RootElement);
        }

        async ValueTask<CreateDataFlowDebugSessionResponse> IOperationSource<CreateDataFlowDebugSessionResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return CreateDataFlowDebugSessionResponse.DeserializeCreateDataFlowDebugSessionResponse(document.RootElement);
        }
    }
}