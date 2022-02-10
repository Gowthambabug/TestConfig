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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schedule for automatically turning virtual machines in a lab on and off
    /// at specified times. Used for updates.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScheduleUpdate
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleUpdate class.
        /// </summary>
        public ScheduleUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleUpdate class.
        /// </summary>
        /// <param name="startAt">When lab user virtual machines will be
        /// started. Timestamp offsets will be ignored and timeZoneId is used
        /// instead.</param>
        /// <param name="stopAt">When lab user virtual machines will be
        /// stopped. Timestamp offsets will be ignored and timeZoneId is used
        /// instead.</param>
        /// <param name="recurrencePattern">The recurrence pattern of the
        /// scheduled actions.</param>
        /// <param name="timeZoneId">The IANA timezone id for the
        /// schedule.</param>
        /// <param name="notes">Notes for this schedule.</param>
        public ScheduleUpdate(System.DateTime? startAt = default(System.DateTime?), System.DateTime? stopAt = default(System.DateTime?), RecurrencePattern recurrencePattern = default(RecurrencePattern), string timeZoneId = default(string), string notes = default(string))
        {
            StartAt = startAt;
            StopAt = stopAt;
            RecurrencePattern = recurrencePattern;
            TimeZoneId = timeZoneId;
            Notes = notes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets when lab user virtual machines will be started.
        /// Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startAt")]
        public System.DateTime? StartAt { get; set; }

        /// <summary>
        /// Gets or sets when lab user virtual machines will be stopped.
        /// Timestamp offsets will be ignored and timeZoneId is used instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stopAt")]
        public System.DateTime? StopAt { get; set; }

        /// <summary>
        /// Gets or sets the recurrence pattern of the scheduled actions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recurrencePattern")]
        public RecurrencePattern RecurrencePattern { get; set; }

        /// <summary>
        /// Gets or sets the IANA timezone id for the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeZoneId")]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets notes for this schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecurrencePattern != null)
            {
                RecurrencePattern.Validate();
            }
            if (TimeZoneId != null)
            {
                if (TimeZoneId.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "TimeZoneId", 50);
                }
            }
            if (Notes != null)
            {
                if (Notes.Length > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Notes", 1000);
                }
            }
        }
    }
}