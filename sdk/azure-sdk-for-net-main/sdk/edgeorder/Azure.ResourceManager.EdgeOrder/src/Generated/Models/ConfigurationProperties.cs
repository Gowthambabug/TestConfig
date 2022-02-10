// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Properties of configuration. </summary>
    internal partial class ConfigurationProperties : CommonProperties
    {
        /// <summary> Initializes a new instance of ConfigurationProperties. </summary>
        internal ConfigurationProperties()
        {
            Specifications = new ChangeTrackingList<ProductSpecification>();
        }

        /// <summary> Specifications of the configuration. </summary>
        public IReadOnlyList<ProductSpecification> Specifications { get; }
        /// <summary> Dimensions of the configuration. </summary>
        public ProductDimensions Dimensions { get; }
    }
}