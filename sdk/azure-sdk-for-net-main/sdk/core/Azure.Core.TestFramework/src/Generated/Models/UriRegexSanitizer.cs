// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Core.TestFramework.Models
{
    /// <summary> Sanitizer for a request URI. </summary>
    public partial class UriRegexSanitizer
    {
        /// <summary> Initializes a new instance of UriRegexSanitizer. </summary>
        /// <param name="regex"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="regex"/> or <paramref name="value"/> is null. </exception>
        public UriRegexSanitizer(string regex, string value)
        {
            if (regex == null)
            {
                throw new ArgumentNullException(nameof(regex));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Regex = regex;
            Value = value;
        }

        /// <summary> Gets the regex. </summary>
        public string Regex { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Gets or sets the group for replace. </summary>
        public string GroupForReplace { get; set; }
    }
}
