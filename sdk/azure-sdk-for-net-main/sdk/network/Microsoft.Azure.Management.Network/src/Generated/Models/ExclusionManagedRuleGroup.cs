// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a managed rule group to use for exclusion.
    /// </summary>
    public partial class ExclusionManagedRuleGroup
    {
        /// <summary>
        /// Initializes a new instance of the ExclusionManagedRuleGroup class.
        /// </summary>
        public ExclusionManagedRuleGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExclusionManagedRuleGroup class.
        /// </summary>
        /// <param name="ruleGroupName">The managed rule group for
        /// exclusion.</param>
        /// <param name="rules">List of rules that will be excluded. If none
        /// specified, all rules in the group will be excluded.</param>
        public ExclusionManagedRuleGroup(string ruleGroupName, IList<ExclusionManagedRule> rules = default(IList<ExclusionManagedRule>))
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the managed rule group for exclusion.
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroupName")]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Gets or sets list of rules that will be excluded. If none
        /// specified, all rules in the group will be excluded.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<ExclusionManagedRule> Rules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RuleGroupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleGroupName");
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
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
