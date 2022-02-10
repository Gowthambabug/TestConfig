// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters to be applied to the cluster-autoscaler when enabled
    /// </summary>
    public partial class ManagedClusterPropertiesAutoScalerProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterPropertiesAutoScalerProfile class.
        /// </summary>
        public ManagedClusterPropertiesAutoScalerProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterPropertiesAutoScalerProfile class.
        /// </summary>
        /// <param name="balanceSimilarNodeGroups">Detects similar node pools
        /// and balances the number of nodes between them.</param>
        /// <param name="expander">The expander to use when scaling up</param>
        /// <param name="maxEmptyBulkDelete">The maximum number of empty nodes
        /// that can be deleted at the same time. This must be a positive
        /// integer.</param>
        /// <param name="maxGracefulTerminationSec">The maximum number of
        /// seconds the cluster autoscaler waits for pod termination when
        /// trying to scale down a node.</param>
        /// <param name="maxNodeProvisionTime">The maximum time the autoscaler
        /// waits for a node to be provisioned.</param>
        /// <param name="maxTotalUnreadyPercentage">The maximum percentage of
        /// unready nodes in the cluster. After this percentage is exceeded,
        /// cluster autoscaler halts operations.</param>
        /// <param name="newPodScaleUpDelay">Ignore unscheduled pods before
        /// they're a certain age.</param>
        /// <param name="okTotalUnreadyCount">The number of allowed unready
        /// nodes, irrespective of max-total-unready-percentage.</param>
        /// <param name="scanInterval">How often cluster is reevaluated for
        /// scale up or down.</param>
        /// <param name="scaleDownDelayAfterAdd">How long after scale up that
        /// scale down evaluation resumes</param>
        /// <param name="scaleDownDelayAfterDelete">How long after node
        /// deletion that scale down evaluation resumes.</param>
        /// <param name="scaleDownDelayAfterFailure">How long after scale down
        /// failure that scale down evaluation resumes.</param>
        /// <param name="scaleDownUnneededTime">How long a node should be
        /// unneeded before it is eligible for scale down.</param>
        /// <param name="scaleDownUnreadyTime">How long an unready node should
        /// be unneeded before it is eligible for scale down</param>
        /// <param name="scaleDownUtilizationThreshold">Node utilization level,
        /// defined as sum of requested resources divided by capacity, below
        /// which a node can be considered for scale down.</param>
        /// <param name="skipNodesWithLocalStorage">If cluster autoscaler will
        /// skip deleting nodes with pods with local storage, for example,
        /// EmptyDir or HostPath.</param>
        /// <param name="skipNodesWithSystemPods">If cluster autoscaler will
        /// skip deleting nodes with pods from kube-system (except for
        /// DaemonSet or mirror pods)</param>
        public ManagedClusterPropertiesAutoScalerProfile(string balanceSimilarNodeGroups = default(string), string expander = default(string), string maxEmptyBulkDelete = default(string), string maxGracefulTerminationSec = default(string), string maxNodeProvisionTime = default(string), string maxTotalUnreadyPercentage = default(string), string newPodScaleUpDelay = default(string), string okTotalUnreadyCount = default(string), string scanInterval = default(string), string scaleDownDelayAfterAdd = default(string), string scaleDownDelayAfterDelete = default(string), string scaleDownDelayAfterFailure = default(string), string scaleDownUnneededTime = default(string), string scaleDownUnreadyTime = default(string), string scaleDownUtilizationThreshold = default(string), string skipNodesWithLocalStorage = default(string), string skipNodesWithSystemPods = default(string))
        {
            BalanceSimilarNodeGroups = balanceSimilarNodeGroups;
            Expander = expander;
            MaxEmptyBulkDelete = maxEmptyBulkDelete;
            MaxGracefulTerminationSec = maxGracefulTerminationSec;
            MaxNodeProvisionTime = maxNodeProvisionTime;
            MaxTotalUnreadyPercentage = maxTotalUnreadyPercentage;
            NewPodScaleUpDelay = newPodScaleUpDelay;
            OkTotalUnreadyCount = okTotalUnreadyCount;
            ScanInterval = scanInterval;
            ScaleDownDelayAfterAdd = scaleDownDelayAfterAdd;
            ScaleDownDelayAfterDelete = scaleDownDelayAfterDelete;
            ScaleDownDelayAfterFailure = scaleDownDelayAfterFailure;
            ScaleDownUnneededTime = scaleDownUnneededTime;
            ScaleDownUnreadyTime = scaleDownUnreadyTime;
            ScaleDownUtilizationThreshold = scaleDownUtilizationThreshold;
            SkipNodesWithLocalStorage = skipNodesWithLocalStorage;
            SkipNodesWithSystemPods = skipNodesWithSystemPods;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets detects similar node pools and balances the number of
        /// nodes between them.
        /// </summary>
        /// <remarks>
        /// Valid values are 'true' and 'false'
        /// </remarks>
        [JsonProperty(PropertyName = "balance-similar-node-groups")]
        public string BalanceSimilarNodeGroups { get; set; }

        /// <summary>
        /// Gets or sets the expander to use when scaling up
        /// </summary>
        /// <remarks>
        /// If not specified, the default is 'random'. See
        /// [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders)
        /// for more information. Possible values include: 'least-waste',
        /// 'most-pods', 'priority', 'random'
        /// </remarks>
        [JsonProperty(PropertyName = "expander")]
        public string Expander { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of empty nodes that can be deleted
        /// at the same time. This must be a positive integer.
        /// </summary>
        /// <remarks>
        /// The default is 10.
        /// </remarks>
        [JsonProperty(PropertyName = "max-empty-bulk-delete")]
        public string MaxEmptyBulkDelete { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of seconds the cluster autoscaler
        /// waits for pod termination when trying to scale down a node.
        /// </summary>
        /// <remarks>
        /// The default is 600.
        /// </remarks>
        [JsonProperty(PropertyName = "max-graceful-termination-sec")]
        public string MaxGracefulTerminationSec { get; set; }

        /// <summary>
        /// Gets or sets the maximum time the autoscaler waits for a node to be
        /// provisioned.
        /// </summary>
        /// <remarks>
        /// The default is '15m'. Values must be an integer followed by an 'm'.
        /// No unit of time other than minutes (m) is supported.
        /// </remarks>
        [JsonProperty(PropertyName = "max-node-provision-time")]
        public string MaxNodeProvisionTime { get; set; }

        /// <summary>
        /// Gets or sets the maximum percentage of unready nodes in the
        /// cluster. After this percentage is exceeded, cluster autoscaler
        /// halts operations.
        /// </summary>
        /// <remarks>
        /// The default is 45. The maximum is 100 and the minimum is 0.
        /// </remarks>
        [JsonProperty(PropertyName = "max-total-unready-percentage")]
        public string MaxTotalUnreadyPercentage { get; set; }

        /// <summary>
        /// Gets or sets ignore unscheduled pods before they're a certain age.
        /// </summary>
        /// <remarks>
        /// For scenarios like burst/batch scale where you don't want CA to act
        /// before the kubernetes scheduler could schedule all the pods, you
        /// can tell CA to ignore unscheduled pods before they're a certain
        /// age. The default is '0s'. Values must be an integer followed by a
        /// unit ('s' for seconds, 'm' for minutes, 'h' for hours, etc).
        /// </remarks>
        [JsonProperty(PropertyName = "new-pod-scale-up-delay")]
        public string NewPodScaleUpDelay { get; set; }

        /// <summary>
        /// Gets or sets the number of allowed unready nodes, irrespective of
        /// max-total-unready-percentage.
        /// </summary>
        /// <remarks>
        /// This must be an integer. The default is 3.
        /// </remarks>
        [JsonProperty(PropertyName = "ok-total-unready-count")]
        public string OkTotalUnreadyCount { get; set; }

        /// <summary>
        /// Gets or sets how often cluster is reevaluated for scale up or down.
        /// </summary>
        /// <remarks>
        /// The default is '10'. Values must be an integer number of seconds.
        /// </remarks>
        [JsonProperty(PropertyName = "scan-interval")]
        public string ScanInterval { get; set; }

        /// <summary>
        /// Gets or sets how long after scale up that scale down evaluation
        /// resumes
        /// </summary>
        /// <remarks>
        /// The default is '10m'. Values must be an integer followed by an 'm'.
        /// No unit of time other than minutes (m) is supported.
        /// </remarks>
        [JsonProperty(PropertyName = "scale-down-delay-after-add")]
        public string ScaleDownDelayAfterAdd { get; set; }

        /// <summary>
        /// Gets or sets how long after node deletion that scale down
        /// evaluation resumes.
        /// </summary>
        /// <remarks>
        /// The default is the scan-interval. Values must be an integer
        /// followed by an 'm'. No unit of time other than minutes (m) is
        /// supported.
        /// </remarks>
        [JsonProperty(PropertyName = "scale-down-delay-after-delete")]
        public string ScaleDownDelayAfterDelete { get; set; }

        /// <summary>
        /// Gets or sets how long after scale down failure that scale down
        /// evaluation resumes.
        /// </summary>
        /// <remarks>
        /// The default is '3m'. Values must be an integer followed by an 'm'.
        /// No unit of time other than minutes (m) is supported.
        /// </remarks>
        [JsonProperty(PropertyName = "scale-down-delay-after-failure")]
        public string ScaleDownDelayAfterFailure { get; set; }

        /// <summary>
        /// Gets or sets how long a node should be unneeded before it is
        /// eligible for scale down.
        /// </summary>
        /// <remarks>
        /// The default is '10m'. Values must be an integer followed by an 'm'.
        /// No unit of time other than minutes (m) is supported.
        /// </remarks>
        [JsonProperty(PropertyName = "scale-down-unneeded-time")]
        public string ScaleDownUnneededTime { get; set; }

        /// <summary>
        /// Gets or sets how long an unready node should be unneeded before it
        /// is eligible for scale down
        /// </summary>
        /// <remarks>
        /// The default is '20m'. Values must be an integer followed by an 'm'.
        /// No unit of time other than minutes (m) is supported.
        /// </remarks>
        [JsonProperty(PropertyName = "scale-down-unready-time")]
        public string ScaleDownUnreadyTime { get; set; }

        /// <summary>
        /// Gets or sets node utilization level, defined as sum of requested
        /// resources divided by capacity, below which a node can be considered
        /// for scale down.
        /// </summary>
        /// <remarks>
        /// The default is '0.5'.
        /// </remarks>
        [JsonProperty(PropertyName = "scale-down-utilization-threshold")]
        public string ScaleDownUtilizationThreshold { get; set; }

        /// <summary>
        /// Gets or sets if cluster autoscaler will skip deleting nodes with
        /// pods with local storage, for example, EmptyDir or HostPath.
        /// </summary>
        /// <remarks>
        /// The default is true.
        /// </remarks>
        [JsonProperty(PropertyName = "skip-nodes-with-local-storage")]
        public string SkipNodesWithLocalStorage { get; set; }

        /// <summary>
        /// Gets or sets if cluster autoscaler will skip deleting nodes with
        /// pods from kube-system (except for DaemonSet or mirror pods)
        /// </summary>
        /// <remarks>
        /// The default is true.
        /// </remarks>
        [JsonProperty(PropertyName = "skip-nodes-with-system-pods")]
        public string SkipNodesWithSystemPods { get; set; }

    }
}