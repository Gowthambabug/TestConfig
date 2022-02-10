// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the ExpressRouteCircuitAuthorization data model. </summary>
    public partial class ExpressRouteCircuitAuthorizationData : SubResource
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitAuthorizationData. </summary>
        public ExpressRouteCircuitAuthorizationData()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitAuthorizationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="authorizationKey"> The authorization key. </param>
        /// <param name="authorizationUseStatus"> The authorization use status. </param>
        /// <param name="provisioningState"> The provisioning state of the authorization resource. </param>
        internal ExpressRouteCircuitAuthorizationData(string id, string name, string etag, string type, string authorizationKey, AuthorizationUseStatus? authorizationUseStatus, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            AuthorizationKey = authorizationKey;
            AuthorizationUseStatus = authorizationUseStatus;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> The authorization key. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> The authorization use status. </summary>
        public AuthorizationUseStatus? AuthorizationUseStatus { get; set; }
        /// <summary> The provisioning state of the authorization resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}