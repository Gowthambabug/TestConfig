// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The expansion result values.
    /// </summary>
    public partial class EntityExpandResponseValue
    {
        /// <summary>
        /// Initializes a new instance of the EntityExpandResponseValue class.
        /// </summary>
        public EntityExpandResponseValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityExpandResponseValue class.
        /// </summary>
        /// <param name="entities">Array of the expansion result
        /// entities.</param>
        /// <param name="edges">Array of edges that connects the entity to the
        /// list of entities.</param>
        public EntityExpandResponseValue(IList<Entity> entities = default(IList<Entity>), IList<EntityEdges> edges = default(IList<EntityEdges>))
        {
            Entities = entities;
            Edges = edges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of the expansion result entities.
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or sets array of edges that connects the entity to the list of
        /// entities.
        /// </summary>
        [JsonProperty(PropertyName = "edges")]
        public IList<EntityEdges> Edges { get; set; }

    }
}