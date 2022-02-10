// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Node placement configuration for a pool.
    /// </summary>
    /// <remarks>
    /// For regional placement, nodes in the pool will be allocated in the same
    /// region. For zonal placement, nodes in the pool will be spread across
    /// different zones with best effort balancing.
    /// </remarks>
    public partial class NodePlacementConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the NodePlacementConfiguration class.
        /// </summary>
        public NodePlacementConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodePlacementConfiguration class.
        /// </summary>
        /// <param name="policy">Node placement Policy type on Batch
        /// Pools.</param>
        public NodePlacementConfiguration(NodePlacementPolicyType? policy = default(NodePlacementPolicyType?))
        {
            Policy = policy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets node placement Policy type on Batch Pools.
        /// </summary>
        /// <remarks>
        /// Allocation policy used by Batch Service to provision the nodes. If
        /// not specified, Batch will use the regional policy. Possible values
        /// include: 'regional', 'zonal'
        /// </remarks>
        [JsonProperty(PropertyName = "policy")]
        public NodePlacementPolicyType? Policy { get; set; }

    }
}