// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class InsightStatusExtensions
    {
        public static string ToSerialString(this InsightStatus value) => value switch
        {
            InsightStatus.Critical => "Critical",
            InsightStatus.Warning => "Warning",
            InsightStatus.Info => "Info",
            InsightStatus.Success => "Success",
            InsightStatus.None => "None",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InsightStatus value.")
        };

        public static InsightStatus ToInsightStatus(this string value)
        {
            if (string.Equals(value, "Critical", StringComparison.InvariantCultureIgnoreCase)) return InsightStatus.Critical;
            if (string.Equals(value, "Warning", StringComparison.InvariantCultureIgnoreCase)) return InsightStatus.Warning;
            if (string.Equals(value, "Info", StringComparison.InvariantCultureIgnoreCase)) return InsightStatus.Info;
            if (string.Equals(value, "Success", StringComparison.InvariantCultureIgnoreCase)) return InsightStatus.Success;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return InsightStatus.None;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InsightStatus value.");
        }
    }
}
