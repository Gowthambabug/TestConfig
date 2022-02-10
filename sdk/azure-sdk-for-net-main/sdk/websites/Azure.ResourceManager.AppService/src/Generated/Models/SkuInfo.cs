// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> SKU discovery information. </summary>
    public partial class SkuInfo
    {
        /// <summary> Initializes a new instance of SkuInfo. </summary>
        internal SkuInfo()
        {
        }

        /// <summary> Initializes a new instance of SkuInfo. </summary>
        /// <param name="resourceType"> Resource type that this SKU applies to. </param>
        /// <param name="sku"> Name and tier of the SKU. </param>
        /// <param name="capacity"> Min, max, and default scale values of the SKU. </param>
        internal SkuInfo(string resourceType, SkuDescription sku, SkuCapacity capacity)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
        }

        /// <summary> Resource type that this SKU applies to. </summary>
        public string ResourceType { get; }
        /// <summary> Name and tier of the SKU. </summary>
        public SkuDescription Sku { get; }
        /// <summary> Min, max, and default scale values of the SKU. </summary>
        public SkuCapacity Capacity { get; }
    }
}