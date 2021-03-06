// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of Profiles in the Profile. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Profiles and their operations over a Profile. </returns>
        public static ProfileCollection GetProfiles(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetProfiles();
        }

        /// <summary> Gets a collection of CdnWebApplicationFirewallPolicies in the CdnWebApplicationFirewallPolicy. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of CdnWebApplicationFirewallPolicies and their operations over a CdnWebApplicationFirewallPolicy. </returns>
        public static CdnWebApplicationFirewallPolicyCollection GetCdnWebApplicationFirewallPolicies(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetCdnWebApplicationFirewallPolicies();
        }
    }
}
