// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The JobResponse. </summary>
    public partial class JobResponse
    {
        /// <summary> Initializes a new instance of JobResponse. </summary>
        internal JobResponse()
        {
        }

        /// <summary> Initializes a new instance of JobResponse. </summary>
        /// <param name="jobId"> System generated.  Ignored at creation. The unique identifier of the job. </param>
        /// <param name="queryCondition"> The device query condition. </param>
        /// <param name="createdTime"> System generated.  Ignored at creation. The creation date and time of the job. </param>
        /// <param name="startTime"> The start date and time of the scheduled job in UTC. </param>
        /// <param name="endTime"> System generated.  Ignored at creation. The end date and time of the job in UTC. </param>
        /// <param name="maxExecutionTimeInSeconds"> The maximum execution time in secounds. </param>
        /// <param name="type"> The job type. </param>
        /// <param name="cloudToDeviceMethod"> The method type and parameters. This is required if job type is cloudToDeviceMethod. </param>
        /// <param name="updateTwin"> The state information for a device or module. This is implicitly created and deleted when the corresponding device/ module identity is created or deleted in the IoT Hub. </param>
        /// <param name="status"> System generated.  Ignored at creation. The status of the job. </param>
        /// <param name="failureReason"> The reason for the failure, if a failure occurred. </param>
        /// <param name="statusMessage"> The status message of the job. </param>
        /// <param name="deviceJobStatistics"> The details regarding job execution status. </param>
        internal JobResponse(string jobId, string queryCondition, DateTimeOffset? createdTime, DateTimeOffset? startTime, DateTimeOffset? endTime, long? maxExecutionTimeInSeconds, JobResponseType? type, CloudToDeviceMethodRequest cloudToDeviceMethod, TwinData updateTwin, JobResponseStatus? status, string failureReason, string statusMessage, DeviceJobStatistics deviceJobStatistics)
        {
            JobId = jobId;
            QueryCondition = queryCondition;
            CreatedTime = createdTime;
            StartTime = startTime;
            EndTime = endTime;
            MaxExecutionTimeInSeconds = maxExecutionTimeInSeconds;
            Type = type;
            CloudToDeviceMethod = cloudToDeviceMethod;
            UpdateTwin = updateTwin;
            Status = status;
            FailureReason = failureReason;
            StatusMessage = statusMessage;
            DeviceJobStatistics = deviceJobStatistics;
        }

        /// <summary> System generated.  Ignored at creation. The unique identifier of the job. </summary>
        public string JobId { get; }
        /// <summary> The device query condition. </summary>
        public string QueryCondition { get; }
        /// <summary> System generated.  Ignored at creation. The creation date and time of the job. </summary>
        public DateTimeOffset? CreatedTime { get; }
        /// <summary> The start date and time of the scheduled job in UTC. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> System generated.  Ignored at creation. The end date and time of the job in UTC. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The maximum execution time in secounds. </summary>
        public long? MaxExecutionTimeInSeconds { get; }
        /// <summary> The job type. </summary>
        public JobResponseType? Type { get; }
        /// <summary> The method type and parameters. This is required if job type is cloudToDeviceMethod. </summary>
        public CloudToDeviceMethodRequest CloudToDeviceMethod { get; }
        /// <summary> The state information for a device or module. This is implicitly created and deleted when the corresponding device/ module identity is created or deleted in the IoT Hub. </summary>
        public TwinData UpdateTwin { get; }
        /// <summary> System generated.  Ignored at creation. The status of the job. </summary>
        public JobResponseStatus? Status { get; }
        /// <summary> The reason for the failure, if a failure occurred. </summary>
        public string FailureReason { get; }
        /// <summary> The status message of the job. </summary>
        public string StatusMessage { get; }
        /// <summary> The details regarding job execution status. </summary>
        public DeviceJobStatistics DeviceJobStatistics { get; }
    }
}