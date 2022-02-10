// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The LoadBalancerConfigurationProperties. </summary>
    public partial class LoadBalancerConfigurationProperties
    {
        /// <summary> Initializes a new instance of LoadBalancerConfigurationProperties. </summary>
        /// <param name="frontendIPConfigurations"> Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurations"/> is null. </exception>
        public LoadBalancerConfigurationProperties(IEnumerable<LoadBalancerFrontendIPConfiguration> frontendIPConfigurations)
        {
            if (frontendIPConfigurations == null)
            {
                throw new ArgumentNullException(nameof(frontendIPConfigurations));
            }

            FrontendIPConfigurations = frontendIPConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of LoadBalancerConfigurationProperties. </summary>
        /// <param name="frontendIPConfigurations"> Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration. </param>
        internal LoadBalancerConfigurationProperties(IList<LoadBalancerFrontendIPConfiguration> frontendIPConfigurations)
        {
            FrontendIPConfigurations = frontendIPConfigurations;
        }

        /// <summary> Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration. </summary>
        public IList<LoadBalancerFrontendIPConfiguration> FrontendIPConfigurations { get; }
    }
}