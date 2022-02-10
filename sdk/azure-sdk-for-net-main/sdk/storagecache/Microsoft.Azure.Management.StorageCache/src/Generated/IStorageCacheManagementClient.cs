// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// A Storage Cache provides scalable caching service for NAS clients,
    /// serving data from either NFSv3 or Blob at-rest storage (referred to as
    /// "Storage Targets"). These operations allow you to manage Caches.
    /// </summary>
    public partial interface IStorageCacheManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client API version.
        /// </summary>
        string ApiVersion { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the ISkus.
        /// </summary>
        ISkus Skus { get; }

        /// <summary>
        /// Gets the IUsageModels.
        /// </summary>
        IUsageModels UsageModels { get; }

        /// <summary>
        /// Gets the IAscOperations.
        /// </summary>
        IAscOperations AscOperations { get; }

        /// <summary>
        /// Gets the ICaches.
        /// </summary>
        ICaches Caches { get; }

        /// <summary>
        /// Gets the IStorageTargets.
        /// </summary>
        IStorageTargets StorageTargets { get; }

    }
}