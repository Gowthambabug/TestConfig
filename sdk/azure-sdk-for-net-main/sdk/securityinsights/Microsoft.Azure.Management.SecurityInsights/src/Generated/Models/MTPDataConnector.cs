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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents MTP (Microsoft Threat Protection) data connector.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MicrosoftThreatProtection")]
    [Rest.Serialization.JsonTransformation]
    public partial class MTPDataConnector : DataConnector
    {
        /// <summary>
        /// Initializes a new instance of the MTPDataConnector class.
        /// </summary>
        public MTPDataConnector()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MTPDataConnector class.
        /// </summary>
        /// <param name="tenantId">The tenant id to connect to, and get the
        /// data from.</param>
        /// <param name="dataTypes">The available data types for the
        /// connector.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="etag">Etag of the azure resource</param>
        public MTPDataConnector(string tenantId, MTPDataConnectorDataTypes dataTypes, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string etag = default(string))
            : base(id, name, type, systemData, etag)
        {
            TenantId = tenantId;
            DataTypes = dataTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tenant id to connect to, and get the data from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets the available data types for the connector.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataTypes")]
        public MTPDataConnectorDataTypes DataTypes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TenantId");
            }
            if (DataTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataTypes");
            }
            if (DataTypes != null)
            {
                DataTypes.Validate();
            }
        }
    }
}
