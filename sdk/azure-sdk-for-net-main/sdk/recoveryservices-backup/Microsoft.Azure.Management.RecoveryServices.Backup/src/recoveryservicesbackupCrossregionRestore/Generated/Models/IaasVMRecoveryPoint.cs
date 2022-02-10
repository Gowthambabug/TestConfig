// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload specific backup copy.
    /// </summary>
    public partial class IaasVMRecoveryPoint : RecoveryPoint
    {
        /// <summary>
        /// Initializes a new instance of the IaasVMRecoveryPoint class.
        /// </summary>
        public IaasVMRecoveryPoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IaasVMRecoveryPoint class.
        /// </summary>
        /// <param name="recoveryPointType">Type of the backup copy.</param>
        /// <param name="recoveryPointTime">Time at which this backup copy was
        /// created.</param>
        /// <param name="recoveryPointAdditionalInfo">Additional information
        /// associated with this backup copy.</param>
        /// <param name="sourceVMStorageType">Storage type of the VM whose
        /// backup copy is created.</param>
        /// <param name="isSourceVMEncrypted">Identifies whether the VM was
        /// encrypted when the backup copy is created.</param>
        /// <param name="keyAndSecret">Required details for recovering an
        /// encrypted VM. Applicable only when IsSourceVMEncrypted is
        /// true.</param>
        /// <param name="isInstantIlrSessionActive">Is the session to recover
        /// items from this backup copy still active.</param>
        /// <param name="recoveryPointTierDetails">Recovery point tier
        /// information.</param>
        /// <param name="isManagedVirtualMachine">Whether VM is with Managed
        /// Disks</param>
        /// <param name="virtualMachineSize">Virtual Machine Size</param>
        /// <param name="originalStorageAccountOption">Original Storage Account
        /// Option</param>
        /// <param name="osType">OS type</param>
        /// <param name="recoveryPointDiskConfiguration">Disk
        /// configuration</param>
        /// <param name="zones">Identifies the zone of the VM at the time of
        /// backup. Applicable only for zone-pinned Vms</param>
        /// <param name="recoveryPointMoveReadinessInfo">Eligibility of RP to
        /// be moved to another tier</param>
        public IaasVMRecoveryPoint(string recoveryPointType = default(string), System.DateTime? recoveryPointTime = default(System.DateTime?), string recoveryPointAdditionalInfo = default(string), string sourceVMStorageType = default(string), bool? isSourceVMEncrypted = default(bool?), KeyAndSecretDetails keyAndSecret = default(KeyAndSecretDetails), bool? isInstantIlrSessionActive = default(bool?), IList<RecoveryPointTierInformation> recoveryPointTierDetails = default(IList<RecoveryPointTierInformation>), bool? isManagedVirtualMachine = default(bool?), string virtualMachineSize = default(string), bool? originalStorageAccountOption = default(bool?), string osType = default(string), RecoveryPointDiskConfiguration recoveryPointDiskConfiguration = default(RecoveryPointDiskConfiguration), IList<string> zones = default(IList<string>), IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo = default(IDictionary<string, RecoveryPointMoveReadinessInfo>))
        {
            RecoveryPointType = recoveryPointType;
            RecoveryPointTime = recoveryPointTime;
            RecoveryPointAdditionalInfo = recoveryPointAdditionalInfo;
            SourceVMStorageType = sourceVMStorageType;
            IsSourceVMEncrypted = isSourceVMEncrypted;
            KeyAndSecret = keyAndSecret;
            IsInstantIlrSessionActive = isInstantIlrSessionActive;
            RecoveryPointTierDetails = recoveryPointTierDetails;
            IsManagedVirtualMachine = isManagedVirtualMachine;
            VirtualMachineSize = virtualMachineSize;
            OriginalStorageAccountOption = originalStorageAccountOption;
            OsType = osType;
            RecoveryPointDiskConfiguration = recoveryPointDiskConfiguration;
            Zones = zones;
            RecoveryPointMoveReadinessInfo = recoveryPointMoveReadinessInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets type of the backup copy.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointType")]
        public string RecoveryPointType { get; private set; }

        /// <summary>
        /// Gets time at which this backup copy was created.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointTime")]
        public System.DateTime? RecoveryPointTime { get; private set; }

        /// <summary>
        /// Gets additional information associated with this backup copy.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointAdditionalInfo")]
        public string RecoveryPointAdditionalInfo { get; private set; }

        /// <summary>
        /// Gets storage type of the VM whose backup copy is created.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVMStorageType")]
        public string SourceVMStorageType { get; private set; }

        /// <summary>
        /// Gets identifies whether the VM was encrypted when the backup copy
        /// is created.
        /// </summary>
        [JsonProperty(PropertyName = "isSourceVMEncrypted")]
        public bool? IsSourceVMEncrypted { get; private set; }

        /// <summary>
        /// Gets or sets required details for recovering an encrypted VM.
        /// Applicable only when IsSourceVMEncrypted is true.
        /// </summary>
        [JsonProperty(PropertyName = "keyAndSecret")]
        public KeyAndSecretDetails KeyAndSecret { get; set; }

        /// <summary>
        /// Gets or sets is the session to recover items from this backup copy
        /// still active.
        /// </summary>
        [JsonProperty(PropertyName = "isInstantIlrSessionActive")]
        public bool? IsInstantIlrSessionActive { get; set; }

        /// <summary>
        /// Gets or sets recovery point tier information.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointTierDetails")]
        public IList<RecoveryPointTierInformation> RecoveryPointTierDetails { get; set; }

        /// <summary>
        /// Gets or sets whether VM is with Managed Disks
        /// </summary>
        [JsonProperty(PropertyName = "isManagedVirtualMachine")]
        public bool? IsManagedVirtualMachine { get; set; }

        /// <summary>
        /// Gets or sets virtual Machine Size
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineSize")]
        public string VirtualMachineSize { get; set; }

        /// <summary>
        /// Gets or sets original Storage Account Option
        /// </summary>
        [JsonProperty(PropertyName = "originalStorageAccountOption")]
        public bool? OriginalStorageAccountOption { get; set; }

        /// <summary>
        /// Gets or sets OS type
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets disk configuration
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointDiskConfiguration")]
        public RecoveryPointDiskConfiguration RecoveryPointDiskConfiguration { get; set; }

        /// <summary>
        /// Gets or sets identifies the zone of the VM at the time of backup.
        /// Applicable only for zone-pinned Vms
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets or sets eligibility of RP to be moved to another tier
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointMoveReadinessInfo")]
        public IDictionary<string, RecoveryPointMoveReadinessInfo> RecoveryPointMoveReadinessInfo { get; set; }

    }
}