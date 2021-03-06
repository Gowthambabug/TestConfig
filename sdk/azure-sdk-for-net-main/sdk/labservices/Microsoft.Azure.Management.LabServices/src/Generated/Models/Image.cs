// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Lab services virtual machine image
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Image : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        public Image()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the image.</param>
        /// <param name="enabledState">Is the image enabled. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="provisioningState">Current provisioning state of the
        /// image. Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed', 'Locked'</param>
        /// <param name="displayName">The image display name.</param>
        /// <param name="description">A description of the image.</param>
        /// <param name="iconUrl">URL of the image icon.</param>
        /// <param name="author">The image author.</param>
        /// <param name="osType">The OS Type of the image. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="plan">The ID of marketplace plan associated with the
        /// image (optional).</param>
        /// <param name="termsStatus">The status of image terms of use (enabled
        /// = accepted, disabled = not accepted). Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="offer">The ID of an offer associated with the
        /// image.</param>
        /// <param name="publisher">The ID of the publisher of the
        /// image.</param>
        /// <param name="sku">The image SKU.</param>
        /// <param name="version">The image version.</param>
        /// <param name="sharedGalleryId">The ID for the image in the shared
        /// gallery.</param>
        /// <param name="availableRegions">The available regions of the image
        /// in the shared gallery.</param>
        /// <param name="osState">The OS State of the image. Possible values
        /// include: 'Generalized', 'Specialized'</param>
        public Image(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), EnableState? enabledState = default(EnableState?), ProvisioningState? provisioningState = default(ProvisioningState?), string displayName = default(string), string description = default(string), string iconUrl = default(string), string author = default(string), OsType? osType = default(OsType?), string plan = default(string), EnableState? termsStatus = default(EnableState?), string offer = default(string), string publisher = default(string), string sku = default(string), string version = default(string), string sharedGalleryId = default(string), IList<string> availableRegions = default(IList<string>), OsState? osState = default(OsState?))
            : base(id, name, type)
        {
            SystemData = systemData;
            EnabledState = enabledState;
            ProvisioningState = provisioningState;
            DisplayName = displayName;
            Description = description;
            IconUrl = iconUrl;
            Author = author;
            OsType = osType;
            Plan = plan;
            TermsStatus = termsStatus;
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Version = version;
            SharedGalleryId = sharedGalleryId;
            AvailableRegions = availableRegions;
            OsState = osState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// image.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets is the image enabled. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public EnableState? EnabledState { get; set; }

        /// <summary>
        /// Gets current provisioning state of the image. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Locked'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the image display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets a description of the image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets URL of the image icon.
        /// </summary>
        [JsonProperty(PropertyName = "properties.iconUrl")]
        public string IconUrl { get; private set; }

        /// <summary>
        /// Gets the image author.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public string Author { get; private set; }

        /// <summary>
        /// Gets the OS Type of the image. Possible values include: 'Windows',
        /// 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OsType? OsType { get; private set; }

        /// <summary>
        /// Gets the ID of marketplace plan associated with the image
        /// (optional).
        /// </summary>
        [JsonProperty(PropertyName = "properties.plan")]
        public string Plan { get; private set; }

        /// <summary>
        /// Gets the status of image terms of use (enabled = accepted, disabled
        /// = not accepted). Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.termsStatus")]
        public EnableState? TermsStatus { get; private set; }

        /// <summary>
        /// Gets the ID of an offer associated with the image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offer")]
        public string Offer { get; private set; }

        /// <summary>
        /// Gets the ID of the publisher of the image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; private set; }

        /// <summary>
        /// Gets the image SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public string Sku { get; private set; }

        /// <summary>
        /// Gets the image version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the ID for the image in the shared gallery.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedGalleryId")]
        public string SharedGalleryId { get; private set; }

        /// <summary>
        /// Gets or sets the available regions of the image in the shared
        /// gallery.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availableRegions")]
        public IList<string> AvailableRegions { get; set; }

        /// <summary>
        /// Gets the OS State of the image. Possible values include:
        /// 'Generalized', 'Specialized'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osState")]
        public OsState? OsState { get; private set; }

    }
}
