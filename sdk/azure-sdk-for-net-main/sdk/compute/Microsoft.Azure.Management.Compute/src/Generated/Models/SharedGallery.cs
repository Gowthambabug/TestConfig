// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies information about the Shared Gallery that you want to create
    /// or update.
    /// </summary>
    public partial class SharedGallery : PirSharedGalleryResource
    {
        /// <summary>
        /// Initializes a new instance of the SharedGallery class.
        /// </summary>
        public SharedGallery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharedGallery class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="location">Resource location</param>
        /// <param name="uniqueId">The unique id of this shared
        /// gallery.</param>
        public SharedGallery(string name = default(string), string location = default(string), string uniqueId = default(string))
            : base(name, location, uniqueId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}