// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AlertModificationEvent.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertModificationEvent
    {
        [EnumMember(Value = "AlertCreated")]
        AlertCreated,
        [EnumMember(Value = "StateChange")]
        StateChange,
        [EnumMember(Value = "MonitorConditionChange")]
        MonitorConditionChange,
        [EnumMember(Value = "SeverityChange")]
        SeverityChange,
        [EnumMember(Value = "ActionRuleTriggered")]
        ActionRuleTriggered,
        [EnumMember(Value = "ActionRuleSuppressed")]
        ActionRuleSuppressed,
        [EnumMember(Value = "ActionsTriggered")]
        ActionsTriggered,
        [EnumMember(Value = "ActionsSuppressed")]
        ActionsSuppressed,
        [EnumMember(Value = "ActionsFailed")]
        ActionsFailed
    }
    internal static class AlertModificationEventEnumExtension
    {
        internal static string ToSerializedValue(this AlertModificationEvent? value)
        {
            return value == null ? null : ((AlertModificationEvent)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertModificationEvent value)
        {
            switch( value )
            {
                case AlertModificationEvent.AlertCreated:
                    return "AlertCreated";
                case AlertModificationEvent.StateChange:
                    return "StateChange";
                case AlertModificationEvent.MonitorConditionChange:
                    return "MonitorConditionChange";
                case AlertModificationEvent.SeverityChange:
                    return "SeverityChange";
                case AlertModificationEvent.ActionRuleTriggered:
                    return "ActionRuleTriggered";
                case AlertModificationEvent.ActionRuleSuppressed:
                    return "ActionRuleSuppressed";
                case AlertModificationEvent.ActionsTriggered:
                    return "ActionsTriggered";
                case AlertModificationEvent.ActionsSuppressed:
                    return "ActionsSuppressed";
                case AlertModificationEvent.ActionsFailed:
                    return "ActionsFailed";
            }
            return null;
        }

        internal static AlertModificationEvent? ParseAlertModificationEvent(this string value)
        {
            switch( value )
            {
                case "AlertCreated":
                    return AlertModificationEvent.AlertCreated;
                case "StateChange":
                    return AlertModificationEvent.StateChange;
                case "MonitorConditionChange":
                    return AlertModificationEvent.MonitorConditionChange;
                case "SeverityChange":
                    return AlertModificationEvent.SeverityChange;
                case "ActionRuleTriggered":
                    return AlertModificationEvent.ActionRuleTriggered;
                case "ActionRuleSuppressed":
                    return AlertModificationEvent.ActionRuleSuppressed;
                case "ActionsTriggered":
                    return AlertModificationEvent.ActionsTriggered;
                case "ActionsSuppressed":
                    return AlertModificationEvent.ActionsSuppressed;
                case "ActionsFailed":
                    return AlertModificationEvent.ActionsFailed;
            }
            return null;
        }
    }
}