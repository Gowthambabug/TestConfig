// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The azure async operation response.
    /// </summary>
    public partial class AsyncOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the AsyncOperationResult class.
        /// </summary>
        public AsyncOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AsyncOperationResult class.
        /// </summary>
        /// <param name="status">The async operation state. Possible values
        /// include: 'InProgress', 'Succeeded', 'Failed'</param>
        /// <param name="error">The operation error information.</param>
        public AsyncOperationResult(string status = default(string), Errors error = default(Errors))
        {
            Status = status;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the async operation state. Possible values include:
        /// 'InProgress', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the operation error information.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Errors Error { get; set; }

    }
}
