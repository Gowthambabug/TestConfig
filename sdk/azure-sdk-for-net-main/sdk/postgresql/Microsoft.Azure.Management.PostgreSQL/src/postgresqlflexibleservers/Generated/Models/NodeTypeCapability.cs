// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// node type capability
    /// </summary>
    public partial class NodeTypeCapability
    {
        /// <summary>
        /// Initializes a new instance of the NodeTypeCapability class.
        /// </summary>
        public NodeTypeCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeTypeCapability class.
        /// </summary>
        /// <param name="name">note type name</param>
        /// <param name="nodeType">note type</param>
        /// <param name="status">The status</param>
        public NodeTypeCapability(string name = default(string), string nodeType = default(string), string status = default(string))
        {
            Name = name;
            NodeType = nodeType;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets note type name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets note type
        /// </summary>
        [JsonProperty(PropertyName = "nodeType")]
        public string NodeType { get; private set; }

        /// <summary>
        /// Gets the status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}