// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ResourceIdentityType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceIdentityType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "SystemAssigned")]
        SystemAssigned,
        [EnumMember(Value = "SystemAssigned,UserAssigned")]
        SystemAssignedUserAssigned
    }
    internal static class ResourceIdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this ResourceIdentityType? value)
        {
            return value == null ? null : ((ResourceIdentityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ResourceIdentityType value)
        {
            switch( value )
            {
                case ResourceIdentityType.None:
                    return "None";
                case ResourceIdentityType.SystemAssigned:
                    return "SystemAssigned";
                case ResourceIdentityType.SystemAssignedUserAssigned:
                    return "SystemAssigned,UserAssigned";
            }
            return null;
        }

        internal static ResourceIdentityType? ParseResourceIdentityType(this string value)
        {
            switch( value )
            {
                case "None":
                    return ResourceIdentityType.None;
                case "SystemAssigned":
                    return ResourceIdentityType.SystemAssigned;
                case "SystemAssigned,UserAssigned":
                    return ResourceIdentityType.SystemAssignedUserAssigned;
            }
            return null;
        }
    }
}
