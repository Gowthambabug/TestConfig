// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Creates or updates a Template Spec version. </summary>
    public partial class TemplateSpecVersionCreateOrUpdateOperation : Operation<TemplateSpecVersion>
    {
        private readonly OperationOrResponseInternals<TemplateSpecVersion> _operation;

        /// <summary> Initializes a new instance of TemplateSpecVersionCreateOrUpdateOperation for mocking. </summary>
        protected TemplateSpecVersionCreateOrUpdateOperation()
        {
        }

        internal TemplateSpecVersionCreateOrUpdateOperation(ArmClient armClient, Response<TemplateSpecVersionData> response)
        {
            _operation = new OperationOrResponseInternals<TemplateSpecVersion>(Response.FromValue(new TemplateSpecVersion(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override TemplateSpecVersion Value => _operation.Value;

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
        public override ValueTask<Response<TemplateSpecVersion>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TemplateSpecVersion>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}