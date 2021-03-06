// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class MSDeployLogEntryTypeExtensions
    {
        public static string ToSerialString(this MSDeployLogEntryType value) => value switch
        {
            MSDeployLogEntryType.Message => "Message",
            MSDeployLogEntryType.Warning => "Warning",
            MSDeployLogEntryType.Error => "Error",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MSDeployLogEntryType value.")
        };

        public static MSDeployLogEntryType ToMSDeployLogEntryType(this string value)
        {
            if (string.Equals(value, "Message", StringComparison.InvariantCultureIgnoreCase)) return MSDeployLogEntryType.Message;
            if (string.Equals(value, "Warning", StringComparison.InvariantCultureIgnoreCase)) return MSDeployLogEntryType.Warning;
            if (string.Equals(value, "Error", StringComparison.InvariantCultureIgnoreCase)) return MSDeployLogEntryType.Error;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MSDeployLogEntryType value.");
        }
    }
}
