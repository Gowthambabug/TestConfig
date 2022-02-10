// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.Personalizer
{
    internal partial class EvaluationsCreateHeaders
    {
        private readonly Response _response;
        public EvaluationsCreateHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Location of the Offline Evaluation status and data. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}