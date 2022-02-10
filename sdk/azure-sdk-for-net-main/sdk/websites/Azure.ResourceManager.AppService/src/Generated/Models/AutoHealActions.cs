// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Actions which to take by the auto-heal module when a rule is triggered. </summary>
    public partial class AutoHealActions
    {
        /// <summary> Initializes a new instance of AutoHealActions. </summary>
        public AutoHealActions()
        {
        }

        /// <summary> Initializes a new instance of AutoHealActions. </summary>
        /// <param name="actionType"> Predefined action to be taken. </param>
        /// <param name="customAction"> Custom action to be taken. </param>
        /// <param name="minProcessExecutionTime">
        /// Minimum time the process must execute
        /// before taking the action
        /// </param>
        internal AutoHealActions(AutoHealActionType? actionType, AutoHealCustomAction customAction, string minProcessExecutionTime)
        {
            ActionType = actionType;
            CustomAction = customAction;
            MinProcessExecutionTime = minProcessExecutionTime;
        }

        /// <summary> Predefined action to be taken. </summary>
        public AutoHealActionType? ActionType { get; set; }
        /// <summary> Custom action to be taken. </summary>
        public AutoHealCustomAction CustomAction { get; set; }
        /// <summary>
        /// Minimum time the process must execute
        /// before taking the action
        /// </summary>
        public string MinProcessExecutionTime { get; set; }
    }
}