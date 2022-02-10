// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Files.Shares
{
    internal partial class ShareCreateSnapshotHeaders
    {
        private readonly Response _response;
        public ShareCreateSnapshotHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> This header is a DateTime value that uniquely identifies the share snapshot. The value of this header may be used in subsequent requests to access the share snapshot. This value is opaque. </summary>
        public string Snapshot => _response.Headers.TryGetValue("x-ms-snapshot", out string value) ? value : null;
        /// <summary> Returns the date and time the share was last modified. A share snapshot cannot be modified, so the last modified time of a given share snapshot never changes. However, if new metadata was supplied with the Snapshot Share request then the last modified time of the share snapshot differs from that of the base share. If no metadata was specified with the request, the last modified time of the share snapshot is identical to that of the base share at the time the share snapshot was taken. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}