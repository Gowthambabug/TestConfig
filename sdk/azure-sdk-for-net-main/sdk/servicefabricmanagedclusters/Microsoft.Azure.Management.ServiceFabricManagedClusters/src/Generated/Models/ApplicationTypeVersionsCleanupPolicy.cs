// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The policy used to clean up unused versions. When the policy is not
    /// specified explicitly, the default unused application versions to keep
    /// will be 3.
    /// </summary>
    public partial class ApplicationTypeVersionsCleanupPolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationTypeVersionsCleanupPolicy class.
        /// </summary>
        public ApplicationTypeVersionsCleanupPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationTypeVersionsCleanupPolicy class.
        /// </summary>
        /// <param name="maxUnusedVersionsToKeep">Number of unused versions per
        /// application type to keep.</param>
        public ApplicationTypeVersionsCleanupPolicy(int maxUnusedVersionsToKeep)
        {
            MaxUnusedVersionsToKeep = maxUnusedVersionsToKeep;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of unused versions per application type to
        /// keep.
        /// </summary>
        [JsonProperty(PropertyName = "maxUnusedVersionsToKeep")]
        public int MaxUnusedVersionsToKeep { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxUnusedVersionsToKeep < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxUnusedVersionsToKeep", 0);
            }
        }
    }
}