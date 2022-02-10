// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The pricing tier (defines a CDN provider, feature list and rate) of the CDN profile. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        public Sku()
        {
        }

        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="name"> Name of the pricing tier. </param>
        internal Sku(SkuName? name)
        {
            Name = name;
        }

        /// <summary> Name of the pricing tier. </summary>
        public SkuName? Name { get; set; }
    }
}