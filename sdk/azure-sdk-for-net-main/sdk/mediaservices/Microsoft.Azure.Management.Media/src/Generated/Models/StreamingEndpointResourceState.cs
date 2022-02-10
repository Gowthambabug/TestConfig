// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for StreamingEndpointResourceState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(StreamingEndpointResourceStateConverter))]
    public struct StreamingEndpointResourceState : System.IEquatable<StreamingEndpointResourceState>
    {
        private StreamingEndpointResourceState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// The initial state of a streaming endpoint after creation. Content
        /// is not ready to be streamed from this endpoint.
        /// </summary>
        public static readonly StreamingEndpointResourceState Stopped = "Stopped";

        /// <summary>
        /// The streaming endpoint is transitioning to the running state.
        /// </summary>
        public static readonly StreamingEndpointResourceState Starting = "Starting";

        /// <summary>
        /// The streaming endpoint is running. It is able to stream content to
        /// clients
        /// </summary>
        public static readonly StreamingEndpointResourceState Running = "Running";

        /// <summary>
        /// The streaming endpoint is transitioning to the stopped state.
        /// </summary>
        public static readonly StreamingEndpointResourceState Stopping = "Stopping";

        /// <summary>
        /// The streaming endpoint is being deleted.
        /// </summary>
        public static readonly StreamingEndpointResourceState Deleting = "Deleting";

        /// <summary>
        /// The streaming endpoint is increasing or decreasing scale units.
        /// </summary>
        public static readonly StreamingEndpointResourceState Scaling = "Scaling";


        /// <summary>
        /// Underlying value of enum StreamingEndpointResourceState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for StreamingEndpointResourceState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type StreamingEndpointResourceState
        /// </summary>
        public bool Equals(StreamingEndpointResourceState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// StreamingEndpointResourceState
        /// </summary>
        public static implicit operator StreamingEndpointResourceState(string value)
        {
            return new StreamingEndpointResourceState(value);
        }

        /// <summary>
        /// Implicit operator to convert StreamingEndpointResourceState to
        /// string
        /// </summary>
        public static implicit operator string(StreamingEndpointResourceState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum StreamingEndpointResourceState
        /// </summary>
        public static bool operator == (StreamingEndpointResourceState e1, StreamingEndpointResourceState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum StreamingEndpointResourceState
        /// </summary>
        public static bool operator != (StreamingEndpointResourceState e1, StreamingEndpointResourceState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for StreamingEndpointResourceState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is StreamingEndpointResourceState && Equals((StreamingEndpointResourceState)obj);
        }

        /// <summary>
        /// Returns for hashCode StreamingEndpointResourceState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}