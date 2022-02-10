// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Action
    {
        /// <summary>
        /// Initializes a new instance of the Action class.
        /// </summary>
        public Action()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Action class.
        /// </summary>
        /// <param name="type">The type of action. Possible values include:
        /// 'rotate', 'notify'</param>
        public Action(KeyRotationPolicyActionType? type = default(KeyRotationPolicyActionType?))
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of action. Possible values include: 'rotate',
        /// 'notify'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public KeyRotationPolicyActionType? Type { get; set; }

    }
}