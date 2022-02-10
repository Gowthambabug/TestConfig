// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the ephemeral Disk Settings for the operating system disk
    /// used by the virtual machine.
    /// </summary>
    public partial class DiffDiskSettings
    {
        /// <summary>
        /// Initializes a new instance of the DiffDiskSettings class.
        /// </summary>
        public DiffDiskSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiffDiskSettings class.
        /// </summary>
        /// <param name="placement">Specifies the ephemeral disk placement for
        /// operating system disk for all VMs in the pool.</param>
        public DiffDiskSettings(DiffDiskPlacement? placement = default(DiffDiskPlacement?))
        {
            Placement = placement;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the ephemeral disk placement for operating
        /// system disk for all VMs in the pool.
        /// </summary>
        /// <remarks>
        /// This property can be used by user in the request to choose which
        /// location the operating system should be in. e.g., cache disk space
        /// for Ephemeral OS disk provisioning. For more information on
        /// Ephemeral OS disk size requirements, please refer to Ephemeral OS
        /// disk size requirements for Windows VMs at
        /// https://docs.microsoft.com/en-us/azure/virtual-machines/windows/ephemeral-os-disks#size-requirements
        /// and Linux VMs at
        /// https://docs.microsoft.com/en-us/azure/virtual-machines/linux/ephemeral-os-disks#size-requirements.
        /// Possible values include: 'CacheDisk'
        /// </remarks>
        [JsonProperty(PropertyName = "placement")]
        public DiffDiskPlacement? Placement { get; set; }

    }
}