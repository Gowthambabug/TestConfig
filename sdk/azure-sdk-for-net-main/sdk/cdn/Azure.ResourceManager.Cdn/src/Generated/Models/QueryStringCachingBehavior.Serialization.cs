// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    internal static partial class QueryStringCachingBehaviorExtensions
    {
        public static string ToSerialString(this QueryStringCachingBehavior value) => value switch
        {
            QueryStringCachingBehavior.IgnoreQueryString => "IgnoreQueryString",
            QueryStringCachingBehavior.BypassCaching => "BypassCaching",
            QueryStringCachingBehavior.UseQueryString => "UseQueryString",
            QueryStringCachingBehavior.NotSet => "NotSet",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryStringCachingBehavior value.")
        };

        public static QueryStringCachingBehavior ToQueryStringCachingBehavior(this string value)
        {
            if (string.Equals(value, "IgnoreQueryString", StringComparison.InvariantCultureIgnoreCase)) return QueryStringCachingBehavior.IgnoreQueryString;
            if (string.Equals(value, "BypassCaching", StringComparison.InvariantCultureIgnoreCase)) return QueryStringCachingBehavior.BypassCaching;
            if (string.Equals(value, "UseQueryString", StringComparison.InvariantCultureIgnoreCase)) return QueryStringCachingBehavior.UseQueryString;
            if (string.Equals(value, "NotSet", StringComparison.InvariantCultureIgnoreCase)) return QueryStringCachingBehavior.NotSet;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryStringCachingBehavior value.");
        }
    }
}