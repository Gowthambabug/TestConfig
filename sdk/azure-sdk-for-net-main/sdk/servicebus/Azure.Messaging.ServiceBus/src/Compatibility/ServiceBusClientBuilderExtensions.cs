// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Extensions;
using Azure.Messaging.ServiceBus;
using Azure.Messaging.ServiceBus.Administration;

namespace Microsoft.Extensions.Azure
{
    /// <summary>
    ///    The set of extensions to add the Service Bus client types to the clients builder
    /// </summary>
    public static class ServiceBusClientBuilderExtensions
    {
        /// <summary>
        ///   Registers a <see cref="ServiceBusClient "/> instance with the provided <paramref name="connectionString"/>.
        /// </summary>
        ///
        public static IAzureClientBuilder<ServiceBusClient, ServiceBusClientOptions> AddServiceBusClient<TBuilder>(this TBuilder builder, string connectionString)
            where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ServiceBusClient, ServiceBusClientOptions>(options => new ServiceBusClient(connectionString, options));
        }

        /// <summary>
        ///   Registers a <see cref="ServiceBusClient"/> instance with the provided <paramref name="fullyQualifiedNamespace"/>.
        /// </summary>
        ///
        public static IAzureClientBuilder<ServiceBusClient, ServiceBusClientOptions> AddServiceBusClientWithNamespace<TBuilder>(this TBuilder builder, string fullyQualifiedNamespace)
            where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<ServiceBusClient, ServiceBusClientOptions>((options, token) => new ServiceBusClient(fullyQualifiedNamespace, token, options));
        }

        /// <summary>
        ///   Registers a <see cref="ServiceBusClient"/> instance with connection options loaded from the provided <paramref name="configuration"/> instance.
        /// </summary>
        ///
        public static IAzureClientBuilder<ServiceBusClient, ServiceBusClientOptions> AddServiceBusClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ServiceBusClient, ServiceBusClientOptions>(configuration);
        }

        /// <summary>
        ///   Registers a <see cref="ServiceBusAdministrationClient "/> instance with the provided <paramref name="connectionString"/>.
        /// </summary>
        ///
        public static IAzureClientBuilder<ServiceBusAdministrationClient, ServiceBusAdministrationClientOptions> AddServiceAdministrationBusClient<TBuilder>(this TBuilder builder, string connectionString)
            where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ServiceBusAdministrationClient, ServiceBusAdministrationClientOptions>(options => new ServiceBusAdministrationClient(connectionString, options));
        }

        /// <summary>
        ///   Registers a <see cref="ServiceBusAdministrationClient"/> instance with the provided <paramref name="fullyQualifiedNamespace"/>.
        /// </summary>
        ///
        public static IAzureClientBuilder<ServiceBusAdministrationClient, ServiceBusAdministrationClientOptions> AddServiceBusAdministrationClientWithNamespace<TBuilder>(this TBuilder builder, string fullyQualifiedNamespace)
            where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<ServiceBusAdministrationClient, ServiceBusAdministrationClientOptions>((options, token) => new ServiceBusAdministrationClient(fullyQualifiedNamespace, token, options));
        }

        /// <summary>
        ///   Registers a <see cref="ServiceBusAdministrationClient"/> instance with connection options loaded from the provided <paramref name="configuration"/> instance.
        /// </summary>
        ///
        public static IAzureClientBuilder<ServiceBusAdministrationClient, ServiceBusAdministrationClientOptions> AddServiceBusAdministrationClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
            where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ServiceBusAdministrationClient, ServiceBusAdministrationClientOptions>(configuration);
        }
    }
}
