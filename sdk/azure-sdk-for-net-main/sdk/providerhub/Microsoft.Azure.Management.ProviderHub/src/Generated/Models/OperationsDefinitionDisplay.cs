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
    using System.Linq;

    /// <summary>
    /// Display information of the operation.
    /// </summary>
    public partial class OperationsDefinitionDisplay : OperationsDisplayDefinition
    {
        /// <summary>
        /// Initializes a new instance of the OperationsDefinitionDisplay
        /// class.
        /// </summary>
        public OperationsDefinitionDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationsDefinitionDisplay
        /// class.
        /// </summary>
        public OperationsDefinitionDisplay(string provider, string resource, string operation, string description)
            : base(provider, resource, operation, description)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}