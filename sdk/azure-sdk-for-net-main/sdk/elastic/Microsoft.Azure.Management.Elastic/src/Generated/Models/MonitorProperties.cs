// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Elastic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties specific to the monitor resource.
    /// </summary>
    public partial class MonitorProperties
    {
        /// <summary>
        /// Initializes a new instance of the MonitorProperties class.
        /// </summary>
        public MonitorProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonitorProperties class.
        /// </summary>
        /// <param name="provisioningState">Provisioning state of the monitor
        /// resource. Possible values include: 'Accepted', 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled',
        /// 'Deleted', 'NotSpecified'</param>
        /// <param name="monitoringStatus">Flag specifying if the resource
        /// monitoring is enabled or disabled. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="elasticProperties">Elastic cloud properties.</param>
        /// <param name="userInfo">User information.</param>
        /// <param name="liftrResourceCategory">Possible values include:
        /// 'Unknown', 'MonitorLogs'</param>
        /// <param name="liftrResourcePreference">The priority of the
        /// resource.</param>
        public MonitorProperties(string provisioningState = default(string), string monitoringStatus = default(string), ElasticProperties elasticProperties = default(ElasticProperties), UserInfo userInfo = default(UserInfo), string liftrResourceCategory = default(string), int? liftrResourcePreference = default(int?))
        {
            ProvisioningState = provisioningState;
            MonitoringStatus = monitoringStatus;
            ElasticProperties = elasticProperties;
            UserInfo = userInfo;
            LiftrResourceCategory = liftrResourceCategory;
            LiftrResourcePreference = liftrResourcePreference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provisioning state of the monitor resource. Possible
        /// values include: 'Accepted', 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed', 'Canceled', 'Deleted', 'NotSpecified'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets flag specifying if the resource monitoring is enabled
        /// or disabled. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "monitoringStatus")]
        public string MonitoringStatus { get; set; }

        /// <summary>
        /// Gets or sets elastic cloud properties.
        /// </summary>
        [JsonProperty(PropertyName = "elasticProperties")]
        public ElasticProperties ElasticProperties { get; set; }

        /// <summary>
        /// Gets or sets user information.
        /// </summary>
        [JsonProperty(PropertyName = "userInfo")]
        public UserInfo UserInfo { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Unknown', 'MonitorLogs'
        /// </summary>
        [JsonProperty(PropertyName = "liftrResourceCategory")]
        public string LiftrResourceCategory { get; set; }

        /// <summary>
        /// Gets the priority of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "liftrResourcePreference")]
        public int? LiftrResourcePreference { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserInfo != null)
            {
                UserInfo.Validate();
            }
        }
    }
}