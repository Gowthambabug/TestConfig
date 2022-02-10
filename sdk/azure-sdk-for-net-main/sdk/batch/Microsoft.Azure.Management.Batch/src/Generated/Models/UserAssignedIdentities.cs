// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The list of associated user identities.
    /// </summary>
    public partial class UserAssignedIdentities
    {
        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentities class.
        /// </summary>
        public UserAssignedIdentities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserAssignedIdentities class.
        /// </summary>
        /// <param name="principalId">The principal id of user assigned
        /// identity.</param>
        /// <param name="clientId">The client id of user assigned
        /// identity.</param>
        public UserAssignedIdentities(string principalId = default(string), string clientId = default(string))
        {
            PrincipalId = principalId;
            ClientId = clientId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the client id of user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; private set; }

    }
}