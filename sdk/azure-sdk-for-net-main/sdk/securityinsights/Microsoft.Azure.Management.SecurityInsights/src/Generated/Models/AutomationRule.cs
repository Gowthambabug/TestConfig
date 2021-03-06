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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an automation rule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AutomationRule : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the AutomationRule class.
        /// </summary>
        public AutomationRule()
        {
            TriggeringLogic = new AutomationRuleTriggeringLogic();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationRule class.
        /// </summary>
        /// <param name="displayName">The display name of the automation
        /// rule</param>
        /// <param name="order">The order of execution of the automation
        /// rule</param>
        /// <param name="triggeringLogic">The triggering logic of the
        /// automation rule</param>
        /// <param name="actions">The actions to execute when the automation
        /// rule is triggered</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="createdTimeUtc">The time the automation rule was
        /// created</param>
        /// <param name="lastModifiedTimeUtc">The last time the automation rule
        /// was updated</param>
        /// <param name="createdBy">Describes the client that created the
        /// automation rule</param>
        /// <param name="lastModifiedBy">Describes the client that last updated
        /// the automation rule</param>
        public AutomationRule(string displayName, int order, AutomationRuleTriggeringLogic triggeringLogic, IList<AutomationRuleAction> actions, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string etag = default(string), System.DateTime? createdTimeUtc = default(System.DateTime?), System.DateTime? lastModifiedTimeUtc = default(System.DateTime?), ClientInfo createdBy = default(ClientInfo), ClientInfo lastModifiedBy = default(ClientInfo))
            : base(id, name, type, systemData, etag)
        {
            DisplayName = displayName;
            Order = order;
            TriggeringLogic = triggeringLogic;
            Actions = actions;
            CreatedTimeUtc = createdTimeUtc;
            LastModifiedTimeUtc = lastModifiedTimeUtc;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the automation  rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the order of execution of the automation rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.order")]
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the triggering logic of the automation rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.triggeringLogic")]
        public AutomationRuleTriggeringLogic TriggeringLogic { get; set; }

        /// <summary>
        /// Gets or sets the actions to execute when the automation rule is
        /// triggered
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<AutomationRuleAction> Actions { get; set; }

        /// <summary>
        /// Gets the time the automation rule was created
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTimeUtc")]
        public System.DateTime? CreatedTimeUtc { get; private set; }

        /// <summary>
        /// Gets the last time the automation rule was updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTimeUtc")]
        public System.DateTime? LastModifiedTimeUtc { get; private set; }

        /// <summary>
        /// Gets describes the client that created the automation rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdBy")]
        public ClientInfo CreatedBy { get; private set; }

        /// <summary>
        /// Gets describes the client that last updated the automation rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedBy")]
        public ClientInfo LastModifiedBy { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (TriggeringLogic == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TriggeringLogic");
            }
            if (Actions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Actions");
            }
            if (TriggeringLogic != null)
            {
                TriggeringLogic.Validate();
            }
            if (Actions != null)
            {
                foreach (var element in Actions)
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
