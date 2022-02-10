// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional information about Azure File Share backup item.
    /// </summary>
    public partial class AzureFileshareProtectedItemExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureFileshareProtectedItemExtendedInfo class.
        /// </summary>
        public AzureFileshareProtectedItemExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureFileshareProtectedItemExtendedInfo class.
        /// </summary>
        /// <param name="oldestRecoveryPoint">The oldest backup copy available
        /// for this item in the service.</param>
        /// <param name="recoveryPointCount">Number of available backup copies
        /// associated with this backup item.</param>
        /// <param name="policyState">Indicates consistency of policy object
        /// and policy applied to this backup item.</param>
        /// <param name="resourceState">Indicates the state of this resource.
        /// Possible values are from enum ResourceState {Invalid, Active,
        /// SoftDeleted, Deleted}</param>
        /// <param name="resourceStateSyncTime">The resource state sync time
        /// for this backup item.</param>
        public AzureFileshareProtectedItemExtendedInfo(System.DateTime? oldestRecoveryPoint = default(System.DateTime?), int? recoveryPointCount = default(int?), string policyState = default(string), string resourceState = default(string), System.DateTime? resourceStateSyncTime = default(System.DateTime?))
        {
            OldestRecoveryPoint = oldestRecoveryPoint;
            RecoveryPointCount = recoveryPointCount;
            PolicyState = policyState;
            ResourceState = resourceState;
            ResourceStateSyncTime = resourceStateSyncTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the oldest backup copy available for this item in the
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "oldestRecoveryPoint")]
        public System.DateTime? OldestRecoveryPoint { get; set; }

        /// <summary>
        /// Gets or sets number of available backup copies associated with this
        /// backup item.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointCount")]
        public int? RecoveryPointCount { get; set; }

        /// <summary>
        /// Gets or sets indicates consistency of policy object and policy
        /// applied to this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "policyState")]
        public string PolicyState { get; set; }

        /// <summary>
        /// Gets indicates the state of this resource. Possible values are from
        /// enum ResourceState {Invalid, Active, SoftDeleted, Deleted}
        /// </summary>
        [JsonProperty(PropertyName = "resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets the resource state sync time for this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "resourceStateSyncTime")]
        public System.DateTime? ResourceStateSyncTime { get; private set; }

    }
}