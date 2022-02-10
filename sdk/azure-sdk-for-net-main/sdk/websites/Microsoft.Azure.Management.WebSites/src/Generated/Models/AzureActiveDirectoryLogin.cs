// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the Azure Active Directory login flow.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AzureActiveDirectoryLogin : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryLogin class.
        /// </summary>
        public AzureActiveDirectoryLogin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryLogin class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="loginParameters">Login parameters to send to the
        /// OpenID Connect authorization endpoint when
        /// a user logs in. Each parameter must be in the form
        /// "key=value".</param>
        public AzureActiveDirectoryLogin(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), bool? disableWWWAuthenticate = default(bool?), IList<string> loginParameters = default(IList<string>))
            : base(id, name, kind, type)
        {
            DisableWWWAuthenticate = disableWWWAuthenticate;
            LoginParameters = loginParameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableWWWAuthenticate")]
        public bool? DisableWWWAuthenticate { get; set; }

        /// <summary>
        /// Gets or sets login parameters to send to the OpenID Connect
        /// authorization endpoint when
        /// a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        [JsonProperty(PropertyName = "properties.loginParameters")]
        public IList<string> LoginParameters { get; set; }

    }
}