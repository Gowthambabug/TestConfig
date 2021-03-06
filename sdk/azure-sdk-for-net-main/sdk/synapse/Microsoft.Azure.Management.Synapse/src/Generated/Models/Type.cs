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
    /// Defines values for Type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type
    {
        [EnumMember(Value = "Microsoft.Synapse/workspaces/kustoPools/databases")]
        MicrosoftSynapseWorkspacesKustoPoolsDatabases,
        [EnumMember(Value = "Microsoft.Synapse/workspaces/kustoPools/attachedDatabaseConfigurations")]
        MicrosoftSynapseWorkspacesKustoPoolsAttachedDatabaseConfigurations
    }
    internal static class TypeEnumExtension
    {
        internal static string ToSerializedValue(this Type? value)
        {
            return value == null ? null : ((Type)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Type value)
        {
            switch( value )
            {
                case Type.MicrosoftSynapseWorkspacesKustoPoolsDatabases:
                    return "Microsoft.Synapse/workspaces/kustoPools/databases";
                case Type.MicrosoftSynapseWorkspacesKustoPoolsAttachedDatabaseConfigurations:
                    return "Microsoft.Synapse/workspaces/kustoPools/attachedDatabaseConfigurations";
            }
            return null;
        }

        internal static Type? ParseType(this string value)
        {
            switch( value )
            {
                case "Microsoft.Synapse/workspaces/kustoPools/databases":
                    return Type.MicrosoftSynapseWorkspacesKustoPoolsDatabases;
                case "Microsoft.Synapse/workspaces/kustoPools/attachedDatabaseConfigurations":
                    return Type.MicrosoftSynapseWorkspacesKustoPoolsAttachedDatabaseConfigurations;
            }
            return null;
        }
    }
}
