// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Purview.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A privately linkable resource properties.
    /// </summary>
    public partial class PrivateLinkResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceProperties
        /// class.
        /// </summary>
        public PrivateLinkResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceProperties
        /// class.
        /// </summary>
        /// <param name="groupId">The private link resource group
        /// identifier.</param>
        /// <param name="requiredMembers">This translates to how many Private
        /// IPs should be created for each privately linkable resource.</param>
        /// <param name="requiredZoneNames">The required zone names for private
        /// link resource.</param>
        public PrivateLinkResourceProperties(string groupId = default(string), IList<string> requiredMembers = default(IList<string>), IList<string> requiredZoneNames = default(IList<string>))
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the private link resource group identifier.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; private set; }

        /// <summary>
        /// Gets this translates to how many Private IPs should be created for
        /// each privately linkable resource.
        /// </summary>
        [JsonProperty(PropertyName = "requiredMembers")]
        public IList<string> RequiredMembers { get; private set; }

        /// <summary>
        /// Gets the required zone names for private link resource.
        /// </summary>
        [JsonProperty(PropertyName = "requiredZoneNames")]
        public IList<string> RequiredZoneNames { get; private set; }

    }
}