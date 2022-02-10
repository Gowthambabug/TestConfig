// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Tenant Settings.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TenantSettingsContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TenantSettingsContract class.
        /// </summary>
        public TenantSettingsContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantSettingsContract class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="settings">Tenant settings</param>
        public TenantSettingsContract(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> settings = default(IDictionary<string, string>))
            : base(id, name, type)
        {
            Settings = settings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tenant settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings")]
        public IDictionary<string, string> Settings { get; set; }

    }
}