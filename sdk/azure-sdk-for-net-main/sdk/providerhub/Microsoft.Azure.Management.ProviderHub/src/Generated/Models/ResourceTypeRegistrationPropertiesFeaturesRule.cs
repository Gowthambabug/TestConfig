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

    public partial class ResourceTypeRegistrationPropertiesFeaturesRule : FeaturesRule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceTypeRegistrationPropertiesFeaturesRule class.
        /// </summary>
        public ResourceTypeRegistrationPropertiesFeaturesRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceTypeRegistrationPropertiesFeaturesRule class.
        /// </summary>
        /// <param name="requiredFeaturesPolicy">Possible values include:
        /// 'Any', 'All'</param>
        public ResourceTypeRegistrationPropertiesFeaturesRule(string requiredFeaturesPolicy)
            : base(requiredFeaturesPolicy)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}