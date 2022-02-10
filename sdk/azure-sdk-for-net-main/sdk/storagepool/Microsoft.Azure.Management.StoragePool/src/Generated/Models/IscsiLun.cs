// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StoragePool.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// LUN to expose the Azure Managed Disk.
    /// </summary>
    public partial class IscsiLun
    {
        /// <summary>
        /// Initializes a new instance of the IscsiLun class.
        /// </summary>
        public IscsiLun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IscsiLun class.
        /// </summary>
        /// <param name="name">User defined name for iSCSI LUN; example:
        /// "lun0"</param>
        /// <param name="managedDiskAzureResourceId">Azure Resource ID of the
        /// Managed Disk.</param>
        /// <param name="lun">Specifies the Logical Unit Number of the iSCSI
        /// LUN.</param>
        public IscsiLun(string name, string managedDiskAzureResourceId, int? lun = default(int?))
        {
            Name = name;
            ManagedDiskAzureResourceId = managedDiskAzureResourceId;
            Lun = lun;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user defined name for iSCSI LUN; example: "lun0"
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets azure Resource ID of the Managed Disk.
        /// </summary>
        [JsonProperty(PropertyName = "managedDiskAzureResourceId")]
        public string ManagedDiskAzureResourceId { get; set; }

        /// <summary>
        /// Gets specifies the Logical Unit Number of the iSCSI LUN.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int? Lun { get; private set; }

    }
}