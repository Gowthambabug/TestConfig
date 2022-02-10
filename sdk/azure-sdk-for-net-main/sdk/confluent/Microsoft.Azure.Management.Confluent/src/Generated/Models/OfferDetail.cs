// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Confluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Confluent Offer detail
    /// </summary>
    public partial class OfferDetail
    {
        /// <summary>
        /// Initializes a new instance of the OfferDetail class.
        /// </summary>
        public OfferDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OfferDetail class.
        /// </summary>
        /// <param name="publisherId">Publisher Id</param>
        /// <param name="id">Offer Id</param>
        /// <param name="planId">Offer Plan Id</param>
        /// <param name="planName">Offer Plan Name</param>
        /// <param name="termUnit">Offer Plan Term unit</param>
        /// <param name="status">SaaS Offer Status. Possible values include:
        /// 'Started', 'PendingFulfillmentStart', 'InProgress', 'Subscribed',
        /// 'Suspended', 'Reinstated', 'Succeeded', 'Failed', 'Unsubscribed',
        /// 'Updating'</param>
        public OfferDetail(string publisherId, string id, string planId, string planName, string termUnit, string status = default(string))
        {
            PublisherId = publisherId;
            Id = id;
            PlanId = planId;
            PlanName = planName;
            TermUnit = termUnit;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets publisher Id
        /// </summary>
        [JsonProperty(PropertyName = "publisherId")]
        public string PublisherId { get; set; }

        /// <summary>
        /// Gets or sets offer Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets offer Plan Id
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or sets offer Plan Name
        /// </summary>
        [JsonProperty(PropertyName = "planName")]
        public string PlanName { get; set; }

        /// <summary>
        /// Gets or sets offer Plan Term unit
        /// </summary>
        [JsonProperty(PropertyName = "termUnit")]
        public string TermUnit { get; set; }

        /// <summary>
        /// Gets or sets saaS Offer Status. Possible values include: 'Started',
        /// 'PendingFulfillmentStart', 'InProgress', 'Subscribed', 'Suspended',
        /// 'Reinstated', 'Succeeded', 'Failed', 'Unsubscribed', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PublisherId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublisherId");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (PlanId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PlanId");
            }
            if (PlanName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PlanName");
            }
            if (TermUnit == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TermUnit");
            }
            if (PublisherId != null)
            {
                if (PublisherId.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PublisherId", 50);
                }
            }
            if (Id != null)
            {
                if (Id.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Id", 50);
                }
            }
            if (PlanId != null)
            {
                if (PlanId.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PlanId", 50);
                }
            }
            if (PlanName != null)
            {
                if (PlanName.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PlanName", 50);
                }
            }
            if (TermUnit != null)
            {
                if (TermUnit.Length > 25)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "TermUnit", 25);
                }
            }
        }
    }
}