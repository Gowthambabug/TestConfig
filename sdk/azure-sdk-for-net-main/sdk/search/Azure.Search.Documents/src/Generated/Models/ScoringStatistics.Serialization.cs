// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    internal static partial class ScoringStatisticsExtensions
    {
        public static string ToSerialString(this ScoringStatistics value) => value switch
        {
            ScoringStatistics.Local => "local",
            ScoringStatistics.Global => "global",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScoringStatistics value.")
        };

        public static ScoringStatistics ToScoringStatistics(this string value)
        {
            if (string.Equals(value, "local", StringComparison.InvariantCultureIgnoreCase)) return ScoringStatistics.Local;
            if (string.Equals(value, "global", StringComparison.InvariantCultureIgnoreCase)) return ScoringStatistics.Global;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ScoringStatistics value.");
        }
    }
}