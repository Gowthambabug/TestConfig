// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private link service proxy details. </summary>
    public partial class PrivateLinkServiceProxy
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceProxy. </summary>
        public PrivateLinkServiceProxy()
        {
            GroupConnectivityInformation = new ChangeTrackingList<GroupConnectivityInformation>();
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceProxy. </summary>
        /// <param name="id"> NRP resource ID. </param>
        /// <param name="remotePrivateLinkServiceConnectionState"> Remote private link service connection state. </param>
        /// <param name="remotePrivateEndpointConnection"> Remote private endpoint connection details. </param>
        /// <param name="groupConnectivityInformation"> Group connectivity information. </param>
        internal PrivateLinkServiceProxy(string id, PrivateLinkServiceConnectionState remotePrivateLinkServiceConnectionState, SubResource remotePrivateEndpointConnection, IList<GroupConnectivityInformation> groupConnectivityInformation)
        {
            Id = id;
            RemotePrivateLinkServiceConnectionState = remotePrivateLinkServiceConnectionState;
            RemotePrivateEndpointConnection = remotePrivateEndpointConnection;
            GroupConnectivityInformation = groupConnectivityInformation;
        }

        /// <summary> NRP resource ID. </summary>
        public string Id { get; set; }
        /// <summary> Remote private link service connection state. </summary>
        public PrivateLinkServiceConnectionState RemotePrivateLinkServiceConnectionState { get; set; }
        /// <summary> Remote private endpoint connection details. </summary>
        public SubResource RemotePrivateEndpointConnection { get; set; }
        /// <summary> Group connectivity information. </summary>
        public IList<GroupConnectivityInformation> GroupConnectivityInformation { get; }
    }
}
