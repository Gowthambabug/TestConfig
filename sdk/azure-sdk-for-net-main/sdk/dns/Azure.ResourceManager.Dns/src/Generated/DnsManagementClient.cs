// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Dns;

namespace Azure.ResourceManager.Dns
{
    /// <summary> Dns service management client. </summary>
    public partial class DnsManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly string _subscriptionId;
        private readonly Uri _endpoint;

        /// <summary> Initializes a new instance of DnsManagementClient for mocking. </summary>
        protected DnsManagementClient()
        {
        }

        /// <summary> Initializes a new instance of DnsManagementClient. </summary>
        /// <param name="subscriptionId"> Specifies the Azure subscription ID, which uniquely identifies the Microsoft Azure subscription. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public DnsManagementClient(string subscriptionId, TokenCredential tokenCredential, DnsManagementClientOptions options = null) : this(subscriptionId, null, tokenCredential, options)
        {
        }

        /// <summary> Returns an instance of RecordSetsOperations. </summary>
        public virtual RecordSetsOperations RecordSets => new RecordSetsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ZonesOperations. </summary>
        public virtual ZonesOperations Zones => new ZonesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of DnsResourceReferenceOperations. </summary>
        public virtual DnsResourceReferenceOperations DnsResourceReference => new DnsResourceReferenceOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
    }
}
