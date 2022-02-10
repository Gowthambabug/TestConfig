// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of a Virtual Network that is useable for private site access. </summary>
    public partial class PrivateAccessVirtualNetwork
    {
        /// <summary> Initializes a new instance of PrivateAccessVirtualNetwork. </summary>
        public PrivateAccessVirtualNetwork()
        {
            Subnets = new ChangeTrackingList<PrivateAccessSubnet>();
        }

        /// <summary> Initializes a new instance of PrivateAccessVirtualNetwork. </summary>
        /// <param name="name"> The name of the Virtual Network. </param>
        /// <param name="key"> The key (ID) of the Virtual Network. </param>
        /// <param name="resourceId"> The ARM uri of the Virtual Network. </param>
        /// <param name="subnets"> A List of subnets that access is allowed to on this Virtual Network. An empty array (but not null) is interpreted to mean that all subnets are allowed within this Virtual Network. </param>
        internal PrivateAccessVirtualNetwork(string name, int? key, string resourceId, IList<PrivateAccessSubnet> subnets)
        {
            Name = name;
            Key = key;
            ResourceId = resourceId;
            Subnets = subnets;
        }

        /// <summary> The name of the Virtual Network. </summary>
        public string Name { get; set; }
        /// <summary> The key (ID) of the Virtual Network. </summary>
        public int? Key { get; set; }
        /// <summary> The ARM uri of the Virtual Network. </summary>
        public string ResourceId { get; set; }
        /// <summary> A List of subnets that access is allowed to on this Virtual Network. An empty array (but not null) is interpreted to mean that all subnets are allowed within this Virtual Network. </summary>
        public IList<PrivateAccessSubnet> Subnets { get; }
    }
}