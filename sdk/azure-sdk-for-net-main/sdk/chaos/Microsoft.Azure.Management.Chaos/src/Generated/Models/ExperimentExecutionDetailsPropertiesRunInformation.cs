// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Chaos.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The information of the experiment run.
    /// </summary>
    public partial class ExperimentExecutionDetailsPropertiesRunInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExperimentExecutionDetailsPropertiesRunInformation class.
        /// </summary>
        public ExperimentExecutionDetailsPropertiesRunInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExperimentExecutionDetailsPropertiesRunInformation class.
        /// </summary>
        /// <param name="steps">The steps of the experiment run.</param>
        public ExperimentExecutionDetailsPropertiesRunInformation(IList<StepStatus> steps = default(IList<StepStatus>))
        {
            Steps = steps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the steps of the experiment run.
        /// </summary>
        [JsonProperty(PropertyName = "steps")]
        public IList<StepStatus> Steps { get; private set; }

    }
}
