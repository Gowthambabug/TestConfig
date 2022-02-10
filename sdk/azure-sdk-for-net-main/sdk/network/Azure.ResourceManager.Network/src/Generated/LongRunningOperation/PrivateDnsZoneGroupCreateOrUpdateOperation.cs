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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates or updates a private dns zone group in the specified private endpoint. </summary>
    public partial class PrivateDnsZoneGroupCreateOrUpdateOperation : Operation<PrivateDnsZoneGroup>, IOperationSource<PrivateDnsZoneGroup>
    {
        private readonly OperationInternals<PrivateDnsZoneGroup> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of PrivateDnsZoneGroupCreateOrUpdateOperation for mocking. </summary>
        protected PrivateDnsZoneGroupCreateOrUpdateOperation()
        {
        }

        internal PrivateDnsZoneGroupCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<PrivateDnsZoneGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "PrivateDnsZoneGroupCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PrivateDnsZoneGroup Value => _operation.Value;

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
        public override ValueTask<Response<PrivateDnsZoneGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PrivateDnsZoneGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PrivateDnsZoneGroup IOperationSource<PrivateDnsZoneGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateDnsZoneGroupData.DeserializePrivateDnsZoneGroupData(document.RootElement);
            return new PrivateDnsZoneGroup(_armClient, data);
        }

        async ValueTask<PrivateDnsZoneGroup> IOperationSource<PrivateDnsZoneGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateDnsZoneGroupData.DeserializePrivateDnsZoneGroupData(document.RootElement);
            return new PrivateDnsZoneGroup(_armClient, data);
        }
    }
}