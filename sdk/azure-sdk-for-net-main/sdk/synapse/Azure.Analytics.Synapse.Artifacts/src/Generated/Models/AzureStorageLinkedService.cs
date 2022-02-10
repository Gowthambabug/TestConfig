// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The storage account linked service. </summary>
    public partial class AzureStorageLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AzureStorageLinkedService. </summary>
        public AzureStorageLinkedService()
        {
            Type = "AzureStorage";
        }

        /// <summary> Initializes a new instance of AzureStorageLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. It is mutually exclusive with sasUri property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="accountKey"> The Azure key vault secret reference of accountKey in connection string. </param>
        /// <param name="sasUri"> SAS URI of the Azure Storage resource. It is mutually exclusive with connectionString property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="sasToken"> The Azure key vault secret reference of sasToken in sas uri. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AzureStorageLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, AzureKeyVaultSecretReference accountKey, object sasUri, AzureKeyVaultSecretReference sasToken, string encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            AccountKey = accountKey;
            SasUri = sasUri;
            SasToken = sasToken;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AzureStorage";
        }

        /// <summary> The connection string. It is mutually exclusive with sasUri property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The Azure key vault secret reference of accountKey in connection string. </summary>
        public AzureKeyVaultSecretReference AccountKey { get; set; }
        /// <summary> SAS URI of the Azure Storage resource. It is mutually exclusive with connectionString property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object SasUri { get; set; }
        /// <summary> The Azure key vault secret reference of sasToken in sas uri. </summary>
        public AzureKeyVaultSecretReference SasToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public string EncryptedCredential { get; set; }
    }
}