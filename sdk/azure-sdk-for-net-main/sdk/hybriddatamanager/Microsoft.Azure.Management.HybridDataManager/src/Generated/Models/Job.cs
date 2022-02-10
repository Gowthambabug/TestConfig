// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data service job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Job : DmsBaseObject
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="status">Status of the job. Possible values include:
        /// 'None', 'InProgress', 'Succeeded', 'WaitingForAction', 'Failed',
        /// 'Cancelled', 'Cancelling', 'PartiallySucceeded'</param>
        /// <param name="startTime">Time at which the job was started in UTC
        /// ISO 8601 format.</param>
        /// <param name="isCancellable">Describes whether the job is
        /// cancellable. Possible values include: 'NotCancellable',
        /// 'Cancellable'</param>
        /// <param name="name">Name of the object.</param>
        /// <param name="id">Id of the object.</param>
        /// <param name="type">Type of the object.</param>
        /// <param name="endTime">Time at which the job ended in UTC ISO 8601
        /// format.</param>
        /// <param name="bytesProcessed">Number of bytes processed by the job
        /// as of now.</param>
        /// <param name="itemsProcessed">Number of items processed by the job
        /// as of now</param>
        /// <param name="totalBytesToProcess">Number of bytes to be processed
        /// by the job in total.</param>
        /// <param name="totalItemsToProcess">Number of items to be processed
        /// by the job in total</param>
        /// <param name="details">Details of a job run. This field will only be
        /// sent for expand details filter.</param>
        /// <param name="dataSourceName">Name of the data source on which the
        /// job was triggered.</param>
        /// <param name="dataSinkName">Name of the data sink on which the job
        /// was triggered.</param>
        /// <param name="error">Top level error for the job.</param>
        public Job(JobStatus status, System.DateTime startTime, IsJobCancellable isCancellable, string name = default(string), string id = default(string), string type = default(string), System.DateTime? endTime = default(System.DateTime?), long? bytesProcessed = default(long?), long? itemsProcessed = default(long?), long? totalBytesToProcess = default(long?), long? totalItemsToProcess = default(long?), JobDetails details = default(JobDetails), string dataSourceName = default(string), string dataSinkName = default(string), Error error = default(Error))
            : base(name, id, type)
        {
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            IsCancellable = isCancellable;
            BytesProcessed = bytesProcessed;
            ItemsProcessed = itemsProcessed;
            TotalBytesToProcess = totalBytesToProcess;
            TotalItemsToProcess = totalItemsToProcess;
            Details = details;
            DataSourceName = dataSourceName;
            DataSinkName = dataSinkName;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets status of the job. Possible values include: 'None',
        /// 'InProgress', 'Succeeded', 'WaitingForAction', 'Failed',
        /// 'Cancelled', 'Cancelling', 'PartiallySucceeded'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public JobStatus Status { get; set; }

        /// <summary>
        /// Gets or sets time at which the job was started in UTC ISO 8601
        /// format.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets time at which the job ended in UTC ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets describes whether the job is cancellable. Possible
        /// values include: 'NotCancellable', 'Cancellable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.isCancellable")]
        public IsJobCancellable IsCancellable { get; set; }

        /// <summary>
        /// Gets or sets number of bytes processed by the job as of now.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bytesProcessed")]
        public long? BytesProcessed { get; set; }

        /// <summary>
        /// Gets or sets number of items processed by the job as of now
        /// </summary>
        [JsonProperty(PropertyName = "properties.itemsProcessed")]
        public long? ItemsProcessed { get; set; }

        /// <summary>
        /// Gets or sets number of bytes to be processed by the job in total.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalBytesToProcess")]
        public long? TotalBytesToProcess { get; set; }

        /// <summary>
        /// Gets or sets number of items to be processed by the job in total
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalItemsToProcess")]
        public long? TotalItemsToProcess { get; set; }

        /// <summary>
        /// Gets or sets details of a job run. This field will only be sent for
        /// expand details filter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public JobDetails Details { get; set; }

        /// <summary>
        /// Gets or sets name of the data source on which the job was
        /// triggered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSourceName")]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Gets or sets name of the data sink on which the job was triggered.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSinkName")]
        public string DataSinkName { get; set; }

        /// <summary>
        /// Gets or sets top level error for the job.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Details != null)
            {
                Details.Validate();
            }
            if (Error != null)
            {
                Error.Validate();
            }
        }
    }
}