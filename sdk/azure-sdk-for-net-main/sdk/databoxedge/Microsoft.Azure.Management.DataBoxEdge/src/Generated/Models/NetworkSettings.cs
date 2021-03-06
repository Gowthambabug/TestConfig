// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The network settings of a device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkSettings : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        public NetworkSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkSettings class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="systemData">NetworkSettings on ASE device</param>
        /// <param name="networkAdapters">The network adapter list on the
        /// device.</param>
        public NetworkSettings(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IList<NetworkAdapter> networkAdapters = default(IList<NetworkAdapter>))
            : base(id, name, type)
        {
            SystemData = systemData;
            NetworkAdapters = networkAdapters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets networkSettings on ASE device
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Gets the network adapter list on the device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAdapters")]
        public IList<NetworkAdapter> NetworkAdapters { get; private set; }

    }
}
