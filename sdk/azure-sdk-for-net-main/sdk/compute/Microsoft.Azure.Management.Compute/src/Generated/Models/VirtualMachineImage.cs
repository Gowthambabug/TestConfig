// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Image.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineImage : VirtualMachineImageResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineImage class.
        /// </summary>
        public VirtualMachineImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineImage class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="location">The supported Azure location of the
        /// resource.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="tags">Specifies the tags that are assigned to the
        /// virtual machine. For more information about using tags, see [Using
        /// tags to organize your Azure
        /// resources](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-using-tags.md).</param>
        /// <param name="extendedLocation">The extended location of the Virtual
        /// Machine.</param>
        /// <param name="hyperVGeneration">Possible values include: 'V1',
        /// 'V2'</param>
        /// <param name="disallowed">Specifies disallowed configuration for the
        /// VirtualMachine created from the image</param>
        public VirtualMachineImage(string name, string location, string id = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ExtendedLocation extendedLocation = default(ExtendedLocation), PurchasePlan plan = default(PurchasePlan), OSDiskImage osDiskImage = default(OSDiskImage), IList<DataDiskImage> dataDiskImages = default(IList<DataDiskImage>), AutomaticOSUpgradeProperties automaticOSUpgradeProperties = default(AutomaticOSUpgradeProperties), string hyperVGeneration = default(string), DisallowedConfiguration disallowed = default(DisallowedConfiguration), IList<VirtualMachineImageFeature> features = default(IList<VirtualMachineImageFeature>))
            : base(name, location, id, tags, extendedLocation)
        {
            Plan = plan;
            OsDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
            AutomaticOSUpgradeProperties = automaticOSUpgradeProperties;
            HyperVGeneration = hyperVGeneration;
            Disallowed = disallowed;
            Features = features;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.plan")]
        public PurchasePlan Plan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.osDiskImage")]
        public OSDiskImage OsDiskImage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataDiskImages")]
        public IList<DataDiskImage> DataDiskImages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.automaticOSUpgradeProperties")]
        public AutomaticOSUpgradeProperties AutomaticOSUpgradeProperties { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'V1', 'V2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// Gets or sets specifies disallowed configuration for the
        /// VirtualMachine created from the image
        /// </summary>
        [JsonProperty(PropertyName = "properties.disallowed")]
        public DisallowedConfiguration Disallowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.features")]
        public IList<VirtualMachineImageFeature> Features { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Plan != null)
            {
                Plan.Validate();
            }
            if (OsDiskImage != null)
            {
                OsDiskImage.Validate();
            }
            if (AutomaticOSUpgradeProperties != null)
            {
                AutomaticOSUpgradeProperties.Validate();
            }
        }
    }
}