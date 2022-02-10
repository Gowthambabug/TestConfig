// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An invoice section.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InvoiceSection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the InvoiceSection class.
        /// </summary>
        public InvoiceSection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InvoiceSection class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The name of the invoice section.</param>
        /// <param name="labels">Dictionary of metadata associated with the
        /// invoice section.</param>
        /// <param name="systemId">The system generated unique identifier for
        /// an invoice section.</param>
        public InvoiceSection(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), IDictionary<string, string> labels = default(IDictionary<string, string>), string systemId = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Labels = labels;
            SystemId = systemId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the invoice section.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets dictionary of metadata associated with the invoice
        /// section.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labels")]
        public IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Gets the system generated unique identifier for an invoice section.
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemId")]
        public string SystemId { get; private set; }

    }
}