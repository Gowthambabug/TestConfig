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

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> Updates the capabilities of a phone number. </summary>
    public partial class UpdatePhoneNumberCapabilitiesOperation : Operation<PurchasedPhoneNumber>, IOperationSource<PurchasedPhoneNumber>
    {
        private readonly OperationInternals<PurchasedPhoneNumber> _operation;

        /// <summary> Initializes a new instance of UpdatePhoneNumberCapabilitiesOperation for mocking. </summary>
        protected UpdatePhoneNumberCapabilitiesOperation()
        {
        }

        /// <inheritdoc />
        public override PurchasedPhoneNumber Value => _operation.Value;

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
        public override ValueTask<Response<PurchasedPhoneNumber>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PurchasedPhoneNumber>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PurchasedPhoneNumber IOperationSource<PurchasedPhoneNumber>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return PurchasedPhoneNumber.DeserializePurchasedPhoneNumber(document.RootElement);
        }

        async ValueTask<PurchasedPhoneNumber> IOperationSource<PurchasedPhoneNumber>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return PurchasedPhoneNumber.DeserializePurchasedPhoneNumber(document.RootElement);
        }
    }
}