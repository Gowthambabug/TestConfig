// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines a managed rule group override setting. </summary>
    public partial class ManagedRuleOverride
    {
        /// <summary> Initializes a new instance of ManagedRuleOverride. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public ManagedRuleOverride(string ruleId)
        {
            if (ruleId == null)
            {
                throw new ArgumentNullException(nameof(ruleId));
            }

            RuleId = ruleId;
        }

        /// <summary> Initializes a new instance of ManagedRuleOverride. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <param name="enabledState"> Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified. </param>
        /// <param name="action"> Describes the override action to be applied when rule matches. </param>
        internal ManagedRuleOverride(string ruleId, ManagedRuleEnabledState? enabledState, ActionType? action)
        {
            RuleId = ruleId;
            EnabledState = enabledState;
            Action = action;
        }

        /// <summary> Identifier for the managed rule. </summary>
        public string RuleId { get; set; }
        /// <summary> Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified. </summary>
        public ManagedRuleEnabledState? EnabledState { get; set; }
        /// <summary> Describes the override action to be applied when rule matches. </summary>
        public ActionType? Action { get; set; }
    }
}