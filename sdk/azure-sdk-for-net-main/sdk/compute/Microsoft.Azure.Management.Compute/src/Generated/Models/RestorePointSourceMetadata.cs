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
    /// Describes the properties of the Virtual Machine for which the restore
    /// point was created. The properties provided are a subset and the
    /// snapshot of the overall Virtual Machine properties captured at the time
    /// of the restore point creation.
    /// </summary>
    public partial class RestorePointSourceMetadata
    {
        /// <summary>
        /// Initializes a new instance of the RestorePointSourceMetadata class.
        /// </summary>
        public RestorePointSourceMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorePointSourceMetadata class.
        /// </summary>
        /// <param name="hardwareProfile">Gets the hardware profile.</param>
        /// <param name="storageProfile">Gets the storage profile.</param>
        /// <param name="osProfile">Gets the OS profile.</param>
        /// <param name="diagnosticsProfile">Gets the diagnostics
        /// profile.</param>
        /// <param name="licenseType">Gets the license type, which is for bring
        /// your own license scenario.</param>
        /// <param name="vmId">Gets the virtual machine unique id.</param>
        /// <param name="securityProfile">Gets the security profile.</param>
        /// <param name="location">Location of the VM from which the restore
        /// point was created.</param>
        public RestorePointSourceMetadata(HardwareProfile hardwareProfile = default(HardwareProfile), RestorePointSourceVMStorageProfile storageProfile = default(RestorePointSourceVMStorageProfile), OSProfile osProfile = default(OSProfile), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), string licenseType = default(string), string vmId = default(string), SecurityProfile securityProfile = default(SecurityProfile), string location = default(string))
        {
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            OsProfile = osProfile;
            DiagnosticsProfile = diagnosticsProfile;
            LicenseType = licenseType;
            VmId = vmId;
            SecurityProfile = securityProfile;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the hardware profile.
        /// </summary>
        [JsonProperty(PropertyName = "hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Gets the storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public RestorePointSourceVMStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets the diagnostics profile.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets the license type, which is for bring your own license
        /// scenario.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets the virtual machine unique id.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets the security profile.
        /// </summary>
        [JsonProperty(PropertyName = "securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets location of the VM from which the restore point was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
        }
    }
}