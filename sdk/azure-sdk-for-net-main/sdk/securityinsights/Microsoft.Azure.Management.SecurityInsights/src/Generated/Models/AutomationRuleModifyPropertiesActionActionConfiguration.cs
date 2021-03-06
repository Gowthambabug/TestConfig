// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration of the modify properties automation rule action
    /// </summary>
    public partial class AutomationRuleModifyPropertiesActionActionConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AutomationRuleModifyPropertiesActionActionConfiguration class.
        /// </summary>
        public AutomationRuleModifyPropertiesActionActionConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AutomationRuleModifyPropertiesActionActionConfiguration class.
        /// </summary>
        /// <param name="classification">The reason the incident was closed.
        /// Possible values include: 'Undetermined', 'TruePositive',
        /// 'BenignPositive', 'FalsePositive'</param>
        /// <param name="classificationComment">Describes the reason the
        /// incident was closed</param>
        /// <param name="classificationReason">The classification reason the
        /// incident was closed with. Possible values include:
        /// 'SuspiciousActivity', 'SuspiciousButExpected',
        /// 'IncorrectAlertLogic', 'InaccurateData'</param>
        /// <param name="labels">List of labels to add to the incident</param>
        /// <param name="owner">Describes a user that the incident is assigned
        /// to</param>
        /// <param name="severity">The severity of the incident. Possible
        /// values include: 'High', 'Medium', 'Low', 'Informational'</param>
        /// <param name="status">The status of the incident. Possible values
        /// include: 'New', 'Active', 'Closed'</param>
        public AutomationRuleModifyPropertiesActionActionConfiguration(string classification = default(string), string classificationComment = default(string), string classificationReason = default(string), IList<IncidentLabel> labels = default(IList<IncidentLabel>), IncidentOwnerInfo owner = default(IncidentOwnerInfo), string severity = default(string), string status = default(string))
        {
            Classification = classification;
            ClassificationComment = classificationComment;
            ClassificationReason = classificationReason;
            Labels = labels;
            Owner = owner;
            Severity = severity;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reason the incident was closed. Possible values
        /// include: 'Undetermined', 'TruePositive', 'BenignPositive',
        /// 'FalsePositive'
        /// </summary>
        [JsonProperty(PropertyName = "classification")]
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets describes the reason the incident was closed
        /// </summary>
        [JsonProperty(PropertyName = "classificationComment")]
        public string ClassificationComment { get; set; }

        /// <summary>
        /// Gets or sets the classification reason the incident was closed
        /// with. Possible values include: 'SuspiciousActivity',
        /// 'SuspiciousButExpected', 'IncorrectAlertLogic', 'InaccurateData'
        /// </summary>
        [JsonProperty(PropertyName = "classificationReason")]
        public string ClassificationReason { get; set; }

        /// <summary>
        /// Gets or sets list of labels to add to the incident
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public IList<IncidentLabel> Labels { get; set; }

        /// <summary>
        /// Gets or sets describes a user that the incident is assigned to
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public IncidentOwnerInfo Owner { get; set; }

        /// <summary>
        /// Gets or sets the severity of the incident. Possible values include:
        /// 'High', 'Medium', 'Low', 'Informational'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the status of the incident. Possible values include:
        /// 'New', 'Active', 'Closed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
