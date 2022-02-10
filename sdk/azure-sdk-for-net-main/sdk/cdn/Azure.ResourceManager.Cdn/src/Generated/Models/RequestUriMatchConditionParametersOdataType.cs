// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RequestUriMatchConditionParametersOdataType. </summary>
    public readonly partial struct RequestUriMatchConditionParametersOdataType : IEquatable<RequestUriMatchConditionParametersOdataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RequestUriMatchConditionParametersOdataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestUriMatchConditionParametersOdataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftAzureCdnModelsDeliveryRuleRequestUriConditionParametersValue = "#Microsoft.Azure.Cdn.Models.DeliveryRuleRequestUriConditionParameters";

        /// <summary> #Microsoft.Azure.Cdn.Models.DeliveryRuleRequestUriConditionParameters. </summary>
        public static RequestUriMatchConditionParametersOdataType MicrosoftAzureCdnModelsDeliveryRuleRequestUriConditionParameters { get; } = new RequestUriMatchConditionParametersOdataType(MicrosoftAzureCdnModelsDeliveryRuleRequestUriConditionParametersValue);
        /// <summary> Determines if two <see cref="RequestUriMatchConditionParametersOdataType"/> values are the same. </summary>
        public static bool operator ==(RequestUriMatchConditionParametersOdataType left, RequestUriMatchConditionParametersOdataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestUriMatchConditionParametersOdataType"/> values are not the same. </summary>
        public static bool operator !=(RequestUriMatchConditionParametersOdataType left, RequestUriMatchConditionParametersOdataType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RequestUriMatchConditionParametersOdataType"/>. </summary>
        public static implicit operator RequestUriMatchConditionParametersOdataType(string value) => new RequestUriMatchConditionParametersOdataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestUriMatchConditionParametersOdataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestUriMatchConditionParametersOdataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}