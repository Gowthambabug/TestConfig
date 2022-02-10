// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details about ongoing updates and availability of updates on the
    /// device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class UpdateSummary : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateSummary class.
        /// </summary>
        public UpdateSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateSummary class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="systemData">UpdateSummary Result</param>
        /// <param name="deviceVersionNumber">The current version of the device
        /// in format: 1.2.17312.13.",</param>
        /// <param name="friendlyDeviceVersionName">The current version of the
        /// device in text format.</param>
        /// <param name="deviceLastScannedDateTime">The last time when a scan
        /// was done on the device.</param>
        /// <param name="lastCompletedScanJobDateTime">The time when the last
        /// scan job was completed (success/cancelled/failed) on the
        /// appliance.</param>
        /// <param name="lastSuccessfulScanJobTime">Time when the last scan job
        /// is successfully completed.</param>
        /// <param name="lastCompletedDownloadJobDateTime">The time when the
        /// last Download job was completed (success/cancelled/failed) on the
        /// appliance.</param>
        /// <param name="lastCompletedDownloadJobId">JobId of the last ran
        /// download job.(Can be success/cancelled/failed)</param>
        /// <param name="lastDownloadJobStatus">JobStatus of the last ran
        /// download job. Possible values include: 'Invalid', 'Running',
        /// 'Succeeded', 'Failed', 'Canceled', 'Paused', 'Scheduled'</param>
        /// <param name="lastSuccessfulInstallJobDateTime">The time when the
        /// Last Install job was completed successfully on the
        /// appliance</param>
        /// <param name="lastCompletedInstallJobDateTime">The time when the
        /// last Install job was completed (success/cancelled/failed) on the
        /// appliance.</param>
        /// <param name="lastCompletedInstallJobId">JobId of the last ran
        /// install job.(Can be success/cancelled/failed)</param>
        /// <param name="lastInstallJobStatus">JobStatus of the last ran
        /// install job. Possible values include: 'Invalid', 'Running',
        /// 'Succeeded', 'Failed', 'Canceled', 'Paused', 'Scheduled'</param>
        /// <param name="totalNumberOfUpdatesAvailable">The number of updates
        /// available for the current device version as per the last device
        /// scan.</param>
        /// <param name="totalNumberOfUpdatesPendingDownload">The total number
        /// of items pending download.</param>
        /// <param name="totalNumberOfUpdatesPendingInstall">The total number
        /// of items pending install.</param>
        /// <param name="rebootBehavior">Indicates if updates are available and
        /// at least one of the updates needs a reboot. Possible values
        /// include: 'NeverReboots', 'RequiresReboot', 'RequestReboot'</param>
        /// <param name="ongoingUpdateOperation">The current update operation.
        /// Possible values include: 'None', 'Scan', 'Download',
        /// 'Install'</param>
        /// <param name="inProgressDownloadJobId">The job ID of the download
        /// job in progress.</param>
        /// <param name="inProgressInstallJobId">The job ID of the install job
        /// in progress.</param>
        /// <param name="inProgressDownloadJobStartedDateTime">The time when
        /// the currently running download (if any) started.</param>
        /// <param name="inProgressInstallJobStartedDateTime">The time when the
        /// currently running install (if any) started.</param>
        /// <param name="updateTitles">The list of updates available for
        /// install.</param>
        /// <param name="updates">The list of updates available for
        /// install.</param>
        /// <param name="totalUpdateSizeInBytes">The total size of updates
        /// available for download in bytes.</param>
        /// <param name="totalTimeInMinutes">The total time in Minutes</param>
        public UpdateSummary(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string deviceVersionNumber = default(string), string friendlyDeviceVersionName = default(string), System.DateTime? deviceLastScannedDateTime = default(System.DateTime?), System.DateTime? lastCompletedScanJobDateTime = default(System.DateTime?), System.DateTime? lastSuccessfulScanJobTime = default(System.DateTime?), System.DateTime? lastCompletedDownloadJobDateTime = default(System.DateTime?), string lastCompletedDownloadJobId = default(string), string lastDownloadJobStatus = default(string), System.DateTime? lastSuccessfulInstallJobDateTime = default(System.DateTime?), System.DateTime? lastCompletedInstallJobDateTime = default(System.DateTime?), string lastCompletedInstallJobId = default(string), string lastInstallJobStatus = default(string), int? totalNumberOfUpdatesAvailable = default(int?), int? totalNumberOfUpdatesPendingDownload = default(int?), int? totalNumberOfUpdatesPendingInstall = default(int?), string rebootBehavior = default(string), string ongoingUpdateOperation = default(string), string inProgressDownloadJobId = default(string), string inProgressInstallJobId = default(string), System.DateTime? inProgressDownloadJobStartedDateTime = default(System.DateTime?), System.DateTime? inProgressInstallJobStartedDateTime = default(System.DateTime?), IList<string> updateTitles = default(IList<string>), IList<UpdateDetails> updates = default(IList<UpdateDetails>), double? totalUpdateSizeInBytes = default(double?), int? totalTimeInMinutes = default(int?))
            : base(id, name, type)
        {
            SystemData = systemData;
            DeviceVersionNumber = deviceVersionNumber;
            FriendlyDeviceVersionName = friendlyDeviceVersionName;
            DeviceLastScannedDateTime = deviceLastScannedDateTime;
            LastCompletedScanJobDateTime = lastCompletedScanJobDateTime;
            LastSuccessfulScanJobTime = lastSuccessfulScanJobTime;
            LastCompletedDownloadJobDateTime = lastCompletedDownloadJobDateTime;
            LastCompletedDownloadJobId = lastCompletedDownloadJobId;
            LastDownloadJobStatus = lastDownloadJobStatus;
            LastSuccessfulInstallJobDateTime = lastSuccessfulInstallJobDateTime;
            LastCompletedInstallJobDateTime = lastCompletedInstallJobDateTime;
            LastCompletedInstallJobId = lastCompletedInstallJobId;
            LastInstallJobStatus = lastInstallJobStatus;
            TotalNumberOfUpdatesAvailable = totalNumberOfUpdatesAvailable;
            TotalNumberOfUpdatesPendingDownload = totalNumberOfUpdatesPendingDownload;
            TotalNumberOfUpdatesPendingInstall = totalNumberOfUpdatesPendingInstall;
            RebootBehavior = rebootBehavior;
            OngoingUpdateOperation = ongoingUpdateOperation;
            InProgressDownloadJobId = inProgressDownloadJobId;
            InProgressInstallJobId = inProgressInstallJobId;
            InProgressDownloadJobStartedDateTime = inProgressDownloadJobStartedDateTime;
            InProgressInstallJobStartedDateTime = inProgressInstallJobStartedDateTime;
            UpdateTitles = updateTitles;
            Updates = updates;
            TotalUpdateSizeInBytes = totalUpdateSizeInBytes;
            TotalTimeInMinutes = totalTimeInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets updateSummary Result
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Gets or sets the current version of the device in format:
        /// 1.2.17312.13.",
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceVersionNumber")]
        public string DeviceVersionNumber { get; set; }

        /// <summary>
        /// Gets or sets the current version of the device in text format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyDeviceVersionName")]
        public string FriendlyDeviceVersionName { get; set; }

        /// <summary>
        /// Gets or sets the last time when a scan was done on the device.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceLastScannedDateTime")]
        public System.DateTime? DeviceLastScannedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the last scan job was completed
        /// (success/cancelled/failed) on the appliance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedScanJobDateTime")]
        public System.DateTime? LastCompletedScanJobDateTime { get; set; }

        /// <summary>
        /// Gets or sets time when the last scan job is successfully completed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastSuccessfulScanJobTime")]
        public System.DateTime? LastSuccessfulScanJobTime { get; set; }

        /// <summary>
        /// Gets the time when the last Download job was completed
        /// (success/cancelled/failed) on the appliance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedDownloadJobDateTime")]
        public System.DateTime? LastCompletedDownloadJobDateTime { get; private set; }

        /// <summary>
        /// Gets jobId of the last ran download job.(Can be
        /// success/cancelled/failed)
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedDownloadJobId")]
        public string LastCompletedDownloadJobId { get; private set; }

        /// <summary>
        /// Gets jobStatus of the last ran download job. Possible values
        /// include: 'Invalid', 'Running', 'Succeeded', 'Failed', 'Canceled',
        /// 'Paused', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastDownloadJobStatus")]
        public string LastDownloadJobStatus { get; private set; }

        /// <summary>
        /// Gets or sets the time when the Last Install job was completed
        /// successfully on the appliance
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastSuccessfulInstallJobDateTime")]
        public System.DateTime? LastSuccessfulInstallJobDateTime { get; set; }

        /// <summary>
        /// Gets the time when the last Install job was completed
        /// (success/cancelled/failed) on the appliance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedInstallJobDateTime")]
        public System.DateTime? LastCompletedInstallJobDateTime { get; private set; }

        /// <summary>
        /// Gets jobId of the last ran install job.(Can be
        /// success/cancelled/failed)
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCompletedInstallJobId")]
        public string LastCompletedInstallJobId { get; private set; }

        /// <summary>
        /// Gets jobStatus of the last ran install job. Possible values
        /// include: 'Invalid', 'Running', 'Succeeded', 'Failed', 'Canceled',
        /// 'Paused', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastInstallJobStatus")]
        public string LastInstallJobStatus { get; private set; }

        /// <summary>
        /// Gets the number of updates available for the current device version
        /// as per the last device scan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalNumberOfUpdatesAvailable")]
        public int? TotalNumberOfUpdatesAvailable { get; private set; }

        /// <summary>
        /// Gets the total number of items pending download.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalNumberOfUpdatesPendingDownload")]
        public int? TotalNumberOfUpdatesPendingDownload { get; private set; }

        /// <summary>
        /// Gets the total number of items pending install.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalNumberOfUpdatesPendingInstall")]
        public int? TotalNumberOfUpdatesPendingInstall { get; private set; }

        /// <summary>
        /// Gets indicates if updates are available and at least one of the
        /// updates needs a reboot. Possible values include: 'NeverReboots',
        /// 'RequiresReboot', 'RequestReboot'
        /// </summary>
        [JsonProperty(PropertyName = "properties.rebootBehavior")]
        public string RebootBehavior { get; private set; }

        /// <summary>
        /// Gets the current update operation. Possible values include: 'None',
        /// 'Scan', 'Download', 'Install'
        /// </summary>
        [JsonProperty(PropertyName = "properties.ongoingUpdateOperation")]
        public string OngoingUpdateOperation { get; private set; }

        /// <summary>
        /// Gets the job ID of the download job in progress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressDownloadJobId")]
        public string InProgressDownloadJobId { get; private set; }

        /// <summary>
        /// Gets the job ID of the install job in progress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressInstallJobId")]
        public string InProgressInstallJobId { get; private set; }

        /// <summary>
        /// Gets the time when the currently running download (if any) started.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressDownloadJobStartedDateTime")]
        public System.DateTime? InProgressDownloadJobStartedDateTime { get; private set; }

        /// <summary>
        /// Gets the time when the currently running install (if any) started.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inProgressInstallJobStartedDateTime")]
        public System.DateTime? InProgressInstallJobStartedDateTime { get; private set; }

        /// <summary>
        /// Gets the list of updates available for install.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updateTitles")]
        public IList<string> UpdateTitles { get; private set; }

        /// <summary>
        /// Gets the list of updates available for install.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updates")]
        public IList<UpdateDetails> Updates { get; private set; }

        /// <summary>
        /// Gets the total size of updates available for download in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalUpdateSizeInBytes")]
        public double? TotalUpdateSizeInBytes { get; private set; }

        /// <summary>
        /// Gets the total time in Minutes
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalTimeInMinutes")]
        public int? TotalTimeInMinutes { get; private set; }

    }
}