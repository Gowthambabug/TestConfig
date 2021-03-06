// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Identifies an object. </summary>
    public partial class NameIdentifier
    {
        /// <summary> Initializes a new instance of NameIdentifier. </summary>
        public NameIdentifier()
        {
        }

        /// <summary> Initializes a new instance of NameIdentifier. </summary>
        /// <param name="name"> Name of the object. </param>
        internal NameIdentifier(string name)
        {
            Name = name;
        }

        /// <summary> Name of the object. </summary>
        public string Name { get; set; }
    }
}
