// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Notification update request payload
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AcknowledgeOfferNotificationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AcknowledgeOfferNotificationProperties class.
        /// </summary>
        public AcknowledgeOfferNotificationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AcknowledgeOfferNotificationProperties class.
        /// </summary>
        /// <param name="acknowledge">Gets or sets a value indicating whether
        /// acknowledge action flag is enabled</param>
        /// <param name="dismiss">Gets or sets a value indicating whether
        /// dismiss action flag is enabled</param>
        /// <param name="removeOffer">Gets or sets a value indicating whether
        /// remove offer action flag is enabled</param>
        /// <param name="addPlans">Gets or sets added plans</param>
        /// <param name="removePlans">Gets or sets remove plans</param>
        public AcknowledgeOfferNotificationProperties(bool? acknowledge = default(bool?), bool? dismiss = default(bool?), bool? removeOffer = default(bool?), IList<string> addPlans = default(IList<string>), IList<string> removePlans = default(IList<string>))
        {
            Acknowledge = acknowledge;
            Dismiss = dismiss;
            RemoveOffer = removeOffer;
            AddPlans = addPlans;
            RemovePlans = removePlans;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether acknowledge action flag is
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.acknowledge")]
        public bool? Acknowledge { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dismiss action flag is
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.dismiss")]
        public bool? Dismiss { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether remove offer action flag is
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "properties.removeOffer")]
        public bool? RemoveOffer { get; set; }

        /// <summary>
        /// Gets or sets added plans
        /// </summary>
        [JsonProperty(PropertyName = "properties.addPlans")]
        public IList<string> AddPlans { get; set; }

        /// <summary>
        /// Gets or sets remove plans
        /// </summary>
        [JsonProperty(PropertyName = "properties.removePlans")]
        public IList<string> RemovePlans { get; set; }

    }
}