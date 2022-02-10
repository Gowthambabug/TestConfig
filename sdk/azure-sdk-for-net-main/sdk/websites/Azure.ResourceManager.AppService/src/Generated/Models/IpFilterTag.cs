// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Defines what this IP filter will be used for. This is to support IP filtering on proxies. </summary>
    public readonly partial struct IpFilterTag : IEquatable<IpFilterTag>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IpFilterTag"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IpFilterTag(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string XffProxyValue = "XffProxy";
        private const string ServiceTagValue = "ServiceTag";

        /// <summary> Default. </summary>
        public static IpFilterTag Default { get; } = new IpFilterTag(DefaultValue);
        /// <summary> XffProxy. </summary>
        public static IpFilterTag XffProxy { get; } = new IpFilterTag(XffProxyValue);
        /// <summary> ServiceTag. </summary>
        public static IpFilterTag ServiceTag { get; } = new IpFilterTag(ServiceTagValue);
        /// <summary> Determines if two <see cref="IpFilterTag"/> values are the same. </summary>
        public static bool operator ==(IpFilterTag left, IpFilterTag right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IpFilterTag"/> values are not the same. </summary>
        public static bool operator !=(IpFilterTag left, IpFilterTag right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IpFilterTag"/>. </summary>
        public static implicit operator IpFilterTag(string value) => new IpFilterTag(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IpFilterTag other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IpFilterTag other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}