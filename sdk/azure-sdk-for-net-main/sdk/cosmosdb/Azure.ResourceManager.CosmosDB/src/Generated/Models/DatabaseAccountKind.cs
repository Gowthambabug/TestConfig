// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Indicates the type of database account. This can only be set at database account creation. </summary>
    public readonly partial struct DatabaseAccountKind : IEquatable<DatabaseAccountKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseAccountKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseAccountKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GlobalDocumentDBValue = "GlobalDocumentDB";
        private const string MongoDBValue = "MongoDB";
        private const string ParseValue = "Parse";

        /// <summary> GlobalDocumentDB. </summary>
        public static DatabaseAccountKind GlobalDocumentDB { get; } = new DatabaseAccountKind(GlobalDocumentDBValue);
        /// <summary> MongoDB. </summary>
        public static DatabaseAccountKind MongoDB { get; } = new DatabaseAccountKind(MongoDBValue);
        /// <summary> Parse. </summary>
        public static DatabaseAccountKind Parse { get; } = new DatabaseAccountKind(ParseValue);
        /// <summary> Determines if two <see cref="DatabaseAccountKind"/> values are the same. </summary>
        public static bool operator ==(DatabaseAccountKind left, DatabaseAccountKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseAccountKind"/> values are not the same. </summary>
        public static bool operator !=(DatabaseAccountKind left, DatabaseAccountKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatabaseAccountKind"/>. </summary>
        public static implicit operator DatabaseAccountKind(string value) => new DatabaseAccountKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseAccountKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseAccountKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}