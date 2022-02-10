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
    using System.Linq;

    /// <summary>
    /// Describes an automation rule action
    /// </summary>
    public partial class AutomationRuleAction
    {
        /// <summary>
        /// Initializes a new instance of the AutomationRuleAction class.
        /// </summary>
        public AutomationRuleAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationRuleAction class.
        /// </summary>
        /// <param name="order">The order of execution of the automation rule
        /// action</param>
        public AutomationRuleAction(int order)
        {
            Order = order;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the order of execution of the automation rule action
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public int Order { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}