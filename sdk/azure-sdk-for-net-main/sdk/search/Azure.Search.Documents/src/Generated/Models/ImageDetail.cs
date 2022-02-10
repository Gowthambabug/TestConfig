// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A string indicating which domain-specific details to return. </summary>
    public readonly partial struct ImageDetail : IEquatable<ImageDetail>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageDetail"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageDetail(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CelebritiesValue = "celebrities";
        private const string LandmarksValue = "landmarks";

        /// <summary> Details recognized as celebrities. </summary>
        public static ImageDetail Celebrities { get; } = new ImageDetail(CelebritiesValue);
        /// <summary> Details recognized as landmarks. </summary>
        public static ImageDetail Landmarks { get; } = new ImageDetail(LandmarksValue);
        /// <summary> Determines if two <see cref="ImageDetail"/> values are the same. </summary>
        public static bool operator ==(ImageDetail left, ImageDetail right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageDetail"/> values are not the same. </summary>
        public static bool operator !=(ImageDetail left, ImageDetail right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImageDetail"/>. </summary>
        public static implicit operator ImageDetail(string value) => new ImageDetail(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageDetail other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}