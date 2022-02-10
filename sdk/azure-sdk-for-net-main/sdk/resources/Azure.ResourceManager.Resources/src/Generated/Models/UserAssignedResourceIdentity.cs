// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Represents the user assigned identity that is contained within the UserAssignedIdentities dictionary on ResourceIdentity. </summary>
    public partial class UserAssignedResourceIdentity
    {
        /// <summary> Initializes a new instance of UserAssignedResourceIdentity. </summary>
        public UserAssignedResourceIdentity()
        {
        }

        /// <summary> Initializes a new instance of UserAssignedResourceIdentity. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="tenantId"> The tenant id of user assigned identity. </param>
        internal UserAssignedResourceIdentity(string principalId, string tenantId)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The tenant id of user assigned identity. </summary>
        public string TenantId { get; }
    }
}