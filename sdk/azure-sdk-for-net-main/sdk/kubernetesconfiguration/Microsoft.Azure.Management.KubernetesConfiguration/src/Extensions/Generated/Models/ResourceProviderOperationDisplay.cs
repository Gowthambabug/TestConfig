// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Extensions.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Display metadata associated with the operation.
    /// </summary>
    public partial class ResourceProviderOperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperationDisplay
        /// class.
        /// </summary>
        public ResourceProviderOperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperationDisplay
        /// class.
        /// </summary>
        /// <param name="provider">Resource provider: Microsoft
        /// KubernetesConfiguration.</param>
        /// <param name="resource">Resource on which the operation is
        /// performed.</param>
        /// <param name="operation">Type of operation: get, read, delete,
        /// etc.</param>
        /// <param name="description">Description of this operation.</param>
        public ResourceProviderOperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource provider: Microsoft KubernetesConfiguration.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resource on which the operation is performed.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets type of operation: get, read, delete, etc.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets description of this operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
