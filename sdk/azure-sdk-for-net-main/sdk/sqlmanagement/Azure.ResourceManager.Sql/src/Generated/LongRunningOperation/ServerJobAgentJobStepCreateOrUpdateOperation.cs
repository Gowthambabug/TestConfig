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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Creates or updates a job step. This will implicitly create a new job version. </summary>
    public partial class ServerJobAgentJobStepCreateOrUpdateOperation : Operation<ServerJobAgentJobStep>
    {
        private readonly OperationOrResponseInternals<ServerJobAgentJobStep> _operation;

        /// <summary> Initializes a new instance of ServerJobAgentJobStepCreateOrUpdateOperation for mocking. </summary>
        protected ServerJobAgentJobStepCreateOrUpdateOperation()
        {
        }

        internal ServerJobAgentJobStepCreateOrUpdateOperation(ArmClient armClient, Response<JobStepData> response)
        {
            _operation = new OperationOrResponseInternals<ServerJobAgentJobStep>(Response.FromValue(new ServerJobAgentJobStep(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerJobAgentJobStep Value => _operation.Value;

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
        public override ValueTask<Response<ServerJobAgentJobStep>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerJobAgentJobStep>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}