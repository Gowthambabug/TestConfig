// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Profile for gallery sharing to subscription or tenant
    /// </summary>
    public partial class SharingProfile
    {
        /// <summary>
        /// Initializes a new instance of the SharingProfile class.
        /// </summary>
        public SharingProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharingProfile class.
        /// </summary>
        /// <param name="permissions">This property allows you to specify the
        /// permission of sharing gallery. &lt;br&gt;&lt;br&gt; Possible values
        /// are: &lt;br&gt;&lt;br&gt; **Private** &lt;br&gt;&lt;br&gt;
        /// **Groups**. Possible values include: 'Private', 'Groups'</param>
        /// <param name="groups">A list of sharing profile groups.</param>
        public SharingProfile(string permissions = default(string), IList<SharingProfileGroup> groups = default(IList<SharingProfileGroup>))
        {
            Permissions = permissions;
            Groups = groups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this property allows you to specify the permission of
        /// sharing gallery. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible
        /// values are: &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Private**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Groups**. Possible values
        /// include: 'Private', 'Groups'
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// Gets a list of sharing profile groups.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<SharingProfileGroup> Groups { get; private set; }

    }
}