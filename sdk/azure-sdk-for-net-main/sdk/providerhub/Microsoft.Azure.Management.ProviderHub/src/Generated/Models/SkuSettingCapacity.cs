// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using System.Linq;

    public partial class SkuSettingCapacity : SkuCapacity
    {
        /// <summary>
        /// Initializes a new instance of the SkuSettingCapacity class.
        /// </summary>
        public SkuSettingCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuSettingCapacity class.
        /// </summary>
        /// <param name="scaleType">Possible values include: 'None', 'Manual',
        /// 'Automatic'</param>
        public SkuSettingCapacity(int minimum, int? maximum = default(int?), int? defaultProperty = default(int?), string scaleType = default(string))
            : base(minimum, maximum, defaultProperty, scaleType)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}