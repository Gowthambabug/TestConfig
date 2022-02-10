// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Job Schedule that allows recurring Jobs by specifying when to run
    /// Jobs and a specification used to create each Job.
    /// </summary>
    public partial class CloudJobSchedule
    {
        /// <summary>
        /// Initializes a new instance of the CloudJobSchedule class.
        /// </summary>
        public CloudJobSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudJobSchedule class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the schedule
        /// within the Account.</param>
        /// <param name="displayName">The display name for the
        /// schedule.</param>
        /// <param name="url">The URL of the Job Schedule.</param>
        /// <param name="eTag">The ETag of the Job Schedule.</param>
        /// <param name="lastModified">The last modified time of the Job
        /// Schedule.</param>
        /// <param name="creationTime">The creation time of the Job
        /// Schedule.</param>
        /// <param name="state">The current state of the Job Schedule.</param>
        /// <param name="stateTransitionTime">The time at which the Job
        /// Schedule entered the current state.</param>
        /// <param name="previousState">The previous state of the Job
        /// Schedule.</param>
        /// <param name="previousStateTransitionTime">The time at which the Job
        /// Schedule entered its previous state.</param>
        /// <param name="schedule">The schedule according to which Jobs will be
        /// created.</param>
        /// <param name="jobSpecification">The details of the Jobs to be
        /// created on this schedule.</param>
        /// <param name="executionInfo">Information about Jobs that have been
        /// and will be run under this schedule.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the schedule as metadata.</param>
        /// <param name="stats">The lifetime resource usage statistics for the
        /// Job Schedule. The statistics may not be immediately available. The
        /// Batch service performs periodic roll-up of statistics. The typical
        /// delay is about 30 minutes.</param>
        public CloudJobSchedule(string id = default(string), string displayName = default(string), string url = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), JobScheduleState? state = default(JobScheduleState?), System.DateTime? stateTransitionTime = default(System.DateTime?), JobScheduleState? previousState = default(JobScheduleState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), Schedule schedule = default(Schedule), JobSpecification jobSpecification = default(JobSpecification), JobScheduleExecutionInformation executionInfo = default(JobScheduleExecutionInformation), IList<MetadataItem> metadata = default(IList<MetadataItem>), JobScheduleStatistics stats = default(JobScheduleStatistics))
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            Schedule = schedule;
            JobSpecification = jobSpecification;
            ExecutionInfo = executionInfo;
            Metadata = metadata;
            Stats = stats;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the schedule within
        /// the Account.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the Job Schedule.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the Job Schedule.
        /// </summary>
        /// <remarks>
        /// This is an opaque string. You can use it to detect whether the Job
        /// Schedule has changed between requests. In particular, you can be
        /// pass the ETag with an Update Job Schedule request to specify that
        /// your changes should take effect only if nobody else has modified
        /// the schedule in the meantime.
        /// </remarks>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the Job Schedule.
        /// </summary>
        /// <remarks>
        /// This is the last time at which the schedule level data, such as the
        /// Job specification or recurrence information, changed. It does not
        /// factor in job-level changes such as new Jobs being created or Jobs
        /// changing state.
        /// </remarks>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the Job Schedule.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the Job Schedule.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'completed', 'disabled',
        /// 'terminating', 'deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public JobScheduleState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Job Schedule entered the current
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the Job Schedule.
        /// </summary>
        /// <remarks>
        /// This property is not present if the Job Schedule is in its initial
        /// active state. Possible values include: 'active', 'completed',
        /// 'disabled', 'terminating', 'deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "previousState")]
        public JobScheduleState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Job Schedule entered its
        /// previous state.
        /// </summary>
        /// <remarks>
        /// This property is not present if the Job Schedule is in its initial
        /// active state.
        /// </remarks>
        [JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the schedule according to which Jobs will be created.
        /// </summary>
        /// <remarks>
        /// All times are fixed respective to UTC and are not impacted by
        /// daylight saving time.
        /// </remarks>
        [JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the details of the Jobs to be created on this
        /// schedule.
        /// </summary>
        [JsonProperty(PropertyName = "jobSpecification")]
        public JobSpecification JobSpecification { get; set; }

        /// <summary>
        /// Gets or sets information about Jobs that have been and will be run
        /// under this schedule.
        /// </summary>
        [JsonProperty(PropertyName = "executionInfo")]
        public JobScheduleExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the
        /// schedule as metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the lifetime resource usage statistics for the Job
        /// Schedule. The statistics may not be immediately available. The
        /// Batch service performs periodic roll-up of statistics. The typical
        /// delay is about 30 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public JobScheduleStatistics Stats { get; set; }

    }
}