// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class IssueTypeExtensions
    {
        public static string ToSerialString(this IssueType value) => value switch
        {
            IssueType.ServiceIncident => "ServiceIncident",
            IssueType.AppDeployment => "AppDeployment",
            IssueType.AppCrash => "AppCrash",
            IssueType.RuntimeIssueDetected => "RuntimeIssueDetected",
            IssueType.AseDeployment => "AseDeployment",
            IssueType.UserIssue => "UserIssue",
            IssueType.PlatformIssue => "PlatformIssue",
            IssueType.Other => "Other",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IssueType value.")
        };

        public static IssueType ToIssueType(this string value)
        {
            if (string.Equals(value, "ServiceIncident", StringComparison.InvariantCultureIgnoreCase)) return IssueType.ServiceIncident;
            if (string.Equals(value, "AppDeployment", StringComparison.InvariantCultureIgnoreCase)) return IssueType.AppDeployment;
            if (string.Equals(value, "AppCrash", StringComparison.InvariantCultureIgnoreCase)) return IssueType.AppCrash;
            if (string.Equals(value, "RuntimeIssueDetected", StringComparison.InvariantCultureIgnoreCase)) return IssueType.RuntimeIssueDetected;
            if (string.Equals(value, "AseDeployment", StringComparison.InvariantCultureIgnoreCase)) return IssueType.AseDeployment;
            if (string.Equals(value, "UserIssue", StringComparison.InvariantCultureIgnoreCase)) return IssueType.UserIssue;
            if (string.Equals(value, "PlatformIssue", StringComparison.InvariantCultureIgnoreCase)) return IssueType.PlatformIssue;
            if (string.Equals(value, "Other", StringComparison.InvariantCultureIgnoreCase)) return IssueType.Other;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IssueType value.");
        }
    }
}
