// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a Kusto cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="sku">The SKU of the cluster.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="zones">The availability zones of the cluster.</param>
        /// <param name="identity">The identity of the cluster, if
        /// configured.</param>
        /// <param name="state">The state of the resource. Possible values
        /// include: 'Creating', 'Unavailable', 'Running', 'Deleting',
        /// 'Deleted', 'Stopping', 'Stopped', 'Starting', 'Updating'</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Running', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Moving'</param>
        /// <param name="uri">The cluster URI.</param>
        /// <param name="dataIngestionUri">The cluster data ingestion
        /// URI.</param>
        /// <param name="stateReason">The reason for the cluster's current
        /// state.</param>
        /// <param name="trustedExternalTenants">The cluster's external
        /// tenants.</param>
        /// <param name="optimizedAutoscale">Optimized auto scale
        /// definition.</param>
        /// <param name="enableDiskEncryption">A boolean value that indicates
        /// if the cluster's disks are encrypted.</param>
        /// <param name="enableStreamingIngest">A boolean value that indicates
        /// if the streaming ingest is enabled.</param>
        /// <param name="virtualNetworkConfiguration">Virtual network
        /// definition.</param>
        /// <param name="keyVaultProperties">KeyVault properties for the
        /// cluster encryption.</param>
        /// <param name="enablePurge">A boolean value that indicates if the
        /// purge operations are enabled.</param>
        /// <param name="languageExtensions">List of the cluster's language
        /// extensions.</param>
        /// <param name="enableDoubleEncryption">A boolean value that indicates
        /// if double encryption is enabled.</param>
        /// <param name="publicNetworkAccess">Public network access to the
        /// cluster is enabled by default. When disabled, only private endpoint
        /// connection to the cluster is allowed. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="allowedIpRangeList">The list of ips in the format of
        /// CIDR allowed to connect to the cluster.</param>
        /// <param name="engineType">The engine type. Possible values include:
        /// 'V2', 'V3'</param>
        /// <param name="acceptedAudiences">The cluster's accepted
        /// audiences.</param>
        /// <param name="enableAutoStop">A boolean value that indicates if the
        /// cluster could be automatically stopped (due to lack of data or no
        /// activity for many days).</param>
        /// <param name="restrictOutboundNetworkAccess">Whether or not to
        /// restrict outbound network access.  Value is optional but if passed
        /// in, must be 'Enabled' or 'Disabled'. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="allowedFqdnList">List of allowed FQDNs(Fully Qualified
        /// Domain Name) for egress from Cluster.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public Cluster(string location, AzureSku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), IList<string> zones = default(IList<string>), Identity identity = default(Identity), string state = default(string), string provisioningState = default(string), string uri = default(string), string dataIngestionUri = default(string), string stateReason = default(string), IList<TrustedExternalTenant> trustedExternalTenants = default(IList<TrustedExternalTenant>), OptimizedAutoscale optimizedAutoscale = default(OptimizedAutoscale), bool? enableDiskEncryption = default(bool?), bool? enableStreamingIngest = default(bool?), VirtualNetworkConfiguration virtualNetworkConfiguration = default(VirtualNetworkConfiguration), KeyVaultProperties keyVaultProperties = default(KeyVaultProperties), bool? enablePurge = default(bool?), LanguageExtensionsList languageExtensions = default(LanguageExtensionsList), bool? enableDoubleEncryption = default(bool?), string publicNetworkAccess = default(string), IList<string> allowedIpRangeList = default(IList<string>), string engineType = default(string), IList<AcceptedAudiences> acceptedAudiences = default(IList<AcceptedAudiences>), bool? enableAutoStop = default(bool?), string restrictOutboundNetworkAccess = default(string), IList<string> allowedFqdnList = default(IList<string>), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            SystemData = systemData;
            Zones = zones;
            Identity = identity;
            State = state;
            ProvisioningState = provisioningState;
            Uri = uri;
            DataIngestionUri = dataIngestionUri;
            StateReason = stateReason;
            TrustedExternalTenants = trustedExternalTenants;
            OptimizedAutoscale = optimizedAutoscale;
            EnableDiskEncryption = enableDiskEncryption;
            EnableStreamingIngest = enableStreamingIngest;
            VirtualNetworkConfiguration = virtualNetworkConfiguration;
            KeyVaultProperties = keyVaultProperties;
            EnablePurge = enablePurge;
            LanguageExtensions = languageExtensions;
            EnableDoubleEncryption = enableDoubleEncryption;
            PublicNetworkAccess = publicNetworkAccess;
            AllowedIpRangeList = allowedIpRangeList;
            EngineType = engineType;
            AcceptedAudiences = acceptedAudiences;
            EnableAutoStop = enableAutoStop;
            RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
            AllowedFqdnList = allowedFqdnList;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public AzureSku Sku { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets the availability zones of the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Gets or sets the identity of the cluster, if configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets the state of the resource. Possible values include:
        /// 'Creating', 'Unavailable', 'Running', 'Deleting', 'Deleted',
        /// 'Stopping', 'Stopped', 'Starting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the provisioned state of the resource. Possible values
        /// include: 'Running', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the cluster URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uri")]
        public string Uri { get; private set; }

        /// <summary>
        /// Gets the cluster data ingestion URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataIngestionUri")]
        public string DataIngestionUri { get; private set; }

        /// <summary>
        /// Gets the reason for the cluster's current state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stateReason")]
        public string StateReason { get; private set; }

        /// <summary>
        /// Gets or sets the cluster's external tenants.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trustedExternalTenants")]
        public IList<TrustedExternalTenant> TrustedExternalTenants { get; set; }

        /// <summary>
        /// Gets or sets optimized auto scale definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.optimizedAutoscale")]
        public OptimizedAutoscale OptimizedAutoscale { get; set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if the cluster's disks
        /// are encrypted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableDiskEncryption")]
        public bool? EnableDiskEncryption { get; set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if the streaming ingest
        /// is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableStreamingIngest")]
        public bool? EnableStreamingIngest { get; set; }

        /// <summary>
        /// Gets or sets virtual network definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkConfiguration")]
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets keyVault properties for the cluster encryption.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultProperties")]
        public KeyVaultProperties KeyVaultProperties { get; set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if the purge operations
        /// are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enablePurge")]
        public bool? EnablePurge { get; set; }

        /// <summary>
        /// Gets list of the cluster's language extensions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.languageExtensions")]
        public LanguageExtensionsList LanguageExtensions { get; private set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if double encryption is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableDoubleEncryption")]
        public bool? EnableDoubleEncryption { get; set; }

        /// <summary>
        /// Gets or sets public network access to the cluster is enabled by
        /// default. When disabled, only private endpoint connection to the
        /// cluster is allowed. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets the list of ips in the format of CIDR allowed to
        /// connect to the cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedIpRangeList")]
        public IList<string> AllowedIpRangeList { get; set; }

        /// <summary>
        /// Gets or sets the engine type. Possible values include: 'V2', 'V3'
        /// </summary>
        [JsonProperty(PropertyName = "properties.engineType")]
        public string EngineType { get; set; }

        /// <summary>
        /// Gets or sets the cluster's accepted audiences.
        /// </summary>
        [JsonProperty(PropertyName = "properties.acceptedAudiences")]
        public IList<AcceptedAudiences> AcceptedAudiences { get; set; }

        /// <summary>
        /// Gets or sets a boolean value that indicates if the cluster could be
        /// automatically stopped (due to lack of data or no activity for many
        /// days).
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAutoStop")]
        public bool? EnableAutoStop { get; set; }

        /// <summary>
        /// Gets or sets whether or not to restrict outbound network access.
        /// Value is optional but if passed in, must be 'Enabled' or
        /// 'Disabled'. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.restrictOutboundNetworkAccess")]
        public string RestrictOutboundNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets list of allowed FQDNs(Fully Qualified Domain Name) for
        /// egress from Cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedFqdnList")]
        public IList<string> AllowedFqdnList { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
            if (OptimizedAutoscale != null)
            {
                OptimizedAutoscale.Validate();
            }
            if (VirtualNetworkConfiguration != null)
            {
                VirtualNetworkConfiguration.Validate();
            }
        }
    }
}
