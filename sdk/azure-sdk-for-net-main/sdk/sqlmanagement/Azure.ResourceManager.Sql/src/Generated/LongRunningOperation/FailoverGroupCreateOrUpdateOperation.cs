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
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Creates or updates a failover group. </summary>
    public partial class FailoverGroupCreateOrUpdateOperation : Operation<FailoverGroup>, IOperationSource<FailoverGroup>
    {
        private readonly OperationInternals<FailoverGroup> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of FailoverGroupCreateOrUpdateOperation for mocking. </summary>
        protected FailoverGroupCreateOrUpdateOperation()
        {
        }

        internal FailoverGroupCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<FailoverGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "FailoverGroupCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override FailoverGroup Value => _operation.Value;

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
        public override ValueTask<Response<FailoverGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FailoverGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        FailoverGroup IOperationSource<FailoverGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FailoverGroupData.DeserializeFailoverGroupData(document.RootElement);
            return new FailoverGroup(_armClient, data);
        }

        async ValueTask<FailoverGroup> IOperationSource<FailoverGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FailoverGroupData.DeserializeFailoverGroupData(document.RootElement);
            return new FailoverGroup(_armClient, data);
        }
    }
}