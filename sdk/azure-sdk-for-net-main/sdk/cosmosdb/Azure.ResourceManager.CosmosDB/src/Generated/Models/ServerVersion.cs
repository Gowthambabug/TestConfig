// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Describes the ServerVersion of an a MongoDB account. </summary>
    public readonly partial struct ServerVersion : IEquatable<ServerVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Three2Value = "3.2";
        private const string Three6Value = "3.6";
        private const string Four0Value = "4.0";

        /// <summary> 3.2. </summary>
        public static ServerVersion Three2 { get; } = new ServerVersion(Three2Value);
        /// <summary> 3.6. </summary>
        public static ServerVersion Three6 { get; } = new ServerVersion(Three6Value);
        /// <summary> 4.0. </summary>
        public static ServerVersion Four0 { get; } = new ServerVersion(Four0Value);
        /// <summary> Determines if two <see cref="ServerVersion"/> values are the same. </summary>
        public static bool operator ==(ServerVersion left, ServerVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerVersion"/> values are not the same. </summary>
        public static bool operator !=(ServerVersion left, ServerVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerVersion"/>. </summary>
        public static implicit operator ServerVersion(string value) => new ServerVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}