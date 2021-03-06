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
    /// Represents Insight Query.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Insight")]
    public partial class InsightQueryItem : EntityQueryItem
    {
        /// <summary>
        /// Initializes a new instance of the InsightQueryItem class.
        /// </summary>
        public InsightQueryItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InsightQueryItem class.
        /// </summary>
        /// <param name="id">Query Template ARM ID</param>
        /// <param name="name">Query Template ARM Name</param>
        /// <param name="type">ARM Type</param>
        /// <param name="properties">Properties bag for
        /// InsightQueryItem</param>
        public InsightQueryItem(string id = default(string), string name = default(string), string type = default(string), InsightQueryItemProperties properties = default(InsightQueryItemProperties))
            : base(id, name, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties bag for InsightQueryItem
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public InsightQueryItemProperties Properties { get; set; }

    }
}
