// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Chaos.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Model that represents a branch in the step.
    /// </summary>
    public partial class Branch
    {
        /// <summary>
        /// Initializes a new instance of the Branch class.
        /// </summary>
        public Branch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Branch class.
        /// </summary>
        /// <param name="name">String of the branch name.</param>
        /// <param name="actions">List of actions.</param>
        public Branch(string name, IList<Action> actions)
        {
            Name = name;
            Actions = actions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string of the branch name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of actions.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<Action> Actions { get; set; }

    }
}