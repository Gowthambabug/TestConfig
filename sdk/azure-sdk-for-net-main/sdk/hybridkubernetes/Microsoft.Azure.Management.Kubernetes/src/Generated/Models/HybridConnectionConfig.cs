// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Kubernetes.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the REP (rendezvous endpoint) and “Sender” access token.
    /// </summary>
    public partial class HybridConnectionConfig
    {
        /// <summary>
        /// Initializes a new instance of the HybridConnectionConfig class.
        /// </summary>
        public HybridConnectionConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridConnectionConfig class.
        /// </summary>
        /// <param name="expirationTime">Timestamp when this token will be
        /// expired.</param>
        /// <param name="hybridConnectionName">Name of the connection</param>
        /// <param name="relay">Name of the relay.</param>
        /// <param name="token">Sender access token</param>
        public HybridConnectionConfig(long? expirationTime = default(long?), string hybridConnectionName = default(string), string relay = default(string), string token = default(string))
        {
            ExpirationTime = expirationTime;
            HybridConnectionName = hybridConnectionName;
            Relay = relay;
            Token = token;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets timestamp when this token will be expired.
        /// </summary>
        [JsonProperty(PropertyName = "expirationTime")]
        public long? ExpirationTime { get; private set; }

        /// <summary>
        /// Gets name of the connection
        /// </summary>
        [JsonProperty(PropertyName = "hybridConnectionName")]
        public string HybridConnectionName { get; private set; }

        /// <summary>
        /// Gets name of the relay.
        /// </summary>
        [JsonProperty(PropertyName = "relay")]
        public string Relay { get; private set; }

        /// <summary>
        /// Gets sender access token
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; private set; }

    }
}