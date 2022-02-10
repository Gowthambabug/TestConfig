// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Whether or not public endpoint access is allowed for this server.  Value is optional but if passed in, must be &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
    public readonly partial struct ServerNetworkAccessFlag : IEquatable<ServerNetworkAccessFlag>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerNetworkAccessFlag"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerNetworkAccessFlag(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ServerNetworkAccessFlag Enabled { get; } = new ServerNetworkAccessFlag(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ServerNetworkAccessFlag Disabled { get; } = new ServerNetworkAccessFlag(DisabledValue);
        /// <summary> Determines if two <see cref="ServerNetworkAccessFlag"/> values are the same. </summary>
        public static bool operator ==(ServerNetworkAccessFlag left, ServerNetworkAccessFlag right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerNetworkAccessFlag"/> values are not the same. </summary>
        public static bool operator !=(ServerNetworkAccessFlag left, ServerNetworkAccessFlag right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerNetworkAccessFlag"/>. </summary>
        public static implicit operator ServerNetworkAccessFlag(string value) => new ServerNetworkAccessFlag(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerNetworkAccessFlag other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerNetworkAccessFlag other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}