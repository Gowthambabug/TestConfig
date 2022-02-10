// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{

    /// <summary>
    /// Defines values for AlertStatus.
    /// </summary>
    public static class AlertStatus
    {
        /// <summary>
        /// Unknown value
        /// </summary>
        public const string Unknown = "Unknown";
        /// <summary>
        /// New alert
        /// </summary>
        public const string New = "New";
        /// <summary>
        /// Alert closed after handling
        /// </summary>
        public const string Resolved = "Resolved";
        /// <summary>
        /// Alert dismissed as false positive
        /// </summary>
        public const string Dismissed = "Dismissed";
        /// <summary>
        /// Alert is being handled
        /// </summary>
        public const string InProgress = "InProgress";
    }
}