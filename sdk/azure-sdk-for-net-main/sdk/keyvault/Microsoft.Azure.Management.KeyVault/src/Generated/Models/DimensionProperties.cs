// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Type of operation: get, read, delete, etc.
    /// </summary>
    public partial class DimensionProperties
    {
        /// <summary>
        /// Initializes a new instance of the DimensionProperties class.
        /// </summary>
        public DimensionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DimensionProperties class.
        /// </summary>
        /// <param name="name">Name of dimension.</param>
        /// <param name="displayName">Display name of dimension.</param>
        /// <param name="toBeExportedForShoebox">Property to specify whether
        /// the dimension should be exported for Shoebox.</param>
        public DimensionProperties(string name = default(string), string displayName = default(string), bool? toBeExportedForShoebox = default(bool?))
        {
            Name = name;
            DisplayName = displayName;
            ToBeExportedForShoebox = toBeExportedForShoebox;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of dimension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display name of dimension.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether the dimension should be
        /// exported for Shoebox.
        /// </summary>
        [JsonProperty(PropertyName = "toBeExportedForShoebox")]
        public bool? ToBeExportedForShoebox { get; set; }

    }
}