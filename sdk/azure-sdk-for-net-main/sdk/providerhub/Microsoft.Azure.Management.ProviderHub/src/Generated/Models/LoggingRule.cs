// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LoggingRule
    {
        /// <summary>
        /// Initializes a new instance of the LoggingRule class.
        /// </summary>
        public LoggingRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoggingRule class.
        /// </summary>
        /// <param name="direction">Possible values include: 'None', 'Request',
        /// 'Response'</param>
        /// <param name="detailLevel">Possible values include: 'None',
        /// 'Body'</param>
        public LoggingRule(string action, string direction, string detailLevel, LoggingRuleHiddenPropertyPaths hiddenPropertyPaths = default(LoggingRuleHiddenPropertyPaths))
        {
            Action = action;
            Direction = direction;
            DetailLevel = detailLevel;
            HiddenPropertyPaths = hiddenPropertyPaths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Request', 'Response'
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Body'
        /// </summary>
        [JsonProperty(PropertyName = "detailLevel")]
        public string DetailLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hiddenPropertyPaths")]
        public LoggingRuleHiddenPropertyPaths HiddenPropertyPaths { get; set; }

    }
}