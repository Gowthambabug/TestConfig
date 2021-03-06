// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents ASC (Azure Security Center) requirements check request.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureSecurityCenter")]
    [Rest.Serialization.JsonTransformation]
    public partial class ASCCheckRequirements : DataConnectorsCheckRequirements
    {
        /// <summary>
        /// Initializes a new instance of the ASCCheckRequirements class.
        /// </summary>
        public ASCCheckRequirements()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ASCCheckRequirements class.
        /// </summary>
        /// <param name="subscriptionId">The subscription id to connect to, and
        /// get the data from.</param>
        public ASCCheckRequirements(string subscriptionId = default(string))
        {
            SubscriptionId = subscriptionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the subscription id to connect to, and get the data
        /// from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; set; }

    }
}
