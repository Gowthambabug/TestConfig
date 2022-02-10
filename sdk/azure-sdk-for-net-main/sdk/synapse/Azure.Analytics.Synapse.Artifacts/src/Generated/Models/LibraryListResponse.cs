// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of Library resources. </summary>
    internal partial class LibraryListResponse
    {
        /// <summary> Initializes a new instance of LibraryListResponse. </summary>
        /// <param name="value"> List of Library. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LibraryListResponse(IEnumerable<LibraryResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of LibraryListResponse. </summary>
        /// <param name="value"> List of Library. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal LibraryListResponse(IReadOnlyList<LibraryResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Library. </summary>
        public IReadOnlyList<LibraryResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}