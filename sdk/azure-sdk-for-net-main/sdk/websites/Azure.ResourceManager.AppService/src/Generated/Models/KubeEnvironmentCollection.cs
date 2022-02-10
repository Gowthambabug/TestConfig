// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Collection of Kubernetes Environments. </summary>
    internal partial class KubeEnvironmentCollection
    {
        /// <summary> Initializes a new instance of KubeEnvironmentCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal KubeEnvironmentCollection(IEnumerable<KubeEnvironmentData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of KubeEnvironmentCollection. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal KubeEnvironmentCollection(IReadOnlyList<KubeEnvironmentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<KubeEnvironmentData> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}