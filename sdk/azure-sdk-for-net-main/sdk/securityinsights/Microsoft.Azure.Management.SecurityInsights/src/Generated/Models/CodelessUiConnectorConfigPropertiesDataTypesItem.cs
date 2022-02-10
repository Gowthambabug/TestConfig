// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using System.Linq;

    public partial class CodelessUiConnectorConfigPropertiesDataTypesItem : LastDataReceivedDataType
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CodelessUiConnectorConfigPropertiesDataTypesItem class.
        /// </summary>
        public CodelessUiConnectorConfigPropertiesDataTypesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CodelessUiConnectorConfigPropertiesDataTypesItem class.
        /// </summary>
        /// <param name="name">Name of the data type to show in the graph. can
        /// be use with {{graphQueriesTableName}} placeholder</param>
        /// <param name="lastDataReceivedQuery">Query for indicate last data
        /// received</param>
        public CodelessUiConnectorConfigPropertiesDataTypesItem(string name = default(string), string lastDataReceivedQuery = default(string))
            : base(name, lastDataReceivedQuery)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}