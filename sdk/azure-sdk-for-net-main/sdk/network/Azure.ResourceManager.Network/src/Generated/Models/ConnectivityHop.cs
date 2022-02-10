// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information about a hop between the source and the destination. </summary>
    public partial class ConnectivityHop
    {
        /// <summary> Initializes a new instance of ConnectivityHop. </summary>
        internal ConnectivityHop()
        {
            NextHopIds = new ChangeTrackingList<string>();
            PreviousHopIds = new ChangeTrackingList<string>();
            Links = new ChangeTrackingList<HopLink>();
            PreviousLinks = new ChangeTrackingList<HopLink>();
            Issues = new ChangeTrackingList<ConnectivityIssue>();
        }

        /// <summary> Initializes a new instance of ConnectivityHop. </summary>
        /// <param name="type"> The type of the hop. </param>
        /// <param name="id"> The ID of the hop. </param>
        /// <param name="address"> The IP address of the hop. </param>
        /// <param name="resourceId"> The ID of the resource corresponding to this hop. </param>
        /// <param name="nextHopIds"> List of next hop identifiers. </param>
        /// <param name="previousHopIds"> List of previous hop identifiers. </param>
        /// <param name="links"> List of hop links. </param>
        /// <param name="previousLinks"> List of previous hop links. </param>
        /// <param name="issues"> List of issues. </param>
        internal ConnectivityHop(string type, string id, string address, string resourceId, IReadOnlyList<string> nextHopIds, IReadOnlyList<string> previousHopIds, IReadOnlyList<HopLink> links, IReadOnlyList<HopLink> previousLinks, IReadOnlyList<ConnectivityIssue> issues)
        {
            Type = type;
            Id = id;
            Address = address;
            ResourceId = resourceId;
            NextHopIds = nextHopIds;
            PreviousHopIds = previousHopIds;
            Links = links;
            PreviousLinks = previousLinks;
            Issues = issues;
        }

        /// <summary> The type of the hop. </summary>
        public string Type { get; }
        /// <summary> The ID of the hop. </summary>
        public string Id { get; }
        /// <summary> The IP address of the hop. </summary>
        public string Address { get; }
        /// <summary> The ID of the resource corresponding to this hop. </summary>
        public string ResourceId { get; }
        /// <summary> List of next hop identifiers. </summary>
        public IReadOnlyList<string> NextHopIds { get; }
        /// <summary> List of previous hop identifiers. </summary>
        public IReadOnlyList<string> PreviousHopIds { get; }
        /// <summary> List of hop links. </summary>
        public IReadOnlyList<HopLink> Links { get; }
        /// <summary> List of previous hop links. </summary>
        public IReadOnlyList<HopLink> PreviousLinks { get; }
        /// <summary> List of issues. </summary>
        public IReadOnlyList<ConnectivityIssue> Issues { get; }
    }
}