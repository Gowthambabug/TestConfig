// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The response to the List Subscriptions operation. </summary>
    internal partial class ServiceBusSubscriptionListResult
    {
        /// <summary> Initializes a new instance of ServiceBusSubscriptionListResult. </summary>
        internal ServiceBusSubscriptionListResult()
        {
            Value = new ChangeTrackingList<ServiceBusSubscriptionData>();
        }

        /// <summary> Initializes a new instance of ServiceBusSubscriptionListResult. </summary>
        /// <param name="value"> Result of the List Subscriptions operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of subscriptions. </param>
        internal ServiceBusSubscriptionListResult(IReadOnlyList<ServiceBusSubscriptionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List Subscriptions operation. </summary>
        public IReadOnlyList<ServiceBusSubscriptionData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of subscriptions. </summary>
        public string NextLink { get; }
    }
}
