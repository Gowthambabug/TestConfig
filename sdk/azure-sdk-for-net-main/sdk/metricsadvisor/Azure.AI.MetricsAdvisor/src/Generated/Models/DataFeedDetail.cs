// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataFeedDetail. </summary>
    internal partial class DataFeedDetail
    {

        /// <summary> Initializes a new instance of DataFeedDetail. </summary>
        /// <param name="dataSourceType"> data source type. </param>
        /// <param name="dataFeedId"> data feed unique id. </param>
        /// <param name="dataFeedName"> data feed name. </param>
        /// <param name="dataFeedDescription"> data feed description. </param>
        /// <param name="granularityName"> granularity of the time series. </param>
        /// <param name="granularityAmount"> if granularity is custom,it is required. </param>
        /// <param name="metrics"> measure list. </param>
        /// <param name="dimension"> dimension list. </param>
        /// <param name="timestampColumn"> user-defined timestamp column. if timestampColumn is null, start time of every time slice will be used as default value. </param>
        /// <param name="dataStartFrom"> ingestion start time. </param>
        /// <param name="startOffsetInSeconds"> the time that the beginning of data ingestion task will delay for every data slice according to this offset. </param>
        /// <param name="maxConcurrency"> the max concurrency of data ingestion queries against user data source. 0 means no limitation. </param>
        /// <param name="minRetryIntervalInSeconds"> the min retry interval for failed data ingestion tasks. </param>
        /// <param name="stopRetryAfterInSeconds"> stop retry data ingestion after the data slice first schedule time in seconds. </param>
        /// <param name="needRollup"> mark if the data feed need rollup. </param>
        /// <param name="rollUpMethod"> roll up method. </param>
        /// <param name="rollUpColumns"> roll up columns. </param>
        /// <param name="allUpIdentification"> the identification value for the row of calculated all-up value. </param>
        /// <param name="fillMissingPointType"> the type of fill missing point for anomaly detection. </param>
        /// <param name="fillMissingPointValue"> the value of fill missing point for anomaly detection. </param>
        /// <param name="viewMode"> data feed access mode, default is Private. </param>
        /// <param name="admins"> data feed administrator. </param>
        /// <param name="viewers"> data feed viewer. </param>
        /// <param name="isAdmin"> the query user is one of data feed administrator or not. </param>
        /// <param name="creator"> data feed creator. </param>
        /// <param name="status"> data feed status. </param>
        /// <param name="createdTime"> data feed created time. </param>
        /// <param name="actionLinkTemplate"> action link for alert. </param>
        /// <param name="authenticationType"> authentication type for corresponding data source. </param>
        /// <param name="credentialId"> The credential entity id. </param>
        internal DataFeedDetail(DataFeedSourceKind dataSourceType, string dataFeedId, string dataFeedName, string dataFeedDescription, DataFeedGranularityType granularityName, int? granularityAmount, IList<DataFeedMetric> metrics, IList<DataFeedDimension> dimension, string timestampColumn, DateTimeOffset dataStartFrom, long? startOffsetInSeconds, int? maxConcurrency, long? minRetryIntervalInSeconds, long? stopRetryAfterInSeconds, DataFeedRollupType? needRollup, DataFeedAutoRollupMethod? rollUpMethod, IList<string> rollUpColumns, string allUpIdentification, DataFeedMissingDataPointFillType? fillMissingPointType, double? fillMissingPointValue, DataFeedAccessMode? viewMode, IList<string> admins, IList<string> viewers, bool? isAdmin, string creator, DataFeedStatus? status, DateTimeOffset? createdTime, string actionLinkTemplate, AuthenticationTypeEnum? authenticationType, string credentialId)
        {
            DataSourceType = dataSourceType;
            DataFeedId = dataFeedId;
            DataFeedName = dataFeedName;
            DataFeedDescription = dataFeedDescription;
            GranularityName = granularityName;
            GranularityAmount = granularityAmount;
            Metrics = metrics;
            Dimension = dimension;
            TimestampColumn = timestampColumn;
            DataStartFrom = dataStartFrom;
            StartOffsetInSeconds = startOffsetInSeconds;
            MaxConcurrency = maxConcurrency;
            MinRetryIntervalInSeconds = minRetryIntervalInSeconds;
            StopRetryAfterInSeconds = stopRetryAfterInSeconds;
            NeedRollup = needRollup;
            RollUpMethod = rollUpMethod;
            RollUpColumns = rollUpColumns;
            AllUpIdentification = allUpIdentification;
            FillMissingPointType = fillMissingPointType;
            FillMissingPointValue = fillMissingPointValue;
            ViewMode = viewMode;
            Admins = admins;
            Viewers = viewers;
            IsAdmin = isAdmin;
            Creator = creator;
            Status = status;
            CreatedTime = createdTime;
            ActionLinkTemplate = actionLinkTemplate;
            AuthenticationType = authenticationType;
            CredentialId = credentialId;
        }

        /// <summary> data source type. </summary>
        internal DataFeedSourceKind DataSourceType { get; set; }
        /// <summary> data feed name. </summary>
        public string DataFeedName { get; set; }
        /// <summary> data feed description. </summary>
        public string DataFeedDescription { get; set; }
        /// <summary> granularity of the time series. </summary>
        public DataFeedGranularityType GranularityName { get; set; }
        /// <summary> if granularity is custom,it is required. </summary>
        public int? GranularityAmount { get; set; }
        /// <summary> measure list. </summary>
        public IList<DataFeedMetric> Metrics { get; }
        /// <summary> user-defined timestamp column. if timestampColumn is null, start time of every time slice will be used as default value. </summary>
        public string TimestampColumn { get; set; }
        /// <summary> ingestion start time. </summary>
        public DateTimeOffset DataStartFrom { get; set; }
        /// <summary> the time that the beginning of data ingestion task will delay for every data slice according to this offset. </summary>
        public long? StartOffsetInSeconds { get; set; }
        /// <summary> the max concurrency of data ingestion queries against user data source. 0 means no limitation. </summary>
        public int? MaxConcurrency { get; set; }
        /// <summary> the min retry interval for failed data ingestion tasks. </summary>
        public long? MinRetryIntervalInSeconds { get; set; }
        /// <summary> stop retry data ingestion after the data slice first schedule time in seconds. </summary>
        public long? StopRetryAfterInSeconds { get; set; }
        /// <summary> mark if the data feed need rollup. </summary>
        public DataFeedRollupType? NeedRollup { get; set; }
        /// <summary> roll up method. </summary>
        public DataFeedAutoRollupMethod? RollUpMethod { get; set; }
        /// <summary> the identification value for the row of calculated all-up value. </summary>
        public string AllUpIdentification { get; set; }
        /// <summary> the type of fill missing point for anomaly detection. </summary>
        public DataFeedMissingDataPointFillType? FillMissingPointType { get; set; }
        /// <summary> the value of fill missing point for anomaly detection. </summary>
        public double? FillMissingPointValue { get; set; }
        /// <summary> data feed access mode, default is Private. </summary>
        public DataFeedAccessMode? ViewMode { get; set; }
        /// <summary> the query user is one of data feed administrator or not. </summary>
        public bool? IsAdmin { get; }
        /// <summary> data feed creator. </summary>
        public string Creator { get; }
        /// <summary> data feed status. </summary>
        public DataFeedStatus? Status { get; }
        /// <summary> data feed created time. </summary>
        public DateTimeOffset? CreatedTime { get; }
        /// <summary> action link for alert. </summary>
        public string ActionLinkTemplate { get; set; }
        /// <summary> authentication type for corresponding data source. </summary>
        public AuthenticationTypeEnum? AuthenticationType { get; set; }
        /// <summary> The credential entity id. </summary>
        public string CredentialId { get; set; }
    }
}