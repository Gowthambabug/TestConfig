// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the LoadBalancer data model. </summary>
    public partial class LoadBalancerData : Resource
    {
        /// <summary> Initializes a new instance of LoadBalancerData. </summary>
        public LoadBalancerData()
        {
            FrontendIPConfigurations = new ChangeTrackingList<FrontendIPConfigurationData>();
            BackendAddressPools = new ChangeTrackingList<BackendAddressPoolData>();
            LoadBalancingRules = new ChangeTrackingList<LoadBalancingRuleData>();
            Probes = new ChangeTrackingList<ProbeData>();
            InboundNatRules = new ChangeTrackingList<InboundNatRuleData>();
            InboundNatPools = new ChangeTrackingList<InboundNatPool>();
            OutboundRules = new ChangeTrackingList<OutboundRuleData>();
        }

        /// <summary> Initializes a new instance of LoadBalancerData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the load balancer. </param>
        /// <param name="sku"> The load balancer SKU. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="frontendIPConfigurations"> Object representing the frontend IPs to be used for the load balancer. </param>
        /// <param name="backendAddressPools"> Collection of backend address pools used by a load balancer. </param>
        /// <param name="loadBalancingRules"> Object collection representing the load balancing rules Gets the provisioning. </param>
        /// <param name="probes"> Collection of probe objects used in the load balancer. </param>
        /// <param name="inboundNatRules"> Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules. </param>
        /// <param name="inboundNatPools"> Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules. </param>
        /// <param name="outboundRules"> The outbound rules. </param>
        /// <param name="resourceGuid"> The resource GUID property of the load balancer resource. </param>
        /// <param name="provisioningState"> The provisioning state of the load balancer resource. </param>
        internal LoadBalancerData(string id, string name, string type, string location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, LoadBalancerSku sku, string etag, IList<FrontendIPConfigurationData> frontendIPConfigurations, IList<BackendAddressPoolData> backendAddressPools, IList<LoadBalancingRuleData> loadBalancingRules, IList<ProbeData> probes, IList<InboundNatRuleData> inboundNatRules, IList<InboundNatPool> inboundNatPools, IList<OutboundRuleData> outboundRules, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Sku = sku;
            Etag = etag;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPools = backendAddressPools;
            LoadBalancingRules = loadBalancingRules;
            Probes = probes;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundRules = outboundRules;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> The extended location of the load balancer. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The load balancer SKU. </summary>
        public LoadBalancerSku Sku { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Object representing the frontend IPs to be used for the load balancer. </summary>
        public IList<FrontendIPConfigurationData> FrontendIPConfigurations { get; }
        /// <summary> Collection of backend address pools used by a load balancer. </summary>
        public IList<BackendAddressPoolData> BackendAddressPools { get; }
        /// <summary> Object collection representing the load balancing rules Gets the provisioning. </summary>
        public IList<LoadBalancingRuleData> LoadBalancingRules { get; }
        /// <summary> Collection of probe objects used in the load balancer. </summary>
        public IList<ProbeData> Probes { get; }
        /// <summary> Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules. </summary>
        public IList<InboundNatRuleData> InboundNatRules { get; }
        /// <summary> Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules. </summary>
        public IList<InboundNatPool> InboundNatPools { get; }
        /// <summary> The outbound rules. </summary>
        public IList<OutboundRuleData> OutboundRules { get; }
        /// <summary> The resource GUID property of the load balancer resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the load balancer resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}