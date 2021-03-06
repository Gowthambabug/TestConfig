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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Image reference information. Used in the virtual machine profile.
    /// </summary>
    public partial class ImageReference
    {
        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        public ImageReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        /// <param name="id">Image resource ID</param>
        /// <param name="offer">The image offer if applicable.</param>
        /// <param name="publisher">The image publisher</param>
        /// <param name="sku">The image SKU</param>
        /// <param name="version">The image version specified on
        /// creation.</param>
        /// <param name="exactVersion">The actual version of the image after
        /// use.</param>
        public ImageReference(string id = default(string), string offer = default(string), string publisher = default(string), string sku = default(string), string version = default(string), string exactVersion = default(string))
        {
            Id = id;
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Version = version;
            ExactVersion = exactVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets image resource ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the image offer if applicable.
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets the image publisher
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the image SKU
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the image version specified on creation.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets the actual version of the image after use.
        /// </summary>
        [JsonProperty(PropertyName = "exactVersion")]
        public string ExactVersion { get; private set; }

    }
}
