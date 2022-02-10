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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The private link configuration.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateLinkConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkConfiguration class.
        /// </summary>
        public PrivateLinkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkConfiguration class.
        /// </summary>
        /// <param name="name">The name of private link configuration.</param>
        /// <param name="groupId">The HDInsight private linkable sub-resource
        /// name to apply the private link configuration to. For example,
        /// 'headnode', 'gateway', 'edgenode'.</param>
        /// <param name="ipConfigurations">The IP configurations for the
        /// private link service.</param>
        /// <param name="id">The private link configuration id.</param>
        /// <param name="type">The type of the private link
        /// configuration.</param>
        /// <param name="provisioningState">The private link configuration
        /// provisioning state, which only appears in the response. Possible
        /// values include: 'InProgress', 'Failed', 'Succeeded', 'Canceled',
        /// 'Deleting'</param>
        public PrivateLinkConfiguration(string name, string groupId, IList<IPConfiguration> ipConfigurations, string id = default(string), string type = default(string), string provisioningState = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            GroupId = groupId;
            ProvisioningState = provisioningState;
            IpConfigurations = ipConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the private link configuration id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the name of private link configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the type of the private link configuration.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the HDInsight private linkable sub-resource name to
        /// apply the private link configuration to. For example, 'headnode',
        /// 'gateway', 'edgenode'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets the private link configuration provisioning state, which only
        /// appears in the response. Possible values include: 'InProgress',
        /// 'Failed', 'Succeeded', 'Canceled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the IP configurations for the private link service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<IPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (GroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupId");
            }
            if (IpConfigurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IpConfigurations");
            }
            if (IpConfigurations != null)
            {
                foreach (var element in IpConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}