// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Specification for an App Service Environment to use for this resource. </summary>
    public partial class HostingEnvironmentProfile
    {
        /// <summary> Initializes a new instance of HostingEnvironmentProfile. </summary>
        public HostingEnvironmentProfile()
        {
        }

        /// <summary> Initializes a new instance of HostingEnvironmentProfile. </summary>
        /// <param name="id"> Resource ID of the App Service Environment. </param>
        /// <param name="name"> Name of the App Service Environment. </param>
        /// <param name="type"> Resource type of the App Service Environment. </param>
        internal HostingEnvironmentProfile(string id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary> Resource ID of the App Service Environment. </summary>
        public string Id { get; set; }
        /// <summary> Name of the App Service Environment. </summary>
        public string Name { get; }
        /// <summary> Resource type of the App Service Environment. </summary>
        public string Type { get; }
    }
}
