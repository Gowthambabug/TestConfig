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
    /// Optional properties to be used in case a new video resource needs to be
    /// created on the service. These will not take effect if the video already
    /// exists.
    /// </summary>
    public partial class VideoCreationProperties
    {
        /// <summary>
        /// Initializes a new instance of the VideoCreationProperties class.
        /// </summary>
        public VideoCreationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoCreationProperties class.
        /// </summary>
        /// <param name="title">Optional title provided by the user. Value can
        /// be up to 256 characters long.</param>
        /// <param name="description">Optional description provided by the
        /// user. Value can be up to 2048 characters long.</param>
        /// <param name="segmentLength">Segment length indicates the length of
        /// individual content files (segments) which are persisted to storage.
        /// Smaller segments provide lower archive playback latency but
        /// generate larger volume of storage transactions. Larger segments
        /// reduce the amount of storage transactions while increasing the
        /// archive playback latency. Value must be specified in ISO8601
        /// duration format (i.e. "PT30S" equals 30 seconds) and can vary
        /// between 30 seconds to 5 minutes, in 30 seconds increments. Changing
        /// this value after the initial call to create the video resource can
        /// lead to errors when uploading content to the archive. Default value
        /// is 30 seconds. This property is only allowed for topologies where
        /// "kind" is set to "live".</param>
        /// <param name="retentionPeriod">Video retention period indicates how
        /// long the video is kept in storage. Value must be specified in
        /// ISO8601 duration format (i.e. "P1D" equals 1 day) and can vary
        /// between 1 day to 10 years, in 1 day increments. When absent (null),
        /// all video content is retained indefinitely. This property is only
        /// allowed for topologies where "kind" is set to "live".</param>
        public VideoCreationProperties(string title = default(string), string description = default(string), string segmentLength = default(string), string retentionPeriod = default(string))
        {
            Title = title;
            Description = description;
            SegmentLength = segmentLength;
            RetentionPeriod = retentionPeriod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional title provided by the user. Value can be up
        /// to 256 characters long.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets optional description provided by the user. Value can
        /// be up to 2048 characters long.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets segment length indicates the length of individual
        /// content files (segments) which are persisted to storage. Smaller
        /// segments provide lower archive playback latency but generate larger
        /// volume of storage transactions. Larger segments reduce the amount
        /// of storage transactions while increasing the archive playback
        /// latency. Value must be specified in ISO8601 duration format (i.e.
        /// "PT30S" equals 30 seconds) and can vary between 30 seconds to 5
        /// minutes, in 30 seconds increments. Changing this value after the
        /// initial call to create the video resource can lead to errors when
        /// uploading content to the archive. Default value is 30 seconds. This
        /// property is only allowed for topologies where "kind" is set to
        /// "live".
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public string SegmentLength { get; set; }

        /// <summary>
        /// Gets or sets video retention period indicates how long the video is
        /// kept in storage. Value must be specified in ISO8601 duration format
        /// (i.e. "P1D" equals 1 day) and can vary between 1 day to 10 years,
        /// in 1 day increments. When absent (null), all video content is
        /// retained indefinitely. This property is only allowed for topologies
        /// where "kind" is set to "live".
        /// </summary>
        [JsonProperty(PropertyName = "retentionPeriod")]
        public string RetentionPeriod { get; set; }

    }
}