// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Apple provider. </summary>
    public partial class Apple
    {
        /// <summary> Initializes a new instance of Apple. </summary>
        public Apple()
        {
        }

        /// <summary> Initializes a new instance of Apple. </summary>
        /// <param name="enabled"> &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the Apple registration. </param>
        /// <param name="login"> The configuration settings of the login flow. </param>
        internal Apple(bool? enabled, AppleRegistration registration, LoginScopes login)
        {
            Enabled = enabled;
            Registration = registration;
            Login = login;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Apple provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The configuration settings of the Apple registration. </summary>
        public AppleRegistration Registration { get; set; }
        /// <summary> The configuration settings of the login flow. </summary>
        public LoginScopes Login { get; set; }
    }
}