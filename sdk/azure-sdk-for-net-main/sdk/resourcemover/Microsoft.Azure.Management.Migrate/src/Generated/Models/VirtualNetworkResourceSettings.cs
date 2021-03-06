// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the virtual network resource settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Network/virtualNetworks")]
    public partial class VirtualNetworkResourceSettings : ResourceSettings
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkResourceSettings
        /// class.
        /// </summary>
        public VirtualNetworkResourceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkResourceSettings
        /// class.
        /// </summary>
        /// <param name="targetResourceName">Gets or sets the target Resource
        /// name.</param>
        /// <param name="tags">Gets or sets the Resource tags.</param>
        /// <param name="enableDdosProtection">Gets or sets a value indicating
        /// whether gets or sets whether the
        /// DDOS protection should be switched on.</param>
        /// <param name="addressSpace">Gets or sets the address prefixes for
        /// the virtual network.</param>
        /// <param name="dnsServers">Gets or sets DHCPOptions that contains an
        /// array of DNS servers available to VMs
        /// deployed in the virtual network.</param>
        /// <param name="subnets">Gets or sets List of subnets in a
        /// VirtualNetwork.</param>
        public VirtualNetworkResourceSettings(string targetResourceName, IDictionary<string, string> tags = default(IDictionary<string, string>), bool? enableDdosProtection = default(bool?), IList<string> addressSpace = default(IList<string>), IList<string> dnsServers = default(IList<string>), IList<SubnetResourceSettings> subnets = default(IList<SubnetResourceSettings>))
            : base(targetResourceName)
        {
            Tags = tags;
            EnableDdosProtection = enableDdosProtection;
            AddressSpace = addressSpace;
            DnsServers = dnsServers;
            Subnets = subnets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets whether the
        /// DDOS protection should be switched on.
        /// </summary>
        [JsonProperty(PropertyName = "enableDdosProtection")]
        public bool? EnableDdosProtection { get; set; }

        /// <summary>
        /// Gets or sets the address prefixes for the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "addressSpace")]
        public IList<string> AddressSpace { get; set; }

        /// <summary>
        /// Gets or sets DHCPOptions that contains an array of DNS servers
        /// available to VMs
        /// deployed in the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "dnsServers")]
        public IList<string> DnsServers { get; set; }

        /// <summary>
        /// Gets or sets List of subnets in a VirtualNetwork.
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<SubnetResourceSettings> Subnets { get; set; }

    }
}
