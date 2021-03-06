// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specification for using a Virtual Network.
    /// </summary>
    public partial class VirtualNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkProfile class.
        /// </summary>
        public VirtualNetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkProfile class.
        /// </summary>
        /// <param name="id">Resource id of the Virtual Network.</param>
        /// <param name="name">Name of the Virtual Network (read-only).</param>
        /// <param name="type">Resource type of the Virtual Network
        /// (read-only).</param>
        /// <param name="subnet">Subnet within the Virtual Network.</param>
        public VirtualNetworkProfile(string id, string name = default(string), string type = default(string), string subnet = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Subnet = subnet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource id of the Virtual Network.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets name of the Virtual Network (read-only).
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type of the Virtual Network (read-only).
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets subnet within the Virtual Network.
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string Subnet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
