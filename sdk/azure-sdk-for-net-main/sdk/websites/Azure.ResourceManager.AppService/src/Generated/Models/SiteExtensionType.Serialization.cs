// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class SiteExtensionTypeExtensions
    {
        public static string ToSerialString(this SiteExtensionType value) => value switch
        {
            SiteExtensionType.Gallery => "Gallery",
            SiteExtensionType.WebRoot => "WebRoot",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SiteExtensionType value.")
        };

        public static SiteExtensionType ToSiteExtensionType(this string value)
        {
            if (string.Equals(value, "Gallery", StringComparison.InvariantCultureIgnoreCase)) return SiteExtensionType.Gallery;
            if (string.Equals(value, "WebRoot", StringComparison.InvariantCultureIgnoreCase)) return SiteExtensionType.WebRoot;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SiteExtensionType value.");
        }
    }
}