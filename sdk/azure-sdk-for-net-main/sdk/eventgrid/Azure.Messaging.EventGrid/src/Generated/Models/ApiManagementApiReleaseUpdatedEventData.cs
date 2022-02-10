// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ApiManagement.APIReleaseUpdated event. </summary>
    public partial class ApiManagementApiReleaseUpdatedEventData
    {
        /// <summary> Initializes a new instance of ApiManagementApiReleaseUpdatedEventData. </summary>
        internal ApiManagementApiReleaseUpdatedEventData()
        {
        }

        /// <summary> Initializes a new instance of ApiManagementApiReleaseUpdatedEventData. </summary>
        /// <param name="resourceUri"> The fully qualified ID of the resource that the compliance state change is for, including the resource name and resource type. Uses the format, `/subscriptions/&lt;SubscriptionID&gt;/resourceGroups/&lt;ResourceGroup&gt;/Microsoft.ApiManagement/service/&lt;ServiceName&gt;/&lt;ResourceType&gt;/&lt;ResourceName&gt;`. </param>
        internal ApiManagementApiReleaseUpdatedEventData(string resourceUri)
        {
            ResourceUri = resourceUri;
        }

        /// <summary> The fully qualified ID of the resource that the compliance state change is for, including the resource name and resource type. Uses the format, `/subscriptions/&lt;SubscriptionID&gt;/resourceGroups/&lt;ResourceGroup&gt;/Microsoft.ApiManagement/service/&lt;ServiceName&gt;/&lt;ResourceType&gt;/&lt;ResourceName&gt;`. </summary>
        public string ResourceUri { get; }
    }
}