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
    /// Required permissions for the connector
    /// </summary>
    public partial class RequiredPermissions
    {
        /// <summary>
        /// Initializes a new instance of the RequiredPermissions class.
        /// </summary>
        public RequiredPermissions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RequiredPermissions class.
        /// </summary>
        /// <param name="action">action permission</param>
        /// <param name="write">write permission</param>
        /// <param name="read">read permission</param>
        /// <param name="delete">delete permission</param>
        public RequiredPermissions(bool? action = default(bool?), bool? write = default(bool?), bool? read = default(bool?), bool? delete = default(bool?))
        {
            Action = action;
            Write = write;
            Read = read;
            Delete = delete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets action permission
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public bool? Action { get; set; }

        /// <summary>
        /// Gets or sets write permission
        /// </summary>
        [JsonProperty(PropertyName = "write")]
        public bool? Write { get; set; }

        /// <summary>
        /// Gets or sets read permission
        /// </summary>
        [JsonProperty(PropertyName = "read")]
        public bool? Read { get; set; }

        /// <summary>
        /// Gets or sets delete permission
        /// </summary>
        [JsonProperty(PropertyName = "delete")]
        public bool? Delete { get; set; }

    }
}