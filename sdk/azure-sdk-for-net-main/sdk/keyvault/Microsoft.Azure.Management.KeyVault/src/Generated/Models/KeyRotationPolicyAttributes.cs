// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class KeyRotationPolicyAttributes
    {
        /// <summary>
        /// Initializes a new instance of the KeyRotationPolicyAttributes
        /// class.
        /// </summary>
        public KeyRotationPolicyAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyRotationPolicyAttributes
        /// class.
        /// </summary>
        /// <param name="created">Creation time in seconds since
        /// 1970-01-01T00:00:00Z.</param>
        /// <param name="updated">Last updated time in seconds since
        /// 1970-01-01T00:00:00Z.</param>
        /// <param name="expiryTime">The expiration time for the new key
        /// version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.</param>
        public KeyRotationPolicyAttributes(long? created = default(long?), long? updated = default(long?), string expiryTime = default(string))
        {
            Created = created;
            Updated = updated;
            ExpiryTime = expiryTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets creation time in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public long? Created { get; private set; }

        /// <summary>
        /// Gets last updated time in seconds since 1970-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public long? Updated { get; private set; }

        /// <summary>
        /// Gets or sets the expiration time for the new key version. It should
        /// be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [JsonProperty(PropertyName = "expiryTime")]
        public string ExpiryTime { get; set; }

    }
}