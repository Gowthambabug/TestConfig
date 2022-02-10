// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SecurityEventType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SecurityEventType
    {
        [EnumMember(Value = "Undefined")]
        Undefined,
        [EnumMember(Value = "SqlInjectionVulnerability")]
        SqlInjectionVulnerability,
        [EnumMember(Value = "SqlInjectionExploit")]
        SqlInjectionExploit
    }
    internal static class SecurityEventTypeEnumExtension
    {
        internal static string ToSerializedValue(this SecurityEventType? value)
        {
            return value == null ? null : ((SecurityEventType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SecurityEventType value)
        {
            switch( value )
            {
                case SecurityEventType.Undefined:
                    return "Undefined";
                case SecurityEventType.SqlInjectionVulnerability:
                    return "SqlInjectionVulnerability";
                case SecurityEventType.SqlInjectionExploit:
                    return "SqlInjectionExploit";
            }
            return null;
        }

        internal static SecurityEventType? ParseSecurityEventType(this string value)
        {
            switch( value )
            {
                case "Undefined":
                    return SecurityEventType.Undefined;
                case "SqlInjectionVulnerability":
                    return SecurityEventType.SqlInjectionVulnerability;
                case "SqlInjectionExploit":
                    return SecurityEventType.SqlInjectionExploit;
            }
            return null;
        }
    }
}