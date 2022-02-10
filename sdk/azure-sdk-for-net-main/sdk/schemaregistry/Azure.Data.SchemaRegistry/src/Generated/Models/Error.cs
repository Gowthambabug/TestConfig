// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> An error response returned from Azure Schema Registry service. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="errorValue"> Error response returned from Azure Schema Registry service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errorValue"/> is null. </exception>
        internal Error(ErrorDetail errorValue)
        {
            if (errorValue == null)
            {
                throw new ArgumentNullException(nameof(errorValue));
            }

            ErrorValue = errorValue;
        }

        /// <summary> Error response returned from Azure Schema Registry service. </summary>
        public ErrorDetail ErrorValue { get; }
    }
}