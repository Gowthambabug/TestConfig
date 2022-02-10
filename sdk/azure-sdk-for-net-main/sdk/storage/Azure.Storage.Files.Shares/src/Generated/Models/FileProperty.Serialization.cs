// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class FileProperty
    {
        internal static FileProperty DeserializeFileProperty(XElement element)
        {
            long contentLength = default;
            DateTimeOffset? creationTime = default;
            DateTimeOffset? lastAccessTime = default;
            DateTimeOffset? lastWriteTime = default;
            DateTimeOffset? changeTime = default;
            DateTimeOffset? lastModified = default;
            string etag = default;
            if (element.Element("Content-Length") is XElement contentLengthElement)
            {
                contentLength = (long)contentLengthElement;
            }
            if (element.Element("CreationTime") is XElement creationTimeElement)
            {
                creationTime = creationTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("LastAccessTime") is XElement lastAccessTimeElement)
            {
                lastAccessTime = lastAccessTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("LastWriteTime") is XElement lastWriteTimeElement)
            {
                lastWriteTime = lastWriteTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("ChangeTime") is XElement changeTimeElement)
            {
                changeTime = changeTimeElement.GetDateTimeOffsetValue("O");
            }
            if (element.Element("Last-Modified") is XElement lastModifiedElement)
            {
                lastModified = lastModifiedElement.GetDateTimeOffsetValue("R");
            }
            if (element.Element("Etag") is XElement etagElement)
            {
                etag = (string)etagElement;
            }
            return new FileProperty(contentLength, creationTime, lastAccessTime, lastWriteTime, changeTime, lastModified, etag);
        }
    }
}