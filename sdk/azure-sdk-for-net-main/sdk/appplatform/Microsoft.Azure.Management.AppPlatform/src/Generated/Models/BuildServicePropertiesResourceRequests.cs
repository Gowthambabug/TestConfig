// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The runtime resource configuration of this build service.
    /// </summary>
    public partial class BuildServicePropertiesResourceRequests
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BuildServicePropertiesResourceRequests class.
        /// </summary>
        public BuildServicePropertiesResourceRequests()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BuildServicePropertiesResourceRequests class.
        /// </summary>
        /// <param name="cpu">vCPU allocated to the entire build service node
        /// pool.</param>
        /// <param name="memory">Memory allocated to the entire build service
        /// node pool.</param>
        public BuildServicePropertiesResourceRequests(string cpu = default(string), string memory = default(string))
        {
            Cpu = cpu;
            Memory = memory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets vCPU allocated to the entire build service node pool.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public string Cpu { get; private set; }

        /// <summary>
        /// Gets memory allocated to the entire build service node pool.
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public string Memory { get; private set; }

    }
}