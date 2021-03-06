// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing Abnormal Time Period identified in diagnosis. </summary>
    public partial class AbnormalTimePeriod
    {
        /// <summary> Initializes a new instance of AbnormalTimePeriod. </summary>
        public AbnormalTimePeriod()
        {
            Events = new ChangeTrackingList<DetectorAbnormalTimePeriod>();
            Solutions = new ChangeTrackingList<Solution>();
        }

        /// <summary> Initializes a new instance of AbnormalTimePeriod. </summary>
        /// <param name="startTime"> Start time of the downtime. </param>
        /// <param name="endTime"> End time of the downtime. </param>
        /// <param name="events"> List of Possible Cause of downtime. </param>
        /// <param name="solutions"> List of proposed solutions. </param>
        internal AbnormalTimePeriod(DateTimeOffset? startTime, DateTimeOffset? endTime, IList<DetectorAbnormalTimePeriod> events, IList<Solution> solutions)
        {
            StartTime = startTime;
            EndTime = endTime;
            Events = events;
            Solutions = solutions;
        }

        /// <summary> Start time of the downtime. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> End time of the downtime. </summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary> List of Possible Cause of downtime. </summary>
        public IList<DetectorAbnormalTimePeriod> Events { get; }
        /// <summary> List of proposed solutions. </summary>
        public IList<Solution> Solutions { get; }
    }
}
