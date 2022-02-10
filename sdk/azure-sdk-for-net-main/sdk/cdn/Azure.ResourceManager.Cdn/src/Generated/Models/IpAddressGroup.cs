// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> CDN Ip address group. </summary>
    public partial class IpAddressGroup
    {
        /// <summary> Initializes a new instance of IpAddressGroup. </summary>
        public IpAddressGroup()
        {
            Ipv4Addresses = new ChangeTrackingList<CidrIpAddress>();
            Ipv6Addresses = new ChangeTrackingList<CidrIpAddress>();
        }

        /// <summary> Initializes a new instance of IpAddressGroup. </summary>
        /// <param name="deliveryRegion"> The delivery region of the ip address group. </param>
        /// <param name="ipv4Addresses"> The list of ip v4 addresses. </param>
        /// <param name="ipv6Addresses"> The list of ip v6 addresses. </param>
        internal IpAddressGroup(string deliveryRegion, IList<CidrIpAddress> ipv4Addresses, IList<CidrIpAddress> ipv6Addresses)
        {
            DeliveryRegion = deliveryRegion;
            Ipv4Addresses = ipv4Addresses;
            Ipv6Addresses = ipv6Addresses;
        }

        /// <summary> The delivery region of the ip address group. </summary>
        public string DeliveryRegion { get; set; }
        /// <summary> The list of ip v4 addresses. </summary>
        public IList<CidrIpAddress> Ipv4Addresses { get; }
        /// <summary> The list of ip v6 addresses. </summary>
        public IList<CidrIpAddress> Ipv6Addresses { get; }
    }
}