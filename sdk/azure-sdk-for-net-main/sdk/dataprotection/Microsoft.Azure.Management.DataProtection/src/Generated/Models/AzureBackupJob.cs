// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AzureBackup Job Class
    /// </summary>
    public partial class AzureBackupJob
    {
        /// <summary>
        /// Initializes a new instance of the AzureBackupJob class.
        /// </summary>
        public AzureBackupJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBackupJob class.
        /// </summary>
        /// <param name="activityID">Job Activity Id</param>
        /// <param name="backupInstanceFriendlyName">Name of the Backup
        /// Instance</param>
        /// <param name="dataSourceId">ARM ID of the DataSource</param>
        /// <param name="dataSourceLocation">Location of the DataSource</param>
        /// <param name="dataSourceName">User Friendly Name of the
        /// DataSource</param>
        /// <param name="dataSourceType">Type of DataSource</param>
        /// <param name="isUserTriggered">Indicated that whether the job is
        /// adhoc(true) or scheduled(false)</param>
        /// <param name="operation">It indicates the type of Job i.e.
        /// Backup:full/log/diff ;Restore:ALR/OLR; Tiering:Backup/Archive ;
        /// Management:ConfigureProtection/UnConfigure</param>
        /// <param name="operationCategory">It indicates the type of Job i.e.
        /// Backup/Restore/Tiering/Management</param>
        /// <param name="progressEnabled">Indicated whether progress is enabled
        /// for the job</param>
        /// <param name="sourceResourceGroup">Resource Group Name of the
        /// Datasource</param>
        /// <param name="sourceSubscriptionID">SubscriptionId corresponding to
        /// the DataSource</param>
        /// <param name="startTime">StartTime of the job(in UTC)</param>
        /// <param name="status">Status of the job like
        /// InProgress/Success/Failed/Cancelled/SuccessWithWarning</param>
        /// <param name="subscriptionId">Subscription Id of the corresponding
        /// backup vault</param>
        /// <param name="supportedActions">List of supported actions</param>
        /// <param name="vaultName">Name of the vault</param>
        /// <param name="backupInstanceId">ARM ID of the Backup
        /// Instance</param>
        /// <param name="dataSourceSetName">Data Source Set Name of the
        /// DataSource</param>
        /// <param name="duration">Total run time of the job. ISO 8601
        /// format.</param>
        /// <param name="endTime">EndTime of the job(in UTC)</param>
        /// <param name="errorDetails">A List, detailing the errors related to
        /// the job</param>
        /// <param name="extendedInfo">Extended Information about the
        /// job</param>
        /// <param name="policyId">ARM ID of the policy</param>
        /// <param name="policyName">Name of the policy</param>
        /// <param name="progressUrl">Url which contains job's progress</param>
        /// <param name="restoreType">It indicates the sub type of operation
        /// i.e. in case of Restore it can be ALR/OLR</param>
        public AzureBackupJob(string activityID, string backupInstanceFriendlyName, string dataSourceId, string dataSourceLocation, string dataSourceName, string dataSourceType, bool isUserTriggered, string operation, string operationCategory, bool progressEnabled, string sourceResourceGroup, string sourceSubscriptionID, System.DateTime startTime, string status, string subscriptionId, IList<string> supportedActions, string vaultName, string backupInstanceId = default(string), string dataSourceSetName = default(string), string duration = default(string), System.DateTime? endTime = default(System.DateTime?), IList<UserFacingError> errorDetails = default(IList<UserFacingError>), JobExtendedInfo extendedInfo = default(JobExtendedInfo), string policyId = default(string), string policyName = default(string), string progressUrl = default(string), string restoreType = default(string), string etag = default(string), string sourceDataStoreName = default(string), string destinationDataStoreName = default(string))
        {
            ActivityID = activityID;
            BackupInstanceFriendlyName = backupInstanceFriendlyName;
            BackupInstanceId = backupInstanceId;
            DataSourceId = dataSourceId;
            DataSourceLocation = dataSourceLocation;
            DataSourceName = dataSourceName;
            DataSourceSetName = dataSourceSetName;
            DataSourceType = dataSourceType;
            Duration = duration;
            EndTime = endTime;
            ErrorDetails = errorDetails;
            ExtendedInfo = extendedInfo;
            IsUserTriggered = isUserTriggered;
            Operation = operation;
            OperationCategory = operationCategory;
            PolicyId = policyId;
            PolicyName = policyName;
            ProgressEnabled = progressEnabled;
            ProgressUrl = progressUrl;
            RestoreType = restoreType;
            SourceResourceGroup = sourceResourceGroup;
            SourceSubscriptionID = sourceSubscriptionID;
            StartTime = startTime;
            Status = status;
            SubscriptionId = subscriptionId;
            SupportedActions = supportedActions;
            VaultName = vaultName;
            Etag = etag;
            SourceDataStoreName = sourceDataStoreName;
            DestinationDataStoreName = destinationDataStoreName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets job Activity Id
        /// </summary>
        [JsonProperty(PropertyName = "activityID")]
        public string ActivityID { get; set; }

        /// <summary>
        /// Gets or sets name of the Backup Instance
        /// </summary>
        [JsonProperty(PropertyName = "backupInstanceFriendlyName")]
        public string BackupInstanceFriendlyName { get; set; }

        /// <summary>
        /// Gets ARM ID of the Backup Instance
        /// </summary>
        [JsonProperty(PropertyName = "backupInstanceId")]
        public string BackupInstanceId { get; private set; }

        /// <summary>
        /// Gets or sets ARM ID of the DataSource
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceId")]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Gets or sets location of the DataSource
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceLocation")]
        public string DataSourceLocation { get; set; }

        /// <summary>
        /// Gets or sets user Friendly Name of the DataSource
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceName")]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Gets or sets data Source Set Name of the DataSource
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceSetName")]
        public string DataSourceSetName { get; set; }

        /// <summary>
        /// Gets or sets type of DataSource
        /// </summary>
        [JsonProperty(PropertyName = "dataSourceType")]
        public string DataSourceType { get; set; }

        /// <summary>
        /// Gets or sets total run time of the job. ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets endTime of the job(in UTC)
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets a List, detailing the errors related to the job
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public IList<UserFacingError> ErrorDetails { get; private set; }

        /// <summary>
        /// Gets extended Information about the job
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public JobExtendedInfo ExtendedInfo { get; private set; }

        /// <summary>
        /// Gets or sets indicated that whether the job is adhoc(true) or
        /// scheduled(false)
        /// </summary>
        [JsonProperty(PropertyName = "isUserTriggered")]
        public bool IsUserTriggered { get; set; }

        /// <summary>
        /// Gets or sets it indicates the type of Job i.e. Backup:full/log/diff
        /// ;Restore:ALR/OLR; Tiering:Backup/Archive ;
        /// Management:ConfigureProtection/UnConfigure
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets it indicates the type of Job i.e.
        /// Backup/Restore/Tiering/Management
        /// </summary>
        [JsonProperty(PropertyName = "operationCategory")]
        public string OperationCategory { get; set; }

        /// <summary>
        /// Gets ARM ID of the policy
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; private set; }

        /// <summary>
        /// Gets name of the policy
        /// </summary>
        [JsonProperty(PropertyName = "policyName")]
        public string PolicyName { get; private set; }

        /// <summary>
        /// Gets or sets indicated whether progress is enabled for the job
        /// </summary>
        [JsonProperty(PropertyName = "progressEnabled")]
        public bool ProgressEnabled { get; set; }

        /// <summary>
        /// Gets url which contains job's progress
        /// </summary>
        [JsonProperty(PropertyName = "progressUrl")]
        public string ProgressUrl { get; private set; }

        /// <summary>
        /// Gets it indicates the sub type of operation i.e. in case of Restore
        /// it can be ALR/OLR
        /// </summary>
        [JsonProperty(PropertyName = "restoreType")]
        public string RestoreType { get; private set; }

        /// <summary>
        /// Gets or sets resource Group Name of the Datasource
        /// </summary>
        [JsonProperty(PropertyName = "sourceResourceGroup")]
        public string SourceResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets subscriptionId corresponding to the DataSource
        /// </summary>
        [JsonProperty(PropertyName = "sourceSubscriptionID")]
        public string SourceSubscriptionID { get; set; }

        /// <summary>
        /// Gets or sets startTime of the job(in UTC)
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets status of the job like
        /// InProgress/Success/Failed/Cancelled/SuccessWithWarning
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets subscription Id of the corresponding backup vault
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets list of supported actions
        /// </summary>
        [JsonProperty(PropertyName = "supportedActions")]
        public IList<string> SupportedActions { get; set; }

        /// <summary>
        /// Gets or sets name of the vault
        /// </summary>
        [JsonProperty(PropertyName = "vaultName")]
        public string VaultName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceDataStoreName")]
        public string SourceDataStoreName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "destinationDataStoreName")]
        public string DestinationDataStoreName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ActivityID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ActivityID");
            }
            if (BackupInstanceFriendlyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackupInstanceFriendlyName");
            }
            if (DataSourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSourceId");
            }
            if (DataSourceLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSourceLocation");
            }
            if (DataSourceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSourceName");
            }
            if (DataSourceType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSourceType");
            }
            if (Operation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Operation");
            }
            if (OperationCategory == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperationCategory");
            }
            if (SourceResourceGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceResourceGroup");
            }
            if (SourceSubscriptionID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceSubscriptionID");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SubscriptionId");
            }
            if (SupportedActions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SupportedActions");
            }
            if (VaultName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VaultName");
            }
        }
    }
}
