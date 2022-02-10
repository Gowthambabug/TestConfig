// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the url signing action for the delivery rule. </summary>
    public partial class UrlSigningAction : DeliveryRuleActionAutoGenerated
    {
        /// <summary> Initializes a new instance of UrlSigningAction. </summary>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public UrlSigningAction(UrlSigningActionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = DeliveryRuleAction.UrlSigning;
        }

        /// <summary> Initializes a new instance of UrlSigningAction. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        internal UrlSigningAction(DeliveryRuleAction name, UrlSigningActionParameters parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public UrlSigningActionParameters Parameters { get; set; }
    }
}