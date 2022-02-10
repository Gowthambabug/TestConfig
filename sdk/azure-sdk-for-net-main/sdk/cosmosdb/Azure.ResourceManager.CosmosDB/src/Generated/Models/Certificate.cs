// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The Certificate. </summary>
    public partial class Certificate
    {
        /// <summary> Initializes a new instance of Certificate. </summary>
        public Certificate()
        {
        }

        /// <summary> Initializes a new instance of Certificate. </summary>
        /// <param name="pem"> PEM formatted public key. </param>
        internal Certificate(string pem)
        {
            Pem = pem;
        }

        /// <summary> PEM formatted public key. </summary>
        public string Pem { get; set; }
    }
}