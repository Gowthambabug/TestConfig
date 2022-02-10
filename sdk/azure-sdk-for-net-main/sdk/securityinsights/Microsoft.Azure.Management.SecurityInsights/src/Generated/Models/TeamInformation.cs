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
    /// Describes team information
    /// </summary>
    public partial class TeamInformation
    {
        /// <summary>
        /// Initializes a new instance of the TeamInformation class.
        /// </summary>
        public TeamInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamInformation class.
        /// </summary>
        /// <param name="teamId">Team ID</param>
        /// <param name="primaryChannelUrl">The primary channel URL of the
        /// team</param>
        /// <param name="teamCreationTimeUtc">The time the team was
        /// created</param>
        /// <param name="name">The name of the team</param>
        /// <param name="description">The description of the team</param>
        public TeamInformation(string teamId = default(string), string primaryChannelUrl = default(string), System.DateTime? teamCreationTimeUtc = default(System.DateTime?), string name = default(string), string description = default(string))
        {
            TeamId = teamId;
            PrimaryChannelUrl = primaryChannelUrl;
            TeamCreationTimeUtc = teamCreationTimeUtc;
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets team ID
        /// </summary>
        [JsonProperty(PropertyName = "teamId")]
        public string TeamId { get; private set; }

        /// <summary>
        /// Gets the primary channel URL of the team
        /// </summary>
        [JsonProperty(PropertyName = "primaryChannelUrl")]
        public string PrimaryChannelUrl { get; private set; }

        /// <summary>
        /// Gets the time the team was created
        /// </summary>
        [JsonProperty(PropertyName = "teamCreationTimeUtc")]
        public System.DateTime? TeamCreationTimeUtc { get; private set; }

        /// <summary>
        /// Gets the name of the team
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the description of the team
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

    }
}