// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    /// <summary> The SkillNames. </summary>
    public partial class ResetSkillsOptions
    {
        /// <summary> Initializes a new instance of ResetSkillsOptions. </summary>
        public ResetSkillsOptions()
        {
            SkillNames = new ChangeTrackingList<string>();
        }

        /// <summary> the names of skills to be reset. </summary>
        public IList<string> SkillNames { get; }
    }
}
