// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region ResourcePool
        /// <summary> Gets an object representing a ResourcePool along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourcePool" /> object. </returns>
        public static ResourcePool GetResourcePool(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                ResourcePool.ValidateResourceId(id);
                return new ResourcePool(client, id);
            }
            );
        }
        #endregion

        #region VMwareCluster
        /// <summary> Gets an object representing a VMwareCluster along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMwareCluster" /> object. </returns>
        public static VMwareCluster GetVMwareCluster(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VMwareCluster.ValidateResourceId(id);
                return new VMwareCluster(client, id);
            }
            );
        }
        #endregion

        #region VMwareHost
        /// <summary> Gets an object representing a VMwareHost along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMwareHost" /> object. </returns>
        public static VMwareHost GetVMwareHost(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VMwareHost.ValidateResourceId(id);
                return new VMwareHost(client, id);
            }
            );
        }
        #endregion

        #region VMwareDatastore
        /// <summary> Gets an object representing a VMwareDatastore along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMwareDatastore" /> object. </returns>
        public static VMwareDatastore GetVMwareDatastore(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VMwareDatastore.ValidateResourceId(id);
                return new VMwareDatastore(client, id);
            }
            );
        }
        #endregion

        #region VCenter
        /// <summary> Gets an object representing a VCenter along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VCenter" /> object. </returns>
        public static VCenter GetVCenter(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VCenter.ValidateResourceId(id);
                return new VCenter(client, id);
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

        #region VirtualMachineTemplate
        /// <summary> Gets an object representing a VirtualMachineTemplate along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineTemplate" /> object. </returns>
        public static VirtualMachineTemplate GetVirtualMachineTemplate(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualMachineTemplate.ValidateResourceId(id);
                return new VirtualMachineTemplate(client, id);
            }
            );
        }
        #endregion

        #region VirtualNetwork
        /// <summary> Gets an object representing a VirtualNetwork along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualNetwork" /> object. </returns>
        public static VirtualNetwork GetVirtualNetwork(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                VirtualNetwork.ValidateResourceId(id);
                return new VirtualNetwork(client, id);
            }
            );
        }
        #endregion

        #region InventoryItem
        /// <summary> Gets an object representing a InventoryItem along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="InventoryItem" /> object. </returns>
        public static InventoryItem GetInventoryItem(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                InventoryItem.ValidateResourceId(id);
                return new InventoryItem(client, id);
            }
            );
        }
        #endregion

        #region HybridIdentityMetadata
        /// <summary> Gets an object representing a HybridIdentityMetadata along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridIdentityMetadata" /> object. </returns>
        public static HybridIdentityMetadata GetHybridIdentityMetadata(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                HybridIdentityMetadata.ValidateResourceId(id);
                return new HybridIdentityMetadata(client, id);
            }
            );
        }
        #endregion

        #region MachineExtension
        /// <summary> Gets an object representing a MachineExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MachineExtension" /> object. </returns>
        public static MachineExtension GetMachineExtension(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                MachineExtension.ValidateResourceId(id);
                return new MachineExtension(client, id);
            }
            );
        }
        #endregion

        #region GuestAgent
        /// <summary> Gets an object representing a GuestAgent along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GuestAgent" /> object. </returns>
        public static GuestAgent GetGuestAgent(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                GuestAgent.ValidateResourceId(id);
                return new GuestAgent(client, id);
            }
            );
        }
        #endregion
    }
}
