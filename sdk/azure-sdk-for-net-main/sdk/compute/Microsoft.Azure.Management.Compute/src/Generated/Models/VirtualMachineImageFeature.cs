// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies additional capabilities supported by the image
    /// </summary>
    public partial class VirtualMachineImageFeature
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageFeature class.
        /// </summary>
        public VirtualMachineImageFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineImageFeature class.
        /// </summary>
        /// <param name="name">The name of the feature.</param>
        /// <param name="value">The corresponding value for the
        /// feature.</param>
        public VirtualMachineImageFeature(string name = default(string), string value = default(string))
        {
            Name = name;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the corresponding value for the feature.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}