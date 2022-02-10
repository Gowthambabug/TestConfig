// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SwaggerSpecification
    {
        /// <summary>
        /// Initializes a new instance of the SwaggerSpecification class.
        /// </summary>
        public SwaggerSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwaggerSpecification class.
        /// </summary>
        public SwaggerSpecification(IList<string> apiVersions = default(IList<string>), string swaggerSpecFolderUri = default(string))
        {
            ApiVersions = apiVersions;
            SwaggerSpecFolderUri = swaggerSpecFolderUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "swaggerSpecFolderUri")]
        public string SwaggerSpecFolderUri { get; set; }

    }
}