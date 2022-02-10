// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DppTrackedResourceList
    {
        /// <summary>
        /// Initializes a new instance of the DppTrackedResourceList class.
        /// </summary>
        public DppTrackedResourceList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DppTrackedResourceList class.
        /// </summary>
        /// <param name="nextLink">The uri to fetch the next page of resources.
        /// Call ListNext() fetches next page of resources.</param>
        public DppTrackedResourceList(string nextLink = default(string))
        {
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the uri to fetch the next page of resources. Call
        /// ListNext() fetches next page of resources.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}