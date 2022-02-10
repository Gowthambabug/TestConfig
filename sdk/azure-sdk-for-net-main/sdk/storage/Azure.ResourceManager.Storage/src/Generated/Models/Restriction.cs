// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The restriction because of which SKU cannot be used. </summary>
    public partial class Restriction
    {
        /// <summary> Initializes a new instance of Restriction. </summary>
        internal Restriction()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of Restriction. </summary>
        /// <param name="type"> The type of restrictions. As of now only possible value for this is location. </param>
        /// <param name="values"> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </param>
        /// <param name="reasonCode"> The reason for the restriction. As of now this can be &quot;QuotaId&quot; or &quot;NotAvailableForSubscription&quot;. Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The &quot;NotAvailableForSubscription&quot; is related to capacity at DC. </param>
        internal Restriction(string type, IReadOnlyList<string> values, ReasonCode? reasonCode)
        {
            Type = type;
            Values = values;
            ReasonCode = reasonCode;
        }

        /// <summary> The type of restrictions. As of now only possible value for this is location. </summary>
        public string Type { get; }
        /// <summary> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The reason for the restriction. As of now this can be &quot;QuotaId&quot; or &quot;NotAvailableForSubscription&quot;. Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The &quot;NotAvailableForSubscription&quot; is related to capacity at DC. </summary>
        public ReasonCode? ReasonCode { get; }
    }
}