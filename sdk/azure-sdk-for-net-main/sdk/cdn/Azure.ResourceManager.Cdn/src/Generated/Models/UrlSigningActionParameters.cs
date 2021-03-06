// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for the Url Signing action. </summary>
    public partial class UrlSigningActionParameters
    {
        /// <summary> Initializes a new instance of UrlSigningActionParameters. </summary>
        /// <param name="odataType"></param>
        public UrlSigningActionParameters(UrlSigningActionParametersOdataType odataType)
        {
            OdataType = odataType;
            ParameterNameOverride = new ChangeTrackingList<UrlSigningParamIdentifier>();
        }

        /// <summary> Initializes a new instance of UrlSigningActionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="algorithm"> Algorithm to use for URL signing. </param>
        /// <param name="parameterNameOverride"> Defines which query string parameters in the url to be considered for expires, key id etc. </param>
        internal UrlSigningActionParameters(UrlSigningActionParametersOdataType odataType, UrlSigningAlgorithm? algorithm, IList<UrlSigningParamIdentifier> parameterNameOverride)
        {
            OdataType = odataType;
            Algorithm = algorithm;
            ParameterNameOverride = parameterNameOverride;
        }

        /// <summary> Gets or sets the odata type. </summary>
        public UrlSigningActionParametersOdataType OdataType { get; set; }
        /// <summary> Algorithm to use for URL signing. </summary>
        public UrlSigningAlgorithm? Algorithm { get; set; }
        /// <summary> Defines which query string parameters in the url to be considered for expires, key id etc. </summary>
        public IList<UrlSigningParamIdentifier> ParameterNameOverride { get; }
    }
}
