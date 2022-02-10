// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a project.
    /// </summary>
    public partial class Project
    {
        /// <summary>
        /// Initializes a new instance of the Project class.
        /// </summary>
        public Project()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Project class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the project.</param>
        /// <param name="description">Gets or sets the description of the
        /// project.</param>
        /// <param name="settings">Gets or sets the project settings.</param>
        /// <param name="id">Gets the project id.</param>
        /// <param name="created">Gets the date this project was
        /// created.</param>
        /// <param name="lastModified">Gets the date this project was last
        /// modified.</param>
        /// <param name="thumbnailUri">Gets the thumbnail url representing the
        /// image. If VNET feature is enabled this will be a relative path to
        /// be used with GetArtifact, otherwise this will be an absolute URI to
        /// the resource.</param>
        /// <param name="drModeEnabled">Gets if the Disaster Recovery (DR) mode
        /// is on, indicating the project is temporarily read-only.</param>
        /// <param name="status">Gets the status of the project. Possible
        /// values include: 'Succeeded', 'Importing', 'Failed'</param>
        public Project(string name, string description, ProjectSettings settings, System.Guid id = default(System.Guid), System.DateTime created = default(System.DateTime), System.DateTime lastModified = default(System.DateTime), string thumbnailUri = default(string), bool? drModeEnabled = default(bool?), string status = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            Settings = settings;
            Created = created;
            LastModified = lastModified;
            ThumbnailUri = thumbnailUri;
            DrModeEnabled = drModeEnabled;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the project id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the project.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the project settings.
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public ProjectSettings Settings { get; set; }

        /// <summary>
        /// Gets the date this project was created.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets the date this project was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTime LastModified { get; private set; }

        /// <summary>
        /// Gets the thumbnail url representing the image. If VNET feature is
        /// enabled this will be a relative path to be used with GetArtifact,
        /// otherwise this will be an absolute URI to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailUri")]
        public string ThumbnailUri { get; private set; }

        /// <summary>
        /// Gets if the Disaster Recovery (DR) mode is on, indicating the
        /// project is temporarily read-only.
        /// </summary>
        [JsonProperty(PropertyName = "drModeEnabled")]
        public bool? DrModeEnabled { get; private set; }

        /// <summary>
        /// Gets the status of the project. Possible values include:
        /// 'Succeeded', 'Importing', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (Settings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Settings");
            }
        }
    }
}