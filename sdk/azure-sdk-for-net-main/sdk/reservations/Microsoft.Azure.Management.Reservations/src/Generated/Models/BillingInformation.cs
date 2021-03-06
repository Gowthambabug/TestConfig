// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// billing information
    /// </summary>
    public partial class BillingInformation
    {
        /// <summary>
        /// Initializes a new instance of the BillingInformation class.
        /// </summary>
        public BillingInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingInformation class.
        /// </summary>
        public BillingInformation(Price billingCurrencyTotalPaidAmount = default(Price), Price billingCurrencyProratedAmount = default(Price), Price billingCurrencyRemainingCommitmentAmount = default(Price))
        {
            BillingCurrencyTotalPaidAmount = billingCurrencyTotalPaidAmount;
            BillingCurrencyProratedAmount = billingCurrencyProratedAmount;
            BillingCurrencyRemainingCommitmentAmount = billingCurrencyRemainingCommitmentAmount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingCurrencyTotalPaidAmount")]
        public Price BillingCurrencyTotalPaidAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingCurrencyProratedAmount")]
        public Price BillingCurrencyProratedAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingCurrencyRemainingCommitmentAmount")]
        public Price BillingCurrencyRemainingCommitmentAmount { get; set; }

    }
}
