// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Deployment settings payload
    /// </summary>
    public partial class DeploymentSettings
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentSettings class.
        /// </summary>
        public DeploymentSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentSettings class.
        /// </summary>
        /// <param name="resourceRequests">The requested resource quantity for
        /// required CPU and Memory. It is recommended that using this field to
        /// represent the required CPU and Memory, the old field cpu and
        /// memoryInGB will be deprecated later.</param>
        /// <param name="environmentVariables">Collection of environment
        /// variables</param>
        /// <param name="addonConfigs">Collection of addons</param>
        public DeploymentSettings(ResourceRequests resourceRequests = default(ResourceRequests), IDictionary<string, string> environmentVariables = default(IDictionary<string, string>), IDictionary<string, IDictionary<string, object>> addonConfigs = default(IDictionary<string, IDictionary<string, object>>), ContainerProbeSettings containerProbeSettings = default(ContainerProbeSettings))
        {
            ResourceRequests = resourceRequests;
            EnvironmentVariables = environmentVariables;
            AddonConfigs = addonConfigs;
            ContainerProbeSettings = containerProbeSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the requested resource quantity for required CPU and
        /// Memory. It is recommended that using this field to represent the
        /// required CPU and Memory, the old field cpu and memoryInGB will be
        /// deprecated later.
        /// </summary>
        [JsonProperty(PropertyName = "resourceRequests")]
        public ResourceRequests ResourceRequests { get; set; }

        /// <summary>
        /// Gets or sets collection of environment variables
        /// </summary>
        [JsonProperty(PropertyName = "environmentVariables")]
        public IDictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets collection of addons
        /// </summary>
        [JsonProperty(PropertyName = "addonConfigs")]
        public IDictionary<string, IDictionary<string, object>> AddonConfigs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "containerProbeSettings")]
        public ContainerProbeSettings ContainerProbeSettings { get; set; }

    }
}
