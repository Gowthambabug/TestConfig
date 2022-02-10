// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Asynchronous operation status of the operation on the app service plan. </summary>
    public readonly partial struct AsyncStatus : IEquatable<AsyncStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AsyncStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AsyncStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartedValue = "Started";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";

        /// <summary> Async operation has started. </summary>
        public static AsyncStatus Started { get; } = new AsyncStatus(StartedValue);
        /// <summary> Async operation has completed. </summary>
        public static AsyncStatus Completed { get; } = new AsyncStatus(CompletedValue);
        /// <summary> Async operation failed to complete. </summary>
        public static AsyncStatus Failed { get; } = new AsyncStatus(FailedValue);
        /// <summary> Determines if two <see cref="AsyncStatus"/> values are the same. </summary>
        public static bool operator ==(AsyncStatus left, AsyncStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AsyncStatus"/> values are not the same. </summary>
        public static bool operator !=(AsyncStatus left, AsyncStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AsyncStatus"/>. </summary>
        public static implicit operator AsyncStatus(string value) => new AsyncStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AsyncStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AsyncStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}