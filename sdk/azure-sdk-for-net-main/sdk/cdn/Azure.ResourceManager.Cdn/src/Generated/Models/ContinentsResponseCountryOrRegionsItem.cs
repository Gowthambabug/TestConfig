// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The ContinentsResponseCountryOrRegionsItem. </summary>
    public partial class ContinentsResponseCountryOrRegionsItem
    {
        /// <summary> Initializes a new instance of ContinentsResponseCountryOrRegionsItem. </summary>
        internal ContinentsResponseCountryOrRegionsItem()
        {
        }

        /// <summary> Initializes a new instance of ContinentsResponseCountryOrRegionsItem. </summary>
        /// <param name="id"></param>
        /// <param name="continentId"></param>
        internal ContinentsResponseCountryOrRegionsItem(string id, string continentId)
        {
            Id = id;
            ContinentId = continentId;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the continent id. </summary>
        public string ContinentId { get; }
    }
}