// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of resource groups. </summary>
    internal partial class ResourceListResult
    {
        /// <summary> Initializes a new instance of ResourceListResult. </summary>
        internal ResourceListResult()
        {
            Value = new ChangeTrackingList<GenericResourceData>();
        }

        /// <summary> Initializes a new instance of ResourceListResult. </summary>
        /// <param name="value"> An array of resources. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ResourceListResult(IReadOnlyList<GenericResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of resources. </summary>
        public IReadOnlyList<GenericResourceData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}