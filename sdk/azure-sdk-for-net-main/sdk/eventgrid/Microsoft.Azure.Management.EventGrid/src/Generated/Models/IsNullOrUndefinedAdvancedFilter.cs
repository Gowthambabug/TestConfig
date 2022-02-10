// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IsNullOrUndefined Advanced Filter.
    /// </summary>
    [Newtonsoft.Json.JsonObject("IsNullOrUndefined")]
    public partial class IsNullOrUndefinedAdvancedFilter : AdvancedFilter
    {
        /// <summary>
        /// Initializes a new instance of the IsNullOrUndefinedAdvancedFilter
        /// class.
        /// </summary>
        public IsNullOrUndefinedAdvancedFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IsNullOrUndefinedAdvancedFilter
        /// class.
        /// </summary>
        /// <param name="key">The field/property in the event based on which
        /// you want to filter.</param>
        public IsNullOrUndefinedAdvancedFilter(string key = default(string))
            : base(key)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}