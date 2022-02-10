// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> RerunTrigger resource type. </summary>
    public partial class RerunTriggerResource : SubResource
    {
        /// <summary> Initializes a new instance of RerunTriggerResource. </summary>
        /// <param name="properties"> Properties of the rerun trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RerunTriggerResource(RerunTumblingWindowTrigger properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of RerunTriggerResource. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="properties"> Properties of the rerun trigger. </param>
        internal RerunTriggerResource(string id, string name, string type, string etag, RerunTumblingWindowTrigger properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Properties of the rerun trigger. </summary>
        public RerunTumblingWindowTrigger Properties { get; set; }
    }
}