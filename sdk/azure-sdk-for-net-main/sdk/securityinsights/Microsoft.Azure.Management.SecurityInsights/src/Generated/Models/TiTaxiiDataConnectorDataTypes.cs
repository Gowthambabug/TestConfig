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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The available data types for Threat Intelligence TAXII data connector.
    /// </summary>
    public partial class TiTaxiiDataConnectorDataTypes
    {
        /// <summary>
        /// Initializes a new instance of the TiTaxiiDataConnectorDataTypes
        /// class.
        /// </summary>
        public TiTaxiiDataConnectorDataTypes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TiTaxiiDataConnectorDataTypes
        /// class.
        /// </summary>
        /// <param name="taxiiClient">Data type for TAXII connector.</param>
        public TiTaxiiDataConnectorDataTypes(TiTaxiiDataConnectorDataTypesTaxiiClient taxiiClient)
        {
            TaxiiClient = taxiiClient;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data type for TAXII connector.
        /// </summary>
        [JsonProperty(PropertyName = "taxiiClient")]
        public TiTaxiiDataConnectorDataTypesTaxiiClient TaxiiClient { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaxiiClient == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaxiiClient");
            }
            if (TaxiiClient != null)
            {
                TaxiiClient.Validate();
            }
        }
    }
}
