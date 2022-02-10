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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    public partial class VirtualMachineScaleSetUpdateVMProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateVMProfile class.
        /// </summary>
        public VirtualMachineScaleSetUpdateVMProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateVMProfile class.
        /// </summary>
        /// <param name="osProfile">The virtual machine scale set OS
        /// profile.</param>
        /// <param name="storageProfile">The virtual machine scale set storage
        /// profile.</param>
        /// <param name="networkProfile">The virtual machine scale set network
        /// profile.</param>
        /// <param name="securityProfile">The virtual machine scale set
        /// Security profile</param>
        /// <param name="diagnosticsProfile">The virtual machine scale set
        /// diagnostics profile.</param>
        /// <param name="extensionProfile">The virtual machine scale set
        /// extension profile.</param>
        /// <param name="licenseType">The license type, which is for bring your
        /// own license scenario.</param>
        /// <param name="billingProfile">Specifies the billing related details
        /// of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2019-03-01.</param>
        /// <param name="scheduledEventsProfile">Specifies Scheduled Event
        /// related configurations.</param>
        /// <param name="userData">UserData for the VM, which must be base-64
        /// encoded. Customer should not pass any secrets in here.
        /// &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01</param>
        public VirtualMachineScaleSetUpdateVMProfile(VirtualMachineScaleSetUpdateOSProfile osProfile = default(VirtualMachineScaleSetUpdateOSProfile), VirtualMachineScaleSetUpdateStorageProfile storageProfile = default(VirtualMachineScaleSetUpdateStorageProfile), VirtualMachineScaleSetUpdateNetworkProfile networkProfile = default(VirtualMachineScaleSetUpdateNetworkProfile), SecurityProfile securityProfile = default(SecurityProfile), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), VirtualMachineScaleSetExtensionProfile extensionProfile = default(VirtualMachineScaleSetExtensionProfile), string licenseType = default(string), BillingProfile billingProfile = default(BillingProfile), ScheduledEventsProfile scheduledEventsProfile = default(ScheduledEventsProfile), string userData = default(string))
        {
            OsProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            BillingProfile = billingProfile;
            ScheduledEventsProfile = scheduledEventsProfile;
            UserData = userData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine scale set OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "osProfile")]
        public VirtualMachineScaleSetUpdateOSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public VirtualMachineScaleSetUpdateStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set network profile.
        /// </summary>
        [JsonProperty(PropertyName = "networkProfile")]
        public VirtualMachineScaleSetUpdateNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set Security profile
        /// </summary>
        [JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set diagnostics profile.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set extension profile.
        /// </summary>
        [JsonProperty(PropertyName = "extensionProfile")]
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }

        /// <summary>
        /// Gets or sets the license type, which is for bring your own license
        /// scenario.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets specifies the billing related details of a Azure Spot
        /// VMSS. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2019-03-01.
        /// </summary>
        [JsonProperty(PropertyName = "billingProfile")]
        public BillingProfile BillingProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies Scheduled Event related configurations.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledEventsProfile")]
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }

        /// <summary>
        /// Gets or sets userData for the VM, which must be base-64 encoded.
        /// Customer should not pass any secrets in here.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version: 2021-03-01
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

    }
}