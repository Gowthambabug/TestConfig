// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Files.DataLake
{
    internal partial class PathAppendDataHeaders
    {
        private readonly Response _response;
        public PathAppendDataHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The version of the REST protocol used to process the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> If the blob has an MD5 hash and this operation is to read the full blob, this response header is returned so that the client can check for message content integrity. </summary>
        public byte[] ContentMD5 => _response.Headers.TryGetValue("Content-MD5", out byte[] value) ? value : null;
        /// <summary> This header is returned so that the client can check for message content integrity. The value of this header is computed by the Blob service; it is not necessarily the same value specified in the request headers. </summary>
        public byte[] XMsContentCrc64 => _response.Headers.TryGetValue("x-ms-content-crc64", out byte[] value) ? value : null;
        /// <summary> The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise. </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-request-server-encrypted", out bool? value) ? value : null;
    }
}