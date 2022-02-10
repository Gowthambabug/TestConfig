// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input properties to apply recovery point.
    /// </summary>
    public partial class ApplyRecoveryPointInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInputProperties
        /// class.
        /// </summary>
        public ApplyRecoveryPointInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInputProperties
        /// class.
        /// </summary>
        /// <param name="providerSpecificDetails">Provider specific input for
        /// applying recovery point.</param>
        /// <param name="recoveryPointId">The recovery point Id.</param>
        public ApplyRecoveryPointInputProperties(ApplyRecoveryPointProviderSpecificInput providerSpecificDetails, string recoveryPointId = default(string))
        {
            RecoveryPointId = recoveryPointId;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Gets or sets provider specific input for applying recovery point.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ApplyRecoveryPointProviderSpecificInput ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProviderSpecificDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProviderSpecificDetails");
            }
        }
    }
}