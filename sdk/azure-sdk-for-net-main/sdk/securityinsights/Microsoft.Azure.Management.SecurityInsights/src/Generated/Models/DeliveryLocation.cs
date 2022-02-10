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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DeliveryLocation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryLocation
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,
        /// <summary>
        /// Inbox
        /// </summary>
        [EnumMember(Value = "Inbox")]
        Inbox,
        /// <summary>
        /// JunkFolder
        /// </summary>
        [EnumMember(Value = "JunkFolder")]
        JunkFolder,
        /// <summary>
        /// DeletedFolder
        /// </summary>
        [EnumMember(Value = "DeletedFolder")]
        DeletedFolder,
        /// <summary>
        /// Quarantine
        /// </summary>
        [EnumMember(Value = "Quarantine")]
        Quarantine,
        /// <summary>
        /// External
        /// </summary>
        [EnumMember(Value = "External")]
        External,
        /// <summary>
        /// Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,
        /// <summary>
        /// Dropped
        /// </summary>
        [EnumMember(Value = "Dropped")]
        Dropped,
        /// <summary>
        /// Forwarded
        /// </summary>
        [EnumMember(Value = "Forwarded")]
        Forwarded
    }
    internal static class DeliveryLocationEnumExtension
    {
        internal static string ToSerializedValue(this DeliveryLocation? value)
        {
            return value == null ? null : ((DeliveryLocation)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DeliveryLocation value)
        {
            switch( value )
            {
                case DeliveryLocation.Unknown:
                    return "Unknown";
                case DeliveryLocation.Inbox:
                    return "Inbox";
                case DeliveryLocation.JunkFolder:
                    return "JunkFolder";
                case DeliveryLocation.DeletedFolder:
                    return "DeletedFolder";
                case DeliveryLocation.Quarantine:
                    return "Quarantine";
                case DeliveryLocation.External:
                    return "External";
                case DeliveryLocation.Failed:
                    return "Failed";
                case DeliveryLocation.Dropped:
                    return "Dropped";
                case DeliveryLocation.Forwarded:
                    return "Forwarded";
            }
            return null;
        }

        internal static DeliveryLocation? ParseDeliveryLocation(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return DeliveryLocation.Unknown;
                case "Inbox":
                    return DeliveryLocation.Inbox;
                case "JunkFolder":
                    return DeliveryLocation.JunkFolder;
                case "DeletedFolder":
                    return DeliveryLocation.DeletedFolder;
                case "Quarantine":
                    return DeliveryLocation.Quarantine;
                case "External":
                    return DeliveryLocation.External;
                case "Failed":
                    return DeliveryLocation.Failed;
                case "Dropped":
                    return DeliveryLocation.Dropped;
                case "Forwarded":
                    return DeliveryLocation.Forwarded;
            }
            return null;
        }
    }
}