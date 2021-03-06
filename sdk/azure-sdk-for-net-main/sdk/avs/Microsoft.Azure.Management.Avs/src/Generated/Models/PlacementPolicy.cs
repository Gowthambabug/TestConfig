// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A vSphere Distributed Resource Scheduler (DRS) placement policy
    /// </summary>
    public partial class PlacementPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PlacementPolicy class.
        /// </summary>
        public PlacementPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlacementPolicy class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="properties">placement policy properties</param>
        public PlacementPolicy(string id = default(string), string name = default(string), string type = default(string), PlacementPolicyProperties properties = default(PlacementPolicyProperties))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets placement policy properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PlacementPolicyProperties Properties { get; set; }

    }
}
