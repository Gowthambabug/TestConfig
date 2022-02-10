// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> PolyBase settings. </summary>
    public partial class PolybaseSettings
    {
        /// <summary> Initializes a new instance of PolybaseSettings. </summary>
        public PolybaseSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of PolybaseSettings. </summary>
        /// <param name="rejectType"> Reject type. </param>
        /// <param name="rejectValue"> Specifies the value or the percentage of rows that can be rejected before the query fails. Type: number (or Expression with resultType number), minimum: 0. </param>
        /// <param name="rejectSampleValue"> Determines the number of rows to attempt to retrieve before the PolyBase recalculates the percentage of rejected rows. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="useTypeDefault"> Specifies how to handle missing values in delimited text files when PolyBase retrieves data from the text file. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PolybaseSettings(PolybaseSettingsRejectType? rejectType, object rejectValue, object rejectSampleValue, object useTypeDefault, IDictionary<string, object> additionalProperties)
        {
            RejectType = rejectType;
            RejectValue = rejectValue;
            RejectSampleValue = rejectSampleValue;
            UseTypeDefault = useTypeDefault;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Reject type. </summary>
        public PolybaseSettingsRejectType? RejectType { get; set; }
        /// <summary> Specifies the value or the percentage of rows that can be rejected before the query fails. Type: number (or Expression with resultType number), minimum: 0. </summary>
        public object RejectValue { get; set; }
        /// <summary> Determines the number of rows to attempt to retrieve before the PolyBase recalculates the percentage of rejected rows. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public object RejectSampleValue { get; set; }
        /// <summary> Specifies how to handle missing values in delimited text files when PolyBase retrieves data from the text file. Type: boolean (or Expression with resultType boolean). </summary>
        public object UseTypeDefault { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}