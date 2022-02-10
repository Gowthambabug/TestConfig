// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LoadBalancerConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancerConfigurationProperties class.
        /// </summary>
        public LoadBalancerConfigurationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancerConfigurationProperties class.
        /// </summary>
        /// <param name="frontendIPConfigurations">Specifies the frontend IP to
        /// be used for the load balancer. Only IPv4 frontend IP address is
        /// supported. Each load balancer configuration must have exactly one
        /// frontend IP configuration.</param>
        public LoadBalancerConfigurationProperties(IList<LoadBalancerFrontendIPConfiguration> frontendIPConfigurations)
        {
            FrontendIPConfigurations = frontendIPConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the frontend IP to be used for the load
        /// balancer. Only IPv4 frontend IP address is supported. Each load
        /// balancer configuration must have exactly one frontend IP
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "frontendIPConfigurations")]
        public IList<LoadBalancerFrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FrontendIPConfigurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FrontendIPConfigurations");
            }
            if (FrontendIPConfigurations != null)
            {
                foreach (var element in FrontendIPConfigurations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}