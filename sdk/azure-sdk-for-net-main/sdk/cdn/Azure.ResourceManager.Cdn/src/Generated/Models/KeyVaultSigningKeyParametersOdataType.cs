// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The KeyVaultSigningKeyParametersOdataType. </summary>
    public readonly partial struct KeyVaultSigningKeyParametersOdataType : IEquatable<KeyVaultSigningKeyParametersOdataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KeyVaultSigningKeyParametersOdataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KeyVaultSigningKeyParametersOdataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftAzureCdnModelsKeyVaultSigningKeyParametersValue = "#Microsoft.Azure.Cdn.Models.KeyVaultSigningKeyParameters";

        /// <summary> #Microsoft.Azure.Cdn.Models.KeyVaultSigningKeyParameters. </summary>
        public static KeyVaultSigningKeyParametersOdataType MicrosoftAzureCdnModelsKeyVaultSigningKeyParameters { get; } = new KeyVaultSigningKeyParametersOdataType(MicrosoftAzureCdnModelsKeyVaultSigningKeyParametersValue);
        /// <summary> Determines if two <see cref="KeyVaultSigningKeyParametersOdataType"/> values are the same. </summary>
        public static bool operator ==(KeyVaultSigningKeyParametersOdataType left, KeyVaultSigningKeyParametersOdataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyVaultSigningKeyParametersOdataType"/> values are not the same. </summary>
        public static bool operator !=(KeyVaultSigningKeyParametersOdataType left, KeyVaultSigningKeyParametersOdataType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyVaultSigningKeyParametersOdataType"/>. </summary>
        public static implicit operator KeyVaultSigningKeyParametersOdataType(string value) => new KeyVaultSigningKeyParametersOdataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyVaultSigningKeyParametersOdataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyVaultSigningKeyParametersOdataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
