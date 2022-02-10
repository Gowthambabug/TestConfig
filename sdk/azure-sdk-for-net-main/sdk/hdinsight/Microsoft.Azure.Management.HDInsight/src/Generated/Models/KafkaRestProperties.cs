// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The kafka rest proxy configuration which contains AAD security group
    /// information.
    /// </summary>
    public partial class KafkaRestProperties
    {
        /// <summary>
        /// Initializes a new instance of the KafkaRestProperties class.
        /// </summary>
        public KafkaRestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KafkaRestProperties class.
        /// </summary>
        /// <param name="clientGroupInfo">The information of AAD security
        /// group.</param>
        /// <param name="configurationOverride">The configurations that need to
        /// be overriden.</param>
        public KafkaRestProperties(ClientGroupInfo clientGroupInfo = default(ClientGroupInfo), IDictionary<string, string> configurationOverride = default(IDictionary<string, string>))
        {
            ClientGroupInfo = clientGroupInfo;
            ConfigurationOverride = configurationOverride;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the information of AAD security group.
        /// </summary>
        [JsonProperty(PropertyName = "clientGroupInfo")]
        public ClientGroupInfo ClientGroupInfo { get; set; }

        /// <summary>
        /// Gets or sets the configurations that need to be overriden.
        /// </summary>
        [JsonProperty(PropertyName = "configurationOverride")]
        public IDictionary<string, string> ConfigurationOverride { get; set; }

    }
}