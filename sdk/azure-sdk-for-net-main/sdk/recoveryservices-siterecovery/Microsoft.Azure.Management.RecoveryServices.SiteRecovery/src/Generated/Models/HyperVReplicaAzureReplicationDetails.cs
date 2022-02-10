// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Hyper V Replica Azure provider specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HyperVReplicaAzure")]
    public partial class HyperVReplicaAzureReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureReplicationDetails class.
        /// </summary>
        public HyperVReplicaAzureReplicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureReplicationDetails class.
        /// </summary>
        /// <param name="azureVmDiskDetails">Azure VM Disk details.</param>
        /// <param name="recoveryAzureVmName">Recovery Azure given
        /// name.</param>
        /// <param name="recoveryAzureVMSize">The Recovery Azure VM
        /// size.</param>
        /// <param name="recoveryAzureStorageAccount">The recovery Azure
        /// storage account.</param>
        /// <param name="recoveryAzureLogStorageAccountId">The ARM id of the
        /// log storage account used for replication. This will be set to null
        /// if no log storage account was provided during enable
        /// protection.</param>
        /// <param name="lastReplicatedTime">The Last replication time.</param>
        /// <param name="rpoInSeconds">Last RPO value.</param>
        /// <param name="lastRpoCalculatedTime">The last RPO calculated
        /// time.</param>
        /// <param name="vmId">The virtual machine Id.</param>
        /// <param name="vmProtectionState">The protection state for the
        /// vm.</param>
        /// <param name="vmProtectionStateDescription">The protection state
        /// description for the vm.</param>
        /// <param name="initialReplicationDetails">Initial replication
        /// details.</param>
        /// <param name="vmNics">The PE Network details.</param>
        /// <param name="selectedRecoveryAzureNetworkId">The selected recovery
        /// azure network Id.</param>
        /// <param name="selectedSourceNicId">The selected source nic Id which
        /// will be used as the primary nic during failover.</param>
        /// <param name="encryption">The encryption info.</param>
        /// <param name="oSDetails">The operating system info.</param>
        /// <param name="sourceVmRamSizeInMB">The RAM size of the VM on the
        /// primary side.</param>
        /// <param name="sourceVmCpuCount">The CPU count of the VM on the
        /// primary side.</param>
        /// <param name="enableRdpOnTargetOption">The selected option to enable
        /// RDP\SSH on target vm after failover. String value of
        /// SrsDataContract.EnableRDPOnTargetOption enum.</param>
        /// <param name="recoveryAzureResourceGroupId">The target resource
        /// group Id.</param>
        /// <param name="recoveryAvailabilitySetId">The recovery availability
        /// set Id.</param>
        /// <param name="targetAvailabilityZone">The target availability
        /// zone.</param>
        /// <param name="targetProximityPlacementGroupId">The target proximity
        /// placement group Id.</param>
        /// <param name="useManagedDisks">A value indicating whether managed
        /// disks should be used during failover.</param>
        /// <param name="licenseType">License Type of the VM to be
        /// used.</param>
        /// <param name="sqlServerLicenseType">The SQL Server license
        /// type.</param>
        /// <param name="lastRecoveryPointReceived">The last recovery point
        /// received time.</param>
        /// <param name="targetVmTags">The target VM tags.</param>
        /// <param name="seedManagedDiskTags">The tags for the seed managed
        /// disks.</param>
        /// <param name="targetManagedDiskTags">The tags for the target managed
        /// disks.</param>
        /// <param name="targetNicTags">The tags for the target NICs.</param>
        /// <param name="protectedManagedDisks">The list of protected managed
        /// disks.</param>
        public HyperVReplicaAzureReplicationDetails(IList<AzureVmDiskDetails> azureVmDiskDetails = default(IList<AzureVmDiskDetails>), string recoveryAzureVmName = default(string), string recoveryAzureVMSize = default(string), string recoveryAzureStorageAccount = default(string), string recoveryAzureLogStorageAccountId = default(string), System.DateTime? lastReplicatedTime = default(System.DateTime?), long? rpoInSeconds = default(long?), System.DateTime? lastRpoCalculatedTime = default(System.DateTime?), string vmId = default(string), string vmProtectionState = default(string), string vmProtectionStateDescription = default(string), InitialReplicationDetails initialReplicationDetails = default(InitialReplicationDetails), IList<VMNicDetails> vmNics = default(IList<VMNicDetails>), string selectedRecoveryAzureNetworkId = default(string), string selectedSourceNicId = default(string), string encryption = default(string), OSDetails oSDetails = default(OSDetails), int? sourceVmRamSizeInMB = default(int?), int? sourceVmCpuCount = default(int?), string enableRdpOnTargetOption = default(string), string recoveryAzureResourceGroupId = default(string), string recoveryAvailabilitySetId = default(string), string targetAvailabilityZone = default(string), string targetProximityPlacementGroupId = default(string), string useManagedDisks = default(string), string licenseType = default(string), string sqlServerLicenseType = default(string), System.DateTime? lastRecoveryPointReceived = default(System.DateTime?), IDictionary<string, string> targetVmTags = default(IDictionary<string, string>), IDictionary<string, string> seedManagedDiskTags = default(IDictionary<string, string>), IDictionary<string, string> targetManagedDiskTags = default(IDictionary<string, string>), IDictionary<string, string> targetNicTags = default(IDictionary<string, string>), IList<HyperVReplicaAzureManagedDiskDetails> protectedManagedDisks = default(IList<HyperVReplicaAzureManagedDiskDetails>))
        {
            AzureVmDiskDetails = azureVmDiskDetails;
            RecoveryAzureVmName = recoveryAzureVmName;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            RecoveryAzureStorageAccount = recoveryAzureStorageAccount;
            RecoveryAzureLogStorageAccountId = recoveryAzureLogStorageAccountId;
            LastReplicatedTime = lastReplicatedTime;
            RpoInSeconds = rpoInSeconds;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            InitialReplicationDetails = initialReplicationDetails;
            VmNics = vmNics;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            SelectedSourceNicId = selectedSourceNicId;
            Encryption = encryption;
            OSDetails = oSDetails;
            SourceVmRamSizeInMB = sourceVmRamSizeInMB;
            SourceVmCpuCount = sourceVmCpuCount;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            UseManagedDisks = useManagedDisks;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            TargetVmTags = targetVmTags;
            SeedManagedDiskTags = seedManagedDiskTags;
            TargetManagedDiskTags = targetManagedDiskTags;
            TargetNicTags = targetNicTags;
            ProtectedManagedDisks = protectedManagedDisks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure VM Disk details.
        /// </summary>
        [JsonProperty(PropertyName = "azureVmDiskDetails")]
        public IList<AzureVmDiskDetails> AzureVmDiskDetails { get; set; }

        /// <summary>
        /// Gets or sets recovery Azure given name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVmName")]
        public string RecoveryAzureVmName { get; set; }

        /// <summary>
        /// Gets or sets the Recovery Azure VM size.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMSize")]
        public string RecoveryAzureVMSize { get; set; }

        /// <summary>
        /// Gets or sets the recovery Azure storage account.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureStorageAccount")]
        public string RecoveryAzureStorageAccount { get; set; }

        /// <summary>
        /// Gets or sets the ARM id of the log storage account used for
        /// replication. This will be set to null if no log storage account was
        /// provided during enable protection.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureLogStorageAccountId")]
        public string RecoveryAzureLogStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the Last replication time.
        /// </summary>
        [JsonProperty(PropertyName = "lastReplicatedTime")]
        public System.DateTime? LastReplicatedTime { get; set; }

        /// <summary>
        /// Gets or sets last RPO value.
        /// </summary>
        [JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the last RPO calculated time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRpoCalculatedTime")]
        public System.DateTime? LastRpoCalculatedTime { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine Id.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets or sets the protection state for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionState")]
        public string VmProtectionState { get; set; }

        /// <summary>
        /// Gets or sets the protection state description for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionStateDescription")]
        public string VmProtectionStateDescription { get; set; }

        /// <summary>
        /// Gets or sets initial replication details.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationDetails")]
        public InitialReplicationDetails InitialReplicationDetails { get; set; }

        /// <summary>
        /// Gets or sets the PE Network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets or sets the selected recovery azure network Id.
        /// </summary>
        [JsonProperty(PropertyName = "selectedRecoveryAzureNetworkId")]
        public string SelectedRecoveryAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the selected source nic Id which will be used as the
        /// primary nic during failover.
        /// </summary>
        [JsonProperty(PropertyName = "selectedSourceNicId")]
        public string SelectedSourceNicId { get; set; }

        /// <summary>
        /// Gets or sets the encryption info.
        /// </summary>
        [JsonProperty(PropertyName = "encryption")]
        public string Encryption { get; set; }

        /// <summary>
        /// Gets or sets the operating system info.
        /// </summary>
        [JsonProperty(PropertyName = "oSDetails")]
        public OSDetails OSDetails { get; set; }

        /// <summary>
        /// Gets or sets the RAM size of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmRamSizeInMB")]
        public int? SourceVmRamSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the CPU count of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmCpuCount")]
        public int? SourceVmCpuCount { get; set; }

        /// <summary>
        /// Gets or sets the selected option to enable RDP\SSH on target vm
        /// after failover. String value of
        /// SrsDataContract.EnableRDPOnTargetOption enum.
        /// </summary>
        [JsonProperty(PropertyName = "enableRdpOnTargetOption")]
        public string EnableRdpOnTargetOption { get; set; }

        /// <summary>
        /// Gets or sets the target resource group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureResourceGroupId")]
        public string RecoveryAzureResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the recovery availability set Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilitySetId")]
        public string RecoveryAvailabilitySetId { get; set; }

        /// <summary>
        /// Gets or sets the target availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilityZone")]
        public string TargetAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the target proximity placement group Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetProximityPlacementGroupId")]
        public string TargetProximityPlacementGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether managed disks should be
        /// used during failover.
        /// </summary>
        [JsonProperty(PropertyName = "useManagedDisks")]
        public string UseManagedDisks { get; set; }

        /// <summary>
        /// Gets or sets license Type of the VM to be used.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the SQL Server license type.
        /// </summary>
        [JsonProperty(PropertyName = "sqlServerLicenseType")]
        public string SqlServerLicenseType { get; set; }

        /// <summary>
        /// Gets the last recovery point received time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRecoveryPointReceived")]
        public System.DateTime? LastRecoveryPointReceived { get; private set; }

        /// <summary>
        /// Gets or sets the target VM tags.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmTags")]
        public IDictionary<string, string> TargetVmTags { get; set; }

        /// <summary>
        /// Gets or sets the tags for the seed managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "seedManagedDiskTags")]
        public IDictionary<string, string> SeedManagedDiskTags { get; set; }

        /// <summary>
        /// Gets or sets the tags for the target managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "targetManagedDiskTags")]
        public IDictionary<string, string> TargetManagedDiskTags { get; set; }

        /// <summary>
        /// Gets or sets the tags for the target NICs.
        /// </summary>
        [JsonProperty(PropertyName = "targetNicTags")]
        public IDictionary<string, string> TargetNicTags { get; set; }

        /// <summary>
        /// Gets or sets the list of protected managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedManagedDisks")]
        public IList<HyperVReplicaAzureManagedDiskDetails> ProtectedManagedDisks { get; set; }

    }
}