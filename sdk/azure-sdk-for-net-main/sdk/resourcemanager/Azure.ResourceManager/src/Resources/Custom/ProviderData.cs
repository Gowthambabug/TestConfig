// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the Provider data model. </summary>
    [PropertyReferenceType]
    [JsonConverter(typeof(ProviderDataConverter))]
    public partial class ProviderData
    {
        /// <summary> Initializes a new instance of ProviderData. </summary>
        [InitializationConstructor]
        public ProviderData()
        {
            ResourceTypes = new ChangeTrackingList<ProviderResourceType>();
        }

        /// <summary> Initializes a new instance of ProviderData. </summary>
        /// <param name="id"> The provider ID. </param>
        /// <param name="namespace"> The namespace of the resource provider. </param>
        /// <param name="registrationState"> The registration state of the resource provider. </param>
        /// <param name="registrationPolicy"> The registration policy of the resource provider. </param>
        /// <param name="resourceTypes"> The collection of provider resource types. </param>
        /// <param name="providerAuthorizationConsentState"> The provider authorization consent state. </param>
        [SerializationConstructor]
        internal ProviderData(ResourceIdentifier id, string @namespace, string registrationState, string registrationPolicy, IReadOnlyList<ProviderResourceType> resourceTypes, ProviderAuthorizationConsentState? providerAuthorizationConsentState)
        {
            Id = id;
            Namespace = @namespace;
            RegistrationState = registrationState;
            RegistrationPolicy = registrationPolicy;
            ResourceTypes = resourceTypes;
            ProviderAuthorizationConsentState = providerAuthorizationConsentState;
        }

        /// <summary> The provider ID. </summary>
        public ResourceIdentifier Id { get; }

        internal partial class ProviderDataConverter : JsonConverter<ProviderData>
        {
            public override void Write(Utf8JsonWriter writer, ProviderData providerData, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(providerData);
            }
            public override ProviderData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeProviderData(document.RootElement);
            }
        }
    }
}