// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IpAllocation type. </summary>
    public readonly partial struct IpAllocationType : IEquatable<IpAllocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IpAllocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IpAllocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UndefinedValue = "Undefined";
        private const string HypernetValue = "Hypernet";

        /// <summary> Undefined. </summary>
        public static IpAllocationType Undefined { get; } = new IpAllocationType(UndefinedValue);
        /// <summary> Hypernet. </summary>
        public static IpAllocationType Hypernet { get; } = new IpAllocationType(HypernetValue);
        /// <summary> Determines if two <see cref="IpAllocationType"/> values are the same. </summary>
        public static bool operator ==(IpAllocationType left, IpAllocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IpAllocationType"/> values are not the same. </summary>
        public static bool operator !=(IpAllocationType left, IpAllocationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IpAllocationType"/>. </summary>
        public static implicit operator IpAllocationType(string value) => new IpAllocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IpAllocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IpAllocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
