// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VpnServerConfiguration data model. </summary>
    public partial class VpnServerConfigurationData : Resource
    {
        /// <summary> Initializes a new instance of VpnServerConfigurationData. </summary>
        public VpnServerConfigurationData()
        {
            VpnProtocols = new ChangeTrackingList<VpnGatewayTunnelingProtocol>();
            VpnAuthenticationTypes = new ChangeTrackingList<VpnAuthenticationType>();
            VpnClientRootCertificates = new ChangeTrackingList<VpnServerConfigVpnClientRootCertificate>();
            VpnClientRevokedCertificates = new ChangeTrackingList<VpnServerConfigVpnClientRevokedCertificate>();
            RadiusServerRootCertificates = new ChangeTrackingList<VpnServerConfigRadiusServerRootCertificate>();
            RadiusClientRootCertificates = new ChangeTrackingList<VpnServerConfigRadiusClientRootCertificate>();
            VpnClientIpsecPolicies = new ChangeTrackingList<IpsecPolicy>();
            RadiusServers = new ChangeTrackingList<RadiusServer>();
            P2SVpnGateways = new ChangeTrackingList<P2SVpnGatewayData>();
        }

        /// <summary> Initializes a new instance of VpnServerConfigurationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="namePropertiesName"> The name of the VpnServerConfiguration that is unique within a resource group. </param>
        /// <param name="vpnProtocols"> VPN protocols for the VpnServerConfiguration. </param>
        /// <param name="vpnAuthenticationTypes"> VPN authentication types for the VpnServerConfiguration. </param>
        /// <param name="vpnClientRootCertificates"> VPN client root certificate of VpnServerConfiguration. </param>
        /// <param name="vpnClientRevokedCertificates"> VPN client revoked certificate of VpnServerConfiguration. </param>
        /// <param name="radiusServerRootCertificates"> Radius Server root certificate of VpnServerConfiguration. </param>
        /// <param name="radiusClientRootCertificates"> Radius client root certificate of VpnServerConfiguration. </param>
        /// <param name="vpnClientIpsecPolicies"> VpnClientIpsecPolicies for VpnServerConfiguration. </param>
        /// <param name="radiusServerAddress"> The radius server address property of the VpnServerConfiguration resource for point to site client connection. </param>
        /// <param name="radiusServerSecret"> The radius secret property of the VpnServerConfiguration resource for point to site client connection. </param>
        /// <param name="radiusServers"> Multiple Radius Server configuration for VpnServerConfiguration. </param>
        /// <param name="aadAuthenticationParameters"> The set of aad vpn authentication parameters. </param>
        /// <param name="provisioningState"> The provisioning state of the VpnServerConfiguration resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        /// <param name="p2SVpnGateways"> List of references to P2SVpnGateways. </param>
        /// <param name="etagPropertiesEtag"> A unique read-only string that changes whenever the resource is updated. </param>
        internal VpnServerConfigurationData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, string namePropertiesName, IList<VpnGatewayTunnelingProtocol> vpnProtocols, IList<VpnAuthenticationType> vpnAuthenticationTypes, IList<VpnServerConfigVpnClientRootCertificate> vpnClientRootCertificates, IList<VpnServerConfigVpnClientRevokedCertificate> vpnClientRevokedCertificates, IList<VpnServerConfigRadiusServerRootCertificate> radiusServerRootCertificates, IList<VpnServerConfigRadiusClientRootCertificate> radiusClientRootCertificates, IList<IpsecPolicy> vpnClientIpsecPolicies, string radiusServerAddress, string radiusServerSecret, IList<RadiusServer> radiusServers, AadAuthenticationParameters aadAuthenticationParameters, string provisioningState, IReadOnlyList<P2SVpnGatewayData> p2SVpnGateways, string etagPropertiesEtag) : base(id, name, type, location, tags)
        {
            Etag = etag;
            NamePropertiesName = namePropertiesName;
            VpnProtocols = vpnProtocols;
            VpnAuthenticationTypes = vpnAuthenticationTypes;
            VpnClientRootCertificates = vpnClientRootCertificates;
            VpnClientRevokedCertificates = vpnClientRevokedCertificates;
            RadiusServerRootCertificates = radiusServerRootCertificates;
            RadiusClientRootCertificates = radiusClientRootCertificates;
            VpnClientIpsecPolicies = vpnClientIpsecPolicies;
            RadiusServerAddress = radiusServerAddress;
            RadiusServerSecret = radiusServerSecret;
            RadiusServers = radiusServers;
            AadAuthenticationParameters = aadAuthenticationParameters;
            ProvisioningState = provisioningState;
            P2SVpnGateways = p2SVpnGateways;
            EtagPropertiesEtag = etagPropertiesEtag;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The name of the VpnServerConfiguration that is unique within a resource group. </summary>
        public string NamePropertiesName { get; set; }
        /// <summary> VPN protocols for the VpnServerConfiguration. </summary>
        public IList<VpnGatewayTunnelingProtocol> VpnProtocols { get; }
        /// <summary> VPN authentication types for the VpnServerConfiguration. </summary>
        public IList<VpnAuthenticationType> VpnAuthenticationTypes { get; }
        /// <summary> VPN client root certificate of VpnServerConfiguration. </summary>
        public IList<VpnServerConfigVpnClientRootCertificate> VpnClientRootCertificates { get; }
        /// <summary> VPN client revoked certificate of VpnServerConfiguration. </summary>
        public IList<VpnServerConfigVpnClientRevokedCertificate> VpnClientRevokedCertificates { get; }
        /// <summary> Radius Server root certificate of VpnServerConfiguration. </summary>
        public IList<VpnServerConfigRadiusServerRootCertificate> RadiusServerRootCertificates { get; }
        /// <summary> Radius client root certificate of VpnServerConfiguration. </summary>
        public IList<VpnServerConfigRadiusClientRootCertificate> RadiusClientRootCertificates { get; }
        /// <summary> VpnClientIpsecPolicies for VpnServerConfiguration. </summary>
        public IList<IpsecPolicy> VpnClientIpsecPolicies { get; }
        /// <summary> The radius server address property of the VpnServerConfiguration resource for point to site client connection. </summary>
        public string RadiusServerAddress { get; set; }
        /// <summary> The radius secret property of the VpnServerConfiguration resource for point to site client connection. </summary>
        public string RadiusServerSecret { get; set; }
        /// <summary> Multiple Radius Server configuration for VpnServerConfiguration. </summary>
        public IList<RadiusServer> RadiusServers { get; }
        /// <summary> The set of aad vpn authentication parameters. </summary>
        public AadAuthenticationParameters AadAuthenticationParameters { get; set; }
        /// <summary> The provisioning state of the VpnServerConfiguration resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; }
        /// <summary> List of references to P2SVpnGateways. </summary>
        public IReadOnlyList<P2SVpnGatewayData> P2SVpnGateways { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string EtagPropertiesEtag { get; }
    }
}