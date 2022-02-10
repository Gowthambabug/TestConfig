// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Key encryption key properties
    /// </summary>
    public partial class KekIdentityProperties
    {
        /// <summary>
        /// Initializes a new instance of the KekIdentityProperties class.
        /// </summary>
        public KekIdentityProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KekIdentityProperties class.
        /// </summary>
        /// <param name="userAssignedIdentity">User assigned identity resource
        /// Id</param>
        /// <param name="useSystemAssignedIdentity">Boolean specifying whether
        /// to use system assigned identity or not</param>
        public KekIdentityProperties(string userAssignedIdentity = default(string), object useSystemAssignedIdentity = default(object))
        {
            UserAssignedIdentity = userAssignedIdentity;
            UseSystemAssignedIdentity = useSystemAssignedIdentity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user assigned identity resource Id
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentity")]
        public string UserAssignedIdentity { get; set; }

        /// <summary>
        /// Gets or sets boolean specifying whether to use system assigned
        /// identity or not
        /// </summary>
        [JsonProperty(PropertyName = "useSystemAssignedIdentity")]
        public object UseSystemAssignedIdentity { get; set; }

    }
}