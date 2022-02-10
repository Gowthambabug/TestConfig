// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The object that represents all properties related to capacity enforcement on an account. </summary>
    public partial class Capacity
    {
        /// <summary> Initializes a new instance of Capacity. </summary>
        public Capacity()
        {
        }

        /// <summary> Initializes a new instance of Capacity. </summary>
        /// <param name="totalThroughputLimit"> The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no limits on provisioning of throughput. </param>
        internal Capacity(int? totalThroughputLimit)
        {
            TotalThroughputLimit = totalThroughputLimit;
        }

        /// <summary> The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no limits on provisioning of throughput. </summary>
        public int? TotalThroughputLimit { get; set; }
    }
}