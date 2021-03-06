// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Protocol to be verified on. </summary>
    public readonly partial struct IpFlowProtocol : IEquatable<IpFlowProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IpFlowProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IpFlowProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TCPValue = "TCP";
        private const string UDPValue = "UDP";

        /// <summary> TCP. </summary>
        public static IpFlowProtocol TCP { get; } = new IpFlowProtocol(TCPValue);
        /// <summary> UDP. </summary>
        public static IpFlowProtocol UDP { get; } = new IpFlowProtocol(UDPValue);
        /// <summary> Determines if two <see cref="IpFlowProtocol"/> values are the same. </summary>
        public static bool operator ==(IpFlowProtocol left, IpFlowProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IpFlowProtocol"/> values are not the same. </summary>
        public static bool operator !=(IpFlowProtocol left, IpFlowProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IpFlowProtocol"/>. </summary>
        public static implicit operator IpFlowProtocol(string value) => new IpFlowProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IpFlowProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IpFlowProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
