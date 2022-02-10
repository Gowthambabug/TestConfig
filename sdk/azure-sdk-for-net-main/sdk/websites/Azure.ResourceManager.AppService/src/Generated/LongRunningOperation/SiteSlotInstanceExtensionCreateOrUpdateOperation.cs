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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Invoke the MSDeploy web app extension. </summary>
    public partial class SiteSlotInstanceExtensionCreateOrUpdateOperation : Operation<SiteSlotInstanceExtension>, IOperationSource<SiteSlotInstanceExtension>
    {
        private readonly OperationInternals<SiteSlotInstanceExtension> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SiteSlotInstanceExtensionCreateOrUpdateOperation for mocking. </summary>
        protected SiteSlotInstanceExtensionCreateOrUpdateOperation()
        {
        }

        internal SiteSlotInstanceExtensionCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SiteSlotInstanceExtension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SiteSlotInstanceExtensionCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotInstanceExtension Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotInstanceExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotInstanceExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SiteSlotInstanceExtension IOperationSource<SiteSlotInstanceExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteSlotInstanceExtension(_armClient, data);
        }

        async ValueTask<SiteSlotInstanceExtension> IOperationSource<SiteSlotInstanceExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteSlotInstanceExtension(_armClient, data);
        }
    }
}