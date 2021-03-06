// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of aliases.
    /// </summary>
    public partial class SubscriptionAliasListResult
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionAliasListResult
        /// class.
        /// </summary>
        public SubscriptionAliasListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionAliasListResult
        /// class.
        /// </summary>
        /// <param name="value">The list of alias.</param>
        /// <param name="nextLink">The link (url) to the next page of
        /// results.</param>
        public SubscriptionAliasListResult(IList<SubscriptionAliasResponse> value = default(IList<SubscriptionAliasResponse>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of alias.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SubscriptionAliasResponse> Value { get; private set; }

        /// <summary>
        /// Gets the link (url) to the next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
