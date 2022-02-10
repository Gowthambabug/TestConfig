// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the domain to create. </summary>
    public partial class AfdCustomDomainProperties : AfdCustomDomainUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of AfdCustomDomainProperties. </summary>
        /// <param name="hostName"> The host name of the domain. Must be a domain name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public AfdCustomDomainProperties(string hostName)
        {
            if (hostName == null)
            {
                throw new ArgumentNullException(nameof(hostName));
            }

            HostName = hostName;
        }

        /// <summary> Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation. </summary>
        public DomainValidationState? DomainValidationState { get; }
        /// <summary> The host name of the domain. Must be a domain name. </summary>
        public string HostName { get; }
        /// <summary> Values the customer needs to validate domain ownership. </summary>
        public DomainValidationProperties ValidationProperties { get; }
        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public DeploymentStatus? DeploymentStatus { get; }
    }
}