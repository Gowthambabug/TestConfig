// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Functions host level keys. </summary>
    public partial class HostKeys
    {
        /// <summary> Initializes a new instance of HostKeys. </summary>
        internal HostKeys()
        {
            FunctionKeys = new ChangeTrackingDictionary<string, string>();
            SystemKeys = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of HostKeys. </summary>
        /// <param name="masterKey"> Secret key. </param>
        /// <param name="functionKeys"> Host level function keys. </param>
        /// <param name="systemKeys"> System keys. </param>
        internal HostKeys(string masterKey, IReadOnlyDictionary<string, string> functionKeys, IReadOnlyDictionary<string, string> systemKeys)
        {
            MasterKey = masterKey;
            FunctionKeys = functionKeys;
            SystemKeys = systemKeys;
        }

        /// <summary> Secret key. </summary>
        public string MasterKey { get; }
        /// <summary> Host level function keys. </summary>
        public IReadOnlyDictionary<string, string> FunctionKeys { get; }
        /// <summary> System keys. </summary>
        public IReadOnlyDictionary<string, string> SystemKeys { get; }
    }
}