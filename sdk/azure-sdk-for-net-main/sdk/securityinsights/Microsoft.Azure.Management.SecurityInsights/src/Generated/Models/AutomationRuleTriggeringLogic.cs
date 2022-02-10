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
    /// Describes automation rule triggering logic
    /// </summary>
    public partial class AutomationRuleTriggeringLogic
    {
        /// <summary>
        /// Initializes a new instance of the AutomationRuleTriggeringLogic
        /// class.
        /// </summary>
        public AutomationRuleTriggeringLogic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationRuleTriggeringLogic
        /// class.
        /// </summary>
        /// <param name="isEnabled">Determines whether the automation rule is
        /// enabled or disabled.</param>
        /// <param name="expirationTimeUtc">Determines when the automation rule
        /// should automatically expire and be disabled.</param>
        /// <param name="conditions">The conditions to evaluate to determine if
        /// the automation rule should be triggered on a given object</param>
        public AutomationRuleTriggeringLogic(bool isEnabled, System.DateTime? expirationTimeUtc = default(System.DateTime?), IList<AutomationRuleCondition> conditions = default(IList<AutomationRuleCondition>))
        {
            IsEnabled = isEnabled;
            ExpirationTimeUtc = expirationTimeUtc;
            Conditions = conditions;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for AutomationRuleTriggeringLogic class.
        /// </summary>
        static AutomationRuleTriggeringLogic()
        {
            TriggersOn = "Incidents";
            TriggersWhen = "Created";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets determines whether the automation rule is enabled or
        /// disabled.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets determines when the automation rule should
        /// automatically expire and be disabled.
        /// </summary>
        [JsonProperty(PropertyName = "expirationTimeUtc")]
        public System.DateTime? ExpirationTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the conditions to evaluate to determine if the
        /// automation rule should be triggered on a given object
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<AutomationRuleCondition> Conditions { get; set; }

        /// <summary>
        /// The type of object the automation rule triggers on
        /// </summary>
        [JsonProperty(PropertyName = "triggersOn")]
        public static string TriggersOn { get; private set; }

        /// <summary>
        /// The type of event the automation rule triggers on
        /// </summary>
        [JsonProperty(PropertyName = "triggersWhen")]
        public static string TriggersWhen { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}