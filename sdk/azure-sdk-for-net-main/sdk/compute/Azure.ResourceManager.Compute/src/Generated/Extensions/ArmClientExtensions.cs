// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region AvailabilitySet
        /// <summary> Gets an object representing a AvailabilitySet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySet" /> object. </returns>
        public static AvailabilitySet GetAvailabilitySet(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                AvailabilitySet.ValidateResourceId(id);
                return new AvailabilitySet(client, id);
            }
            );
        }
        #endregion

        #region ProximityPlacementGroup
        /// <summary> Gets an object representing a ProximityPlacementGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProximityPlacementGroup" /> object. </returns>
        public static ProximityPlacementGroup GetProximityPlacementGroup(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                ProximityPlacementGroup.ValidateResourceId(id);
                return new ProximityPlacementGroup(client, id);
            }
            );
        }
        #endregion

        #region DedicatedHostGroup
        /// <summary> Gets an object representing a DedicatedHostGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroup" /> object. </returns>
        public static DedicatedHostGroup GetDedicatedHostGroup(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                DedicatedHostGroup.ValidateResourceId(id);
                return new DedicatedHostGroup(client, id);
            }
            );
        }
        #endregion

        #region DedicatedHost
        /// <summary> Gets an object representing a DedicatedHost along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHost" /> object. </returns>
        public static DedicatedHost GetDedicatedHost(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                DedicatedHost.ValidateResourceId(id);
                return new DedicatedHost(client, id);
            }
            );
        }
        #endregion

        #region SshPublicKey
        /// <summary> Gets an object representing a SshPublicKey along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SshPublicKey" /> object. </returns>
        public static SshPublicKey GetSshPublicKey(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SshPublicKey.ValidateResourceId(id);
                return new SshPublicKey(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineExtensionImage
        /// <summary> Gets an object representing a VirtualMachineExtensionImage along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtensionImage" /> object. </returns>
        public static VirtualMachineExtensionImage GetVirtualMachineExtensionImage(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineExtensionImage.ValidateResourceId(id);
                return new VirtualMachineExtensionImage(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineExtension
        /// <summary> Gets an object representing a VirtualMachineExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtension" /> object. </returns>
        public static VirtualMachineExtension GetVirtualMachineExtension(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineExtension.ValidateResourceId(id);
                return new VirtualMachineExtension(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachine
        /// <summary> Gets an object representing a VirtualMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachine" /> object. </returns>
        public static VirtualMachine GetVirtualMachine(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachine.ValidateResourceId(id);
                return new VirtualMachine(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSet
        /// <summary> Gets an object representing a VirtualMachineScaleSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSet" /> object. </returns>
        public static VirtualMachineScaleSet GetVirtualMachineScaleSet(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineScaleSet.ValidateResourceId(id);
                return new VirtualMachineScaleSet(client, id);
            }
            );
        }
        #endregion

        #region Image
        /// <summary> Gets an object representing a Image along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Image" /> object. </returns>
        public static Image GetImage(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                Image.ValidateResourceId(id);
                return new Image(client, id);
            }
            );
        }
        #endregion

        #region RestorePointGroup
        /// <summary> Gets an object representing a RestorePointGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePointGroup" /> object. </returns>
        public static RestorePointGroup GetRestorePointGroup(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RestorePointGroup.ValidateResourceId(id);
                return new RestorePointGroup(client, id);
            }
            );
        }
        #endregion

        #region RestorePoint
        /// <summary> Gets an object representing a RestorePoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePoint" /> object. </returns>
        public static RestorePoint GetRestorePoint(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RestorePoint.ValidateResourceId(id);
                return new RestorePoint(client, id);
            }
            );
        }
        #endregion

        #region CapacityReservationGroup
        /// <summary> Gets an object representing a CapacityReservationGroup along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CapacityReservationGroup" /> object. </returns>
        public static CapacityReservationGroup GetCapacityReservationGroup(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                CapacityReservationGroup.ValidateResourceId(id);
                return new CapacityReservationGroup(client, id);
            }
            );
        }
        #endregion

        #region CapacityReservation
        /// <summary> Gets an object representing a CapacityReservation along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CapacityReservation" /> object. </returns>
        public static CapacityReservation GetCapacityReservation(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                CapacityReservation.ValidateResourceId(id);
                return new CapacityReservation(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetExtension
        /// <summary> Gets an object representing a VirtualMachineScaleSetExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetExtension" /> object. </returns>
        public static VirtualMachineScaleSetExtension GetVirtualMachineScaleSetExtension(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineScaleSetExtension.ValidateResourceId(id);
                return new VirtualMachineScaleSetExtension(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetRollingUpgrade
        /// <summary> Gets an object representing a VirtualMachineScaleSetRollingUpgrade along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetRollingUpgrade" /> object. </returns>
        public static VirtualMachineScaleSetRollingUpgrade GetVirtualMachineScaleSetRollingUpgrade(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineScaleSetRollingUpgrade.ValidateResourceId(id);
                return new VirtualMachineScaleSetRollingUpgrade(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetVmExtension
        /// <summary> Gets an object representing a VirtualMachineScaleSetVmExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVmExtension" /> object. </returns>
        public static VirtualMachineScaleSetVmExtension GetVirtualMachineScaleSetVmExtension(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineScaleSetVmExtension.ValidateResourceId(id);
                return new VirtualMachineScaleSetVmExtension(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetVm
        /// <summary> Gets an object representing a VirtualMachineScaleSetVm along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVm" /> object. </returns>
        public static VirtualMachineScaleSetVm GetVirtualMachineScaleSetVm(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineScaleSetVm.ValidateResourceId(id);
                return new VirtualMachineScaleSetVm(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineRunCommand
        /// <summary> Gets an object representing a VirtualMachineRunCommand along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineRunCommand" /> object. </returns>
        public static VirtualMachineRunCommand GetVirtualMachineRunCommand(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineRunCommand.ValidateResourceId(id);
                return new VirtualMachineRunCommand(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetVirtualMachineRunCommand
        /// <summary> Gets an object representing a VirtualMachineScaleSetVirtualMachineRunCommand along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVirtualMachineRunCommand" /> object. </returns>
        public static VirtualMachineScaleSetVirtualMachineRunCommand GetVirtualMachineScaleSetVirtualMachineRunCommand(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineScaleSetVirtualMachineRunCommand.ValidateResourceId(id);
                return new VirtualMachineScaleSetVirtualMachineRunCommand(client, id);
            }
            );
        }
        #endregion

        #region Disk
        /// <summary> Gets an object representing a Disk along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Disk" /> object. </returns>
        public static Disk GetDisk(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                Disk.ValidateResourceId(id);
                return new Disk(client, id);
            }
            );
        }
        #endregion

        #region Snapshot
        /// <summary> Gets an object representing a Snapshot along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Snapshot" /> object. </returns>
        public static Snapshot GetSnapshot(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                Snapshot.ValidateResourceId(id);
                return new Snapshot(client, id);
            }
            );
        }
        #endregion

        #region DiskEncryptionSet
        /// <summary> Gets an object representing a DiskEncryptionSet along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskEncryptionSet" /> object. </returns>
        public static DiskEncryptionSet GetDiskEncryptionSet(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                DiskEncryptionSet.ValidateResourceId(id);
                return new DiskEncryptionSet(client, id);
            }
            );
        }
        #endregion

        #region DiskAccess
        /// <summary> Gets an object representing a DiskAccess along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskAccess" /> object. </returns>
        public static DiskAccess GetDiskAccess(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                DiskAccess.ValidateResourceId(id);
                return new DiskAccess(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                PrivateEndpointConnection.ValidateResourceId(id);
                return new PrivateEndpointConnection(client, id);
            }
            );
        }
        #endregion

        #region DiskRestorePoint
        /// <summary> Gets an object representing a DiskRestorePoint along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskRestorePoint" /> object. </returns>
        public static DiskRestorePoint GetDiskRestorePoint(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                DiskRestorePoint.ValidateResourceId(id);
                return new DiskRestorePoint(client, id);
            }
            );
        }
        #endregion

        #region Gallery
        /// <summary> Gets an object representing a Gallery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Gallery" /> object. </returns>
        public static Gallery GetGallery(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                Gallery.ValidateResourceId(id);
                return new Gallery(client, id);
            }
            );
        }
        #endregion

        #region GalleryImage
        /// <summary> Gets an object representing a GalleryImage along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImage" /> object. </returns>
        public static GalleryImage GetGalleryImage(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                GalleryImage.ValidateResourceId(id);
                return new GalleryImage(client, id);
            }
            );
        }
        #endregion

        #region GalleryImageVersion
        /// <summary> Gets an object representing a GalleryImageVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImageVersion" /> object. </returns>
        public static GalleryImageVersion GetGalleryImageVersion(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                GalleryImageVersion.ValidateResourceId(id);
                return new GalleryImageVersion(client, id);
            }
            );
        }
        #endregion

        #region GalleryApplication
        /// <summary> Gets an object representing a GalleryApplication along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplication" /> object. </returns>
        public static GalleryApplication GetGalleryApplication(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                GalleryApplication.ValidateResourceId(id);
                return new GalleryApplication(client, id);
            }
            );
        }
        #endregion

        #region GalleryApplicationVersion
        /// <summary> Gets an object representing a GalleryApplicationVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplicationVersion" /> object. </returns>
        public static GalleryApplicationVersion GetGalleryApplicationVersion(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                GalleryApplicationVersion.ValidateResourceId(id);
                return new GalleryApplicationVersion(client, id);
            }
            );
        }
        #endregion

        #region SharedGallery
        /// <summary> Gets an object representing a SharedGallery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGallery" /> object. </returns>
        public static SharedGallery GetSharedGallery(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SharedGallery.ValidateResourceId(id);
                return new SharedGallery(client, id);
            }
            );
        }
        #endregion

        #region SharedGalleryImage
        /// <summary> Gets an object representing a SharedGalleryImage along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGalleryImage" /> object. </returns>
        public static SharedGalleryImage GetSharedGalleryImage(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SharedGalleryImage.ValidateResourceId(id);
                return new SharedGalleryImage(client, id);
            }
            );
        }
        #endregion

        #region SharedGalleryImageVersion
        /// <summary> Gets an object representing a SharedGalleryImageVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGalleryImageVersion" /> object. </returns>
        public static SharedGalleryImageVersion GetSharedGalleryImageVersion(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                SharedGalleryImageVersion.ValidateResourceId(id);
                return new SharedGalleryImageVersion(client, id);
            }
            );
        }
        #endregion

        #region RoleInstance
        /// <summary> Gets an object representing a RoleInstance along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RoleInstance" /> object. </returns>
        public static RoleInstance GetRoleInstance(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RoleInstance.ValidateResourceId(id);
                return new RoleInstance(client, id);
            }
            );
        }
        #endregion

        #region CloudServiceRole
        /// <summary> Gets an object representing a CloudServiceRole along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudServiceRole" /> object. </returns>
        public static CloudServiceRole GetCloudServiceRole(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                CloudServiceRole.ValidateResourceId(id);
                return new CloudServiceRole(client, id);
            }
            );
        }
        #endregion

        #region CloudService
        /// <summary> Gets an object representing a CloudService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudService" /> object. </returns>
        public static CloudService GetCloudService(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                CloudService.ValidateResourceId(id);
                return new CloudService(client, id);
            }
            );
        }
        #endregion

        #region OSVersion
        /// <summary> Gets an object representing a OSVersion along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OSVersion" /> object. </returns>
        public static OSVersion GetOSVersion(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                OSVersion.ValidateResourceId(id);
                return new OSVersion(client, id);
            }
            );
        }
        #endregion

        #region OSFamily
        /// <summary> Gets an object representing a OSFamily along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OSFamily" /> object. </returns>
        public static OSFamily GetOSFamily(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                OSFamily.ValidateResourceId(id);
                return new OSFamily(client, id);
            }
            );
        }
        #endregion
    }
}