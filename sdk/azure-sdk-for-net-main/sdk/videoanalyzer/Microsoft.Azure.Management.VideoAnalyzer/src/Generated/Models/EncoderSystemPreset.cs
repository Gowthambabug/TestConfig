// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a built-in preset for encoding the input content using the
    /// encoder processor.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.VideoAnalyzer.EncoderSystemPreset")]
    public partial class EncoderSystemPreset : EncoderPresetBase
    {
        /// <summary>
        /// Initializes a new instance of the EncoderSystemPreset class.
        /// </summary>
        public EncoderSystemPreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncoderSystemPreset class.
        /// </summary>
        /// <param name="name">Name of the built-in encoding preset. Possible
        /// values include: 'SingleLayer_540p_H264_AAC',
        /// 'SingleLayer_720p_H264_AAC', 'SingleLayer_1080p_H264_AAC',
        /// 'SingleLayer_2160p_H264_AAC'</param>
        public EncoderSystemPreset(EncoderSystemPresetType name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the built-in encoding preset. Possible values
        /// include: 'SingleLayer_540p_H264_AAC', 'SingleLayer_720p_H264_AAC',
        /// 'SingleLayer_1080p_H264_AAC', 'SingleLayer_2160p_H264_AAC'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public EncoderSystemPresetType Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}