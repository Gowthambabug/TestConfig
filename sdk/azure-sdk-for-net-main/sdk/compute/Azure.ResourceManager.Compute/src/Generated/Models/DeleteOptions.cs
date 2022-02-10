// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
    public readonly partial struct DeleteOptions : IEquatable<DeleteOptions>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeleteOptions"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeleteOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "Delete";
        private const string DetachValue = "Detach";

        /// <summary> Delete. </summary>
        public static DeleteOptions Delete { get; } = new DeleteOptions(DeleteValue);
        /// <summary> Detach. </summary>
        public static DeleteOptions Detach { get; } = new DeleteOptions(DetachValue);
        /// <summary> Determines if two <see cref="DeleteOptions"/> values are the same. </summary>
        public static bool operator ==(DeleteOptions left, DeleteOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeleteOptions"/> values are not the same. </summary>
        public static bool operator !=(DeleteOptions left, DeleteOptions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeleteOptions"/>. </summary>
        public static implicit operator DeleteOptions(string value) => new DeleteOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeleteOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeleteOptions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}