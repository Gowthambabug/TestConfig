// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for InvitationState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvitationState
    {
        /// <summary>
        /// The invitation has not been sent.
        /// </summary>
        [EnumMember(Value = "NotSent")]
        NotSent,
        /// <summary>
        /// Currently sending the invitation.
        /// </summary>
        [EnumMember(Value = "Sending")]
        Sending,
        /// <summary>
        /// The invitation has been successfully sent.
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent,
        /// <summary>
        /// There was an error while sending the invitation.
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    internal static class InvitationStateEnumExtension
    {
        internal static string ToSerializedValue(this InvitationState? value)
        {
            return value == null ? null : ((InvitationState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this InvitationState value)
        {
            switch( value )
            {
                case InvitationState.NotSent:
                    return "NotSent";
                case InvitationState.Sending:
                    return "Sending";
                case InvitationState.Sent:
                    return "Sent";
                case InvitationState.Failed:
                    return "Failed";
            }
            return null;
        }

        internal static InvitationState? ParseInvitationState(this string value)
        {
            switch( value )
            {
                case "NotSent":
                    return InvitationState.NotSent;
                case "Sending":
                    return InvitationState.Sending;
                case "Sent":
                    return InvitationState.Sent;
                case "Failed":
                    return InvitationState.Failed;
            }
            return null;
        }
    }
}