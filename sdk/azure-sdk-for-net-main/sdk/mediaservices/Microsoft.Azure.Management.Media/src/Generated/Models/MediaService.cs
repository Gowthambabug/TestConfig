// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Media Services account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MediaService : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the MediaService class.
        /// </summary>
        public MediaService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaService class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="mediaServiceId">The Media Services account ID.</param>
        /// <param name="storageAccounts">The storage accounts for this
        /// resource.</param>
        /// <param name="storageAuthentication">Possible values include:
        /// 'System', 'ManagedIdentity'</param>
        /// <param name="encryption">The account encryption properties.</param>
        /// <param name="keyDelivery">The Key Delivery properties for Media
        /// Services account.</param>
        /// <param name="publicNetworkAccess">Whether or not public network
        /// access is allowed for resources under the Media Services account.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="identity">The Managed Identity for the Media Services
        /// account.</param>
        /// <param name="systemData">The system metadata relating to this
        /// resource.</param>
        public MediaService(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.Guid mediaServiceId = default(System.Guid), IList<StorageAccount> storageAccounts = default(IList<StorageAccount>), StorageAuthentication? storageAuthentication = default(StorageAuthentication?), AccountEncryption encryption = default(AccountEncryption), KeyDelivery keyDelivery = default(KeyDelivery), PublicNetworkAccess? publicNetworkAccess = default(PublicNetworkAccess?), MediaServiceIdentity identity = default(MediaServiceIdentity), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            MediaServiceId = mediaServiceId;
            StorageAccounts = storageAccounts;
            StorageAuthentication = storageAuthentication;
            Encryption = encryption;
            KeyDelivery = keyDelivery;
            PublicNetworkAccess = publicNetworkAccess;
            Identity = identity;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Media Services account ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mediaServiceId")]
        public System.Guid MediaServiceId { get; private set; }

        /// <summary>
        /// Gets or sets the storage accounts for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<StorageAccount> StorageAccounts { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'System', 'ManagedIdentity'
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAuthentication")]
        public StorageAuthentication? StorageAuthentication { get; set; }

        /// <summary>
        /// Gets or sets the account encryption properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public AccountEncryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets the Key Delivery properties for Media Services
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyDelivery")]
        public KeyDelivery KeyDelivery { get; set; }

        /// <summary>
        /// Gets or sets whether or not public network access is allowed for
        /// resources under the Media Services account. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets the Managed Identity for the Media Services account.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public MediaServiceIdentity Identity { get; set; }

        /// <summary>
        /// Gets the system metadata relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (StorageAccounts != null)
            {
                foreach (var element in StorageAccounts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}