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
    /// Whois information for a given domain and associated metadata
    /// </summary>
    public partial class EnrichmentDomainWhois
    {
        /// <summary>
        /// Initializes a new instance of the EnrichmentDomainWhois class.
        /// </summary>
        public EnrichmentDomainWhois()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnrichmentDomainWhois class.
        /// </summary>
        /// <param name="domain">The domain for this whois record</param>
        /// <param name="server">The hostname of this registrar's whois
        /// server</param>
        /// <param name="created">The timestamp at which this record was
        /// created</param>
        /// <param name="updated">The timestamp at which this record was last
        /// updated</param>
        /// <param name="expires">The timestamp at which this record will
        /// expire</param>
        /// <param name="parsedWhois">The whois record for a given
        /// domain</param>
        public EnrichmentDomainWhois(string domain = default(string), string server = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?), System.DateTime? expires = default(System.DateTime?), EnrichmentDomainWhoisDetails parsedWhois = default(EnrichmentDomainWhoisDetails))
        {
            Domain = domain;
            Server = server;
            Created = created;
            Updated = updated;
            Expires = expires;
            ParsedWhois = parsedWhois;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the domain for this whois record
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the hostname of this registrar's whois server
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string Server { get; set; }

        /// <summary>
        /// Gets or sets the timestamp at which this record was created
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets the timestamp at which this record was last updated
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public System.DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or sets the timestamp at which this record will expire
        /// </summary>
        [JsonProperty(PropertyName = "expires")]
        public System.DateTime? Expires { get; set; }

        /// <summary>
        /// Gets or sets the whois record for a given domain
        /// </summary>
        [JsonProperty(PropertyName = "parsedWhois")]
        public EnrichmentDomainWhoisDetails ParsedWhois { get; set; }

    }
}