// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An attestation resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Attestation : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Attestation class.
        /// </summary>
        public Attestation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Attestation class.
        /// </summary>
        /// <param name="policyAssignmentId">The resource ID of the policy
        /// assignment that the attestation is setting the state for.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="policyDefinitionReferenceId">The policy definition
        /// reference ID from a policy set definition that the attestation is
        /// setting the state for. If the policy assignment assigns a policy
        /// set definition the attestation can choose a definition within the
        /// set definition with this property or omit this and set the state
        /// for the entire set definition.</param>
        /// <param name="complianceState">The compliance state that should be
        /// set on the resource. Possible values include: 'Compliant',
        /// 'NonCompliant', 'Unknown'</param>
        /// <param name="expiresOn">The time the compliance state should
        /// expire.</param>
        /// <param name="owner">The person responsible for setting the state of
        /// the resource. This value is typically an Azure Active Directory
        /// object ID.</param>
        /// <param name="comments">Comments describing why this attestation was
        /// created.</param>
        /// <param name="evidence">The evidence supporting the compliance state
        /// set in this attestation.</param>
        /// <param name="provisioningState">The status of the
        /// attestation.</param>
        /// <param name="lastComplianceStateChangeAt">The time the compliance
        /// state was last changed in this attestation.</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        public Attestation(string policyAssignmentId, string id = default(string), string name = default(string), string type = default(string), string policyDefinitionReferenceId = default(string), string complianceState = default(string), System.DateTime? expiresOn = default(System.DateTime?), string owner = default(string), string comments = default(string), IList<AttestationEvidence> evidence = default(IList<AttestationEvidence>), string provisioningState = default(string), System.DateTime? lastComplianceStateChangeAt = default(System.DateTime?), SystemData systemData = default(SystemData))
            : base(id, name, type)
        {
            PolicyAssignmentId = policyAssignmentId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            ComplianceState = complianceState;
            ExpiresOn = expiresOn;
            Owner = owner;
            Comments = comments;
            Evidence = evidence;
            ProvisioningState = provisioningState;
            LastComplianceStateChangeAt = lastComplianceStateChangeAt;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the policy assignment that the
        /// attestation is setting the state for.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyAssignmentId")]
        public string PolicyAssignmentId { get; set; }

        /// <summary>
        /// Gets or sets the policy definition reference ID from a policy set
        /// definition that the attestation is setting the state for. If the
        /// policy assignment assigns a policy set definition the attestation
        /// can choose a definition within the set definition with this
        /// property or omit this and set the state for the entire set
        /// definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyDefinitionReferenceId")]
        public string PolicyDefinitionReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the compliance state that should be set on the
        /// resource. Possible values include: 'Compliant', 'NonCompliant',
        /// 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.complianceState")]
        public string ComplianceState { get; set; }

        /// <summary>
        /// Gets or sets the time the compliance state should expire.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiresOn")]
        public System.DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// Gets or sets the person responsible for setting the state of the
        /// resource. This value is typically an Azure Active Directory object
        /// ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets comments describing why this attestation was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the evidence supporting the compliance state set in
        /// this attestation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.evidence")]
        public IList<AttestationEvidence> Evidence { get; set; }

        /// <summary>
        /// Gets the status of the attestation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the time the compliance state was last changed in this
        /// attestation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastComplianceStateChangeAt")]
        public System.DateTime? LastComplianceStateChangeAt { get; private set; }

        /// <summary>
        /// Gets azure Resource Manager metadata containing createdBy and
        /// modifiedBy information.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PolicyAssignmentId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PolicyAssignmentId");
            }
        }
    }
}