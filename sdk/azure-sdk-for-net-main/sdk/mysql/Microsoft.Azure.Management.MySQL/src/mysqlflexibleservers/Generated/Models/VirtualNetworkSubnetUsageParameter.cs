// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Virtual network subnet usage parameter
    /// </summary>
    public partial class VirtualNetworkSubnetUsageParameter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkSubnetUsageParameter class.
        /// </summary>
        public VirtualNetworkSubnetUsageParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkSubnetUsageParameter class.
        /// </summary>
        /// <param name="virtualNetworkResourceId">Virtual network resource
        /// id.</param>
        public VirtualNetworkSubnetUsageParameter(string virtualNetworkResourceId = default(string))
        {
            VirtualNetworkResourceId = virtualNetworkResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets virtual network resource id.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkResourceId")]
        public string VirtualNetworkResourceId { get; set; }

    }
}
