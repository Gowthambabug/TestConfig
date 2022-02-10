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
    /// Describes an Operating System disk.
    /// </summary>
    public partial class RestorePointSourceVMOSDisk
    {
        /// <summary>
        /// Initializes a new instance of the RestorePointSourceVMOSDisk class.
        /// </summary>
        public RestorePointSourceVMOSDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorePointSourceVMOSDisk class.
        /// </summary>
        /// <param name="osType">Gets the Operating System type. Possible
        /// values include: 'Windows', 'Linux'</param>
        /// <param name="encryptionSettings">Gets the disk encryption
        /// settings.</param>
        /// <param name="name">Gets the disk name.</param>
        /// <param name="caching">Gets the caching type. Possible values
        /// include: 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="diskSizeGB">Gets the disk size in GB.</param>
        /// <param name="managedDisk">Gets the managed disk details</param>
        /// <param name="diskRestorePoint">Gets the disk restore point
        /// Id.</param>
        public RestorePointSourceVMOSDisk(string osType = default(string), DiskEncryptionSettings encryptionSettings = default(DiskEncryptionSettings), string name = default(string), CachingTypes? caching = default(CachingTypes?), int? diskSizeGB = default(int?), ManagedDiskParameters managedDisk = default(ManagedDiskParameters), ApiEntityReference diskRestorePoint = default(ApiEntityReference))
        {
            OsType = osType;
            EncryptionSettings = encryptionSettings;
            Name = name;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            DiskRestorePoint = diskRestorePoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Operating System type. Possible values include: 'Windows',
        /// 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets the disk encryption settings.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionSettings")]
        public DiskEncryptionSettings EncryptionSettings { get; set; }

        /// <summary>
        /// Gets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the caching type. Possible values include: 'None', 'ReadOnly',
        /// 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets the disk size in GB.
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets the managed disk details
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public ManagedDiskParameters ManagedDisk { get; set; }

        /// <summary>
        /// Gets the disk restore point Id.
        /// </summary>
        [JsonProperty(PropertyName = "diskRestorePoint")]
        public ApiEntityReference DiskRestorePoint { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptionSettings != null)
            {
                EncryptionSettings.Validate();
            }
        }
    }
}