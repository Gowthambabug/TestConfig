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
    /// Resource provider permissions required for the connector
    /// </summary>
    public partial class ResourceProvider
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProvider class.
        /// </summary>
        public ResourceProvider()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceProvider class.
        /// </summary>
        /// <param name="provider">Provider name. Possible values include:
        /// 'Microsoft.OperationalInsights/solutions',
        /// 'Microsoft.OperationalInsights/workspaces',
        /// 'Microsoft.OperationalInsights/workspaces/datasources',
        /// 'microsoft.aadiam/diagnosticSettings',
        /// 'Microsoft.OperationalInsights/workspaces/sharedKeys',
        /// 'Microsoft.Authorization/policyAssignments'</param>
        /// <param name="permissionsDisplayText">Permission description
        /// text</param>
        /// <param name="providerDisplayName">Permission provider display
        /// name</param>
        /// <param name="scope">Permission provider scope. Possible values
        /// include: 'ResourceGroup', 'Subscription', 'Workspace'</param>
        /// <param name="requiredPermissions">Required permissions for the
        /// connector</param>
        public ResourceProvider(string provider = default(string), string permissionsDisplayText = default(string), string providerDisplayName = default(string), string scope = default(string), RequiredPermissions requiredPermissions = default(RequiredPermissions))
        {
            Provider = provider;
            PermissionsDisplayText = permissionsDisplayText;
            ProviderDisplayName = providerDisplayName;
            Scope = scope;
            RequiredPermissions = requiredPermissions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provider name. Possible values include:
        /// 'Microsoft.OperationalInsights/solutions',
        /// 'Microsoft.OperationalInsights/workspaces',
        /// 'Microsoft.OperationalInsights/workspaces/datasources',
        /// 'microsoft.aadiam/diagnosticSettings',
        /// 'Microsoft.OperationalInsights/workspaces/sharedKeys',
        /// 'Microsoft.Authorization/policyAssignments'
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets permission description text
        /// </summary>
        [JsonProperty(PropertyName = "permissionsDisplayText")]
        public string PermissionsDisplayText { get; set; }

        /// <summary>
        /// Gets or sets permission provider display name
        /// </summary>
        [JsonProperty(PropertyName = "providerDisplayName")]
        public string ProviderDisplayName { get; set; }

        /// <summary>
        /// Gets or sets permission provider scope. Possible values include:
        /// 'ResourceGroup', 'Subscription', 'Workspace'
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets required permissions for the connector
        /// </summary>
        [JsonProperty(PropertyName = "requiredPermissions")]
        public RequiredPermissions RequiredPermissions { get; set; }

    }
}