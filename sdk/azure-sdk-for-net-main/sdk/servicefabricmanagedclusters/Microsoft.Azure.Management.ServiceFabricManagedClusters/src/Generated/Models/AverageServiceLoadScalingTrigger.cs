// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a scaling policy related to an average load of a
    /// metric/resource of a service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AverageServiceLoadTrigger")]
    public partial class AverageServiceLoadScalingTrigger : ScalingTrigger
    {
        /// <summary>
        /// Initializes a new instance of the AverageServiceLoadScalingTrigger
        /// class.
        /// </summary>
        public AverageServiceLoadScalingTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AverageServiceLoadScalingTrigger
        /// class.
        /// </summary>
        /// <param name="metricName">The name of the metric for which usage
        /// should be tracked.</param>
        /// <param name="lowerLoadThreshold">The lower limit of the load below
        /// which a scale in operation should be performed.</param>
        /// <param name="upperLoadThreshold">The upper limit of the load beyond
        /// which a scale out operation should be performed.</param>
        /// <param name="scaleInterval">The period in seconds on which a
        /// decision is made whether to scale or not. This property should come
        /// in ISO 8601 format "hh:mm:ss".</param>
        /// <param name="useOnlyPrimaryLoad">Flag determines whether only the
        /// load of primary replica should be considered for scaling. If set to
        /// true, then trigger will only consider the load of primary replicas
        /// of stateful service. If set to false, trigger will consider load of
        /// all replicas. This parameter cannot be set to true for stateless
        /// service.</param>
        public AverageServiceLoadScalingTrigger(string metricName, double lowerLoadThreshold, double upperLoadThreshold, string scaleInterval, bool useOnlyPrimaryLoad)
        {
            MetricName = metricName;
            LowerLoadThreshold = lowerLoadThreshold;
            UpperLoadThreshold = upperLoadThreshold;
            ScaleInterval = scaleInterval;
            UseOnlyPrimaryLoad = useOnlyPrimaryLoad;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metric for which usage should be
        /// tracked.
        /// </summary>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }

        /// <summary>
        /// Gets or sets the lower limit of the load below which a scale in
        /// operation should be performed.
        /// </summary>
        [JsonProperty(PropertyName = "lowerLoadThreshold")]
        public double LowerLoadThreshold { get; set; }

        /// <summary>
        /// Gets or sets the upper limit of the load beyond which a scale out
        /// operation should be performed.
        /// </summary>
        [JsonProperty(PropertyName = "upperLoadThreshold")]
        public double UpperLoadThreshold { get; set; }

        /// <summary>
        /// Gets or sets the period in seconds on which a decision is made
        /// whether to scale or not. This property should come in ISO 8601
        /// format "hh:mm:ss".
        /// </summary>
        [JsonProperty(PropertyName = "scaleInterval")]
        public string ScaleInterval { get; set; }

        /// <summary>
        /// Gets or sets flag determines whether only the load of primary
        /// replica should be considered for scaling. If set to true, then
        /// trigger will only consider the load of primary replicas of stateful
        /// service. If set to false, trigger will consider load of all
        /// replicas. This parameter cannot be set to true for stateless
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "useOnlyPrimaryLoad")]
        public bool UseOnlyPrimaryLoad { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MetricName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetricName");
            }
            if (ScaleInterval == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScaleInterval");
            }
        }
    }
}