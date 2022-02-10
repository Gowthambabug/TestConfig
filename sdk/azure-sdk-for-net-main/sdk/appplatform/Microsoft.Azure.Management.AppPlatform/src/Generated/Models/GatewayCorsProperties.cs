// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cross-Origin Resource Sharing property
    /// </summary>
    public partial class GatewayCorsProperties
    {
        /// <summary>
        /// Initializes a new instance of the GatewayCorsProperties class.
        /// </summary>
        public GatewayCorsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayCorsProperties class.
        /// </summary>
        /// <param name="allowedOrigins">Allowed origins to make cross-site
        /// requests. The special value `*` allows all domains.</param>
        /// <param name="allowedMethods">Allowed HTTP methods on cross-site
        /// requests. The special value `*` allows all methods. If not set,
        /// `GET` and `HEAD` are allowed by default.</param>
        /// <param name="allowedHeaders">Allowed headers in cross-site
        /// requests. The special value `*` allows actual requests to send any
        /// header.</param>
        /// <param name="maxAge">How long, in seconds, the response from a
        /// pre-flight request can be cached by clients.</param>
        /// <param name="allowCredentials">Whether user credentials are
        /// supported on cross-site requests. Valid values: `true`,
        /// `false`.</param>
        /// <param name="exposedHeaders">HTTP response headers to expose for
        /// cross-site requests.</param>
        public GatewayCorsProperties(IList<string> allowedOrigins = default(IList<string>), IList<string> allowedMethods = default(IList<string>), IList<string> allowedHeaders = default(IList<string>), int? maxAge = default(int?), bool? allowCredentials = default(bool?), IList<string> exposedHeaders = default(IList<string>))
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            AllowedHeaders = allowedHeaders;
            MaxAge = maxAge;
            AllowCredentials = allowCredentials;
            ExposedHeaders = exposedHeaders;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowed origins to make cross-site requests. The
        /// special value `*` allows all domains.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOrigins")]
        public IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or sets allowed HTTP methods on cross-site requests. The
        /// special value `*` allows all methods. If not set, `GET` and `HEAD`
        /// are allowed by default.
        /// </summary>
        [JsonProperty(PropertyName = "allowedMethods")]
        public IList<string> AllowedMethods { get; set; }

        /// <summary>
        /// Gets or sets allowed headers in cross-site requests. The special
        /// value `*` allows actual requests to send any header.
        /// </summary>
        [JsonProperty(PropertyName = "allowedHeaders")]
        public IList<string> AllowedHeaders { get; set; }

        /// <summary>
        /// Gets or sets how long, in seconds, the response from a pre-flight
        /// request can be cached by clients.
        /// </summary>
        [JsonProperty(PropertyName = "maxAge")]
        public int? MaxAge { get; set; }

        /// <summary>
        /// Gets or sets whether user credentials are supported on cross-site
        /// requests. Valid values: `true`, `false`.
        /// </summary>
        [JsonProperty(PropertyName = "allowCredentials")]
        public bool? AllowCredentials { get; set; }

        /// <summary>
        /// Gets or sets HTTP response headers to expose for cross-site
        /// requests.
        /// </summary>
        [JsonProperty(PropertyName = "exposedHeaders")]
        public IList<string> ExposedHeaders { get; set; }

    }
}