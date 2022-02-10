// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The state of a private link connection
    /// </summary>
    public partial class PrivateLinkConnectionState
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkConnectionState class.
        /// </summary>
        public PrivateLinkConnectionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkConnectionState class.
        /// </summary>
        /// <param name="status">Status of a private link connection</param>
        /// <param name="description">Description of a private link
        /// connection</param>
        /// <param name="actionsRequired">ActionsRequired for a private link
        /// connection</param>
        public PrivateLinkConnectionState(string status = default(string), string description = default(string), string actionsRequired = default(string))
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of a private link connection
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets description of a private link connection
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets actionsRequired for a private link connection
        /// </summary>
        [JsonProperty(PropertyName = "actionsRequired")]
        public string ActionsRequired { get; set; }

    }
}