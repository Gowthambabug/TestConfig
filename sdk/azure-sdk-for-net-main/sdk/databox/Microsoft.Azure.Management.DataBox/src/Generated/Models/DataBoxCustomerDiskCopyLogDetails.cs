// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Copy Log Details for customer disk
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBoxCustomerDisk")]
    public partial class DataBoxCustomerDiskCopyLogDetails : CopyLogDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxCustomerDiskCopyLogDetails
        /// class.
        /// </summary>
        public DataBoxCustomerDiskCopyLogDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxCustomerDiskCopyLogDetails
        /// class.
        /// </summary>
        /// <param name="serialNumber">Disk Serial Number.</param>
        /// <param name="errorLogLink">Link for copy error logs.</param>
        /// <param name="verboseLogLink">Link for copy verbose logs.</param>
        public DataBoxCustomerDiskCopyLogDetails(string serialNumber = default(string), string errorLogLink = default(string), string verboseLogLink = default(string))
        {
            SerialNumber = serialNumber;
            ErrorLogLink = errorLogLink;
            VerboseLogLink = verboseLogLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets disk Serial Number.
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; private set; }

        /// <summary>
        /// Gets link for copy error logs.
        /// </summary>
        [JsonProperty(PropertyName = "errorLogLink")]
        public string ErrorLogLink { get; private set; }

        /// <summary>
        /// Gets link for copy verbose logs.
        /// </summary>
        [JsonProperty(PropertyName = "verboseLogLink")]
        public string VerboseLogLink { get; private set; }

    }
}
