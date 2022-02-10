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
    using System.Linq;

    /// <summary>
    /// The Activity query definitions
    /// </summary>
    public partial class ActivityEntityQueriesPropertiesQueryDefinitions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ActivityEntityQueriesPropertiesQueryDefinitions class.
        /// </summary>
        public ActivityEntityQueriesPropertiesQueryDefinitions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ActivityEntityQueriesPropertiesQueryDefinitions class.
        /// </summary>
        /// <param name="query">The Activity query to run on a given
        /// entity</param>
        public ActivityEntityQueriesPropertiesQueryDefinitions(string query = default(string))
        {
            Query = query;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Activity query to run on a given entity
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

    }
}