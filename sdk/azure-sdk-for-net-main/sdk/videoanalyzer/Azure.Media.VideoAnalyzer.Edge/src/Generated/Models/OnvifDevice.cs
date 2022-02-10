// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The ONVIF device properties. </summary>
    public partial class OnvifDevice
    {
        /// <summary> Initializes a new instance of OnvifDevice. </summary>
        public OnvifDevice()
        {
            MediaProfiles = new ChangeTrackingList<MediaProfile>();
        }

        /// <summary> Initializes a new instance of OnvifDevice. </summary>
        /// <param name="hostname"> The hostname of the ONVIF device. </param>
        /// <param name="systemDateTime"> The system date and time of the ONVIF device. </param>
        /// <param name="dns"> The ONVIF device DNS properties. </param>
        /// <param name="mediaProfiles"> An array of of ONVIF media profiles supported by the ONVIF device. </param>
        internal OnvifDevice(OnvifHostName hostname, OnvifSystemDateTime systemDateTime, OnvifDns dns, IList<MediaProfile> mediaProfiles)
        {
            Hostname = hostname;
            SystemDateTime = systemDateTime;
            Dns = dns;
            MediaProfiles = mediaProfiles;
        }

        /// <summary> The hostname of the ONVIF device. </summary>
        public OnvifHostName Hostname { get; set; }
        /// <summary> The system date and time of the ONVIF device. </summary>
        public OnvifSystemDateTime SystemDateTime { get; set; }
        /// <summary> The ONVIF device DNS properties. </summary>
        public OnvifDns Dns { get; set; }
        /// <summary> An array of of ONVIF media profiles supported by the ONVIF device. </summary>
        public IList<MediaProfile> MediaProfiles { get; }
    }
}