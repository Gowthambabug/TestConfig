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
    /// The mapping of content type to a repo path.
    /// </summary>
    public partial class ContentPathMap
    {
        /// <summary>
        /// Initializes a new instance of the ContentPathMap class.
        /// </summary>
        public ContentPathMap()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentPathMap class.
        /// </summary>
        /// <param name="contentType">Content type. Possible values include:
        /// 'AnalyticRule', 'Workbook'</param>
        /// <param name="path">The path to the content.</param>
        public ContentPathMap(string contentType = default(string), string path = default(string))
        {
            ContentType = contentType;
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets content type. Possible values include: 'AnalyticRule',
        /// 'Workbook'
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the path to the content.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

    }
}
