// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for Kind.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(KindConverter))]
    public struct Kind : System.IEquatable<Kind>
    {
        private Kind(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Live pipeline topology resource.
        /// </summary>
        public static readonly Kind Live = "Live";

        /// <summary>
        /// Batch pipeline topology resource.
        /// </summary>
        public static readonly Kind Batch = "Batch";


        /// <summary>
        /// Underlying value of enum Kind
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for Kind
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type Kind
        /// </summary>
        public bool Equals(Kind e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to Kind
        /// </summary>
        public static implicit operator Kind(string value)
        {
            return new Kind(value);
        }

        /// <summary>
        /// Implicit operator to convert Kind to string
        /// </summary>
        public static implicit operator string(Kind e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum Kind
        /// </summary>
        public static bool operator == (Kind e1, Kind e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum Kind
        /// </summary>
        public static bool operator != (Kind e1, Kind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for Kind
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Kind && Equals((Kind)obj);
        }

        /// <summary>
        /// Returns for hashCode Kind
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
