// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> A condition for the delivery rule. </summary>
    public partial class DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleCondition. </summary>
        public DeliveryRuleCondition()
        {
        }

        /// <summary> Initializes a new instance of DeliveryRuleCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        internal DeliveryRuleCondition(MatchVariable name)
        {
            Name = name;
        }

        /// <summary> The name of the condition for the delivery rule. </summary>
        internal MatchVariable Name { get; set; }
    }
}
