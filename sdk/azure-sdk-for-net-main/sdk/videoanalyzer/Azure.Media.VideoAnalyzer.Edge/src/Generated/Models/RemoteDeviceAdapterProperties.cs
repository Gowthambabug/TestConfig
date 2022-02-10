// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Remote device adapter properties. </summary>
    public partial class RemoteDeviceAdapterProperties
    {
        /// <summary> Initializes a new instance of RemoteDeviceAdapterProperties. </summary>
        /// <param name="target"> The IoT device to which this remote device will connect. </param>
        /// <param name="iotHubDeviceConnection"> Information that enables communication between the IoT Hub and the IoT device - allowing this edge module to act as a transparent gateway between the two. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> or <paramref name="iotHubDeviceConnection"/> is null. </exception>
        public RemoteDeviceAdapterProperties(RemoteDeviceAdapterTarget target, IotHubDeviceConnection iotHubDeviceConnection)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }
            if (iotHubDeviceConnection == null)
            {
                throw new ArgumentNullException(nameof(iotHubDeviceConnection));
            }

            Target = target;
            IotHubDeviceConnection = iotHubDeviceConnection;
        }

        /// <summary> Initializes a new instance of RemoteDeviceAdapterProperties. </summary>
        /// <param name="description"> An optional description for the remote device adapter. </param>
        /// <param name="target"> The IoT device to which this remote device will connect. </param>
        /// <param name="iotHubDeviceConnection"> Information that enables communication between the IoT Hub and the IoT device - allowing this edge module to act as a transparent gateway between the two. </param>
        internal RemoteDeviceAdapterProperties(string description, RemoteDeviceAdapterTarget target, IotHubDeviceConnection iotHubDeviceConnection)
        {
            Description = description;
            Target = target;
            IotHubDeviceConnection = iotHubDeviceConnection;
        }

        /// <summary> An optional description for the remote device adapter. </summary>
        public string Description { get; set; }
        /// <summary> The IoT device to which this remote device will connect. </summary>
        public RemoteDeviceAdapterTarget Target { get; set; }
        /// <summary> Information that enables communication between the IoT Hub and the IoT device - allowing this edge module to act as a transparent gateway between the two. </summary>
        public IotHubDeviceConnection IotHubDeviceConnection { get; set; }
    }
}