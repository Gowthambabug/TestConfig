// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Description of NetWorkRuleSet - IpRules resource. </summary>
    public partial class NetworkRuleSetIPRules
    {
        /// <summary> Initializes a new instance of NetworkRuleSetIPRules. </summary>
        public NetworkRuleSetIPRules()
        {
        }

        /// <summary> Initializes a new instance of NetworkRuleSetIPRules. </summary>
        /// <param name="iPMask"> IP Mask. </param>
        /// <param name="action"> The IP Filter Action. </param>
        internal NetworkRuleSetIPRules(string iPMask, NetworkRuleIPAction? action)
        {
            IPMask = iPMask;
            Action = action;
        }

        /// <summary> IP Mask. </summary>
        public string IPMask { get; set; }
        /// <summary> The IP Filter Action. </summary>
        public NetworkRuleIPAction? Action { get; set; }
    }
}
