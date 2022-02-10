// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Describes an available sku.&quot;. </summary>
    public partial class Sku
    {
        /// <summary> Initializes a new instance of Sku. </summary>
        internal Sku()
        {
        }

        /// <summary> Initializes a new instance of Sku. </summary>
        /// <param name="resourceType"> The resource type that this object applies to. </param>
        /// <param name="skuValue"> The exact set of keys that define this sku. </param>
        /// <param name="capacity"> Specifies the unit of the resource. </param>
        internal Sku(string resourceType, WebPubSubSku skuValue, SkuCapacity capacity)
        {
            ResourceType = resourceType;
            SkuValue = skuValue;
            Capacity = capacity;
        }

        /// <summary> The resource type that this object applies to. </summary>
        public string ResourceType { get; }
        /// <summary> The exact set of keys that define this sku. </summary>
        public WebPubSubSku SkuValue { get; }
        /// <summary> Specifies the unit of the resource. </summary>
        public SkuCapacity Capacity { get; }
    }
}