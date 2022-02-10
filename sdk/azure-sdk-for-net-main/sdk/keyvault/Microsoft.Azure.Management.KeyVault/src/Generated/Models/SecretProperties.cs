// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of the secret
    /// </summary>
    public partial class SecretProperties
    {
        /// <summary>
        /// Initializes a new instance of the SecretProperties class.
        /// </summary>
        public SecretProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecretProperties class.
        /// </summary>
        /// <param name="value">The value of the secret. NOTE: 'value' will
        /// never be returned from the service, as APIs using this model are is
        /// intended for internal use in ARM deployments. Users should use the
        /// data-plane REST service for interaction with vault secrets.</param>
        /// <param name="contentType">The content type of the secret.</param>
        /// <param name="attributes">The attributes of the secret.</param>
        /// <param name="secretUri">The URI to retrieve the current version of
        /// the secret.</param>
        /// <param name="secretUriWithVersion">The URI to retrieve the specific
        /// version of the secret.</param>
        public SecretProperties(string value = default(string), string contentType = default(string), SecretAttributes attributes = default(SecretAttributes), string secretUri = default(string), string secretUriWithVersion = default(string))
        {
            Value = value;
            ContentType = contentType;
            Attributes = attributes;
            SecretUri = secretUri;
            SecretUriWithVersion = secretUriWithVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value of the secret. NOTE: 'value' will never be
        /// returned from the service, as APIs using this model are is intended
        /// for internal use in ARM deployments. Users should use the
        /// data-plane REST service for interaction with vault secrets.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the content type of the secret.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the attributes of the secret.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public SecretAttributes Attributes { get; set; }

        /// <summary>
        /// Gets the URI to retrieve the current version of the secret.
        /// </summary>
        [JsonProperty(PropertyName = "secretUri")]
        public string SecretUri { get; private set; }

        /// <summary>
        /// Gets the URI to retrieve the specific version of the secret.
        /// </summary>
        [JsonProperty(PropertyName = "secretUriWithVersion")]
        public string SecretUriWithVersion { get; private set; }

    }
}