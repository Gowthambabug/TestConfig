// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Database connection string value to type pair. </summary>
    public partial class ConnStringValueTypePair
    {
        /// <summary> Initializes a new instance of ConnStringValueTypePair. </summary>
        /// <param name="value"> Value of pair. </param>
        /// <param name="type"> Type of database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnStringValueTypePair(string value, ConnectionStringType type)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
            Type = type;
        }

        /// <summary> Value of pair. </summary>
        public string Value { get; set; }
        /// <summary> Type of database. </summary>
        public ConnectionStringType Type { get; set; }
    }
}