// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the CapacityReservationGroup data model. </summary>
    public partial class CapacityReservationGroupData : TrackedResource
    {
        /// <summary> Initializes a new instance of CapacityReservationGroupData. </summary>
        /// <param name="location"> The location. </param>
        public CapacityReservationGroupData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
            CapacityReservations = new ChangeTrackingList<Resources.Models.SubResource>();
            VirtualMachinesAssociated = new ChangeTrackingList<Resources.Models.SubResource>();
        }

        /// <summary> Initializes a new instance of CapacityReservationGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> Availability Zones to use for this capacity reservation group. The zones can be assigned only during creation. If not provided, the group supports only regional resources in the region. If provided, enforces each capacity reservation in the group to be in one of the zones. </param>
        /// <param name="capacityReservations"> A list of all capacity reservation resource ids that belong to capacity reservation group. </param>
        /// <param name="virtualMachinesAssociated"> A list of references to all virtual machines associated to the capacity reservation group. </param>
        /// <param name="instanceView"> The capacity reservation group instance view which has the list of instance views for all the capacity reservations that belong to the capacity reservation group. </param>
        internal CapacityReservationGroupData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<string> zones, IReadOnlyList<Resources.Models.SubResource> capacityReservations, IReadOnlyList<Resources.Models.SubResource> virtualMachinesAssociated, CapacityReservationGroupInstanceView instanceView) : base(id, name, type, systemData, tags, location)
        {
            Zones = zones;
            CapacityReservations = capacityReservations;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            InstanceView = instanceView;
        }

        /// <summary> Availability Zones to use for this capacity reservation group. The zones can be assigned only during creation. If not provided, the group supports only regional resources in the region. If provided, enforces each capacity reservation in the group to be in one of the zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> A list of all capacity reservation resource ids that belong to capacity reservation group. </summary>
        public IReadOnlyList<Resources.Models.SubResource> CapacityReservations { get; }
        /// <summary> A list of references to all virtual machines associated to the capacity reservation group. </summary>
        public IReadOnlyList<Resources.Models.SubResource> VirtualMachinesAssociated { get; }
        /// <summary> The capacity reservation group instance view which has the list of instance views for all the capacity reservations that belong to the capacity reservation group. </summary>
        public CapacityReservationGroupInstanceView InstanceView { get; }
    }
}