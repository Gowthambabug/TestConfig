// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallingServer
{
    internal static partial class RecordingContentExtensions
    {
        public static string ToSerialString(this RecordingContent value) => value switch
        {
            RecordingContent.Audio => "audio",
            RecordingContent.AudioVideo => "audioVideo",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecordingContent value.")
        };

        public static RecordingContent ToRecordingContent(this string value)
        {
            if (string.Equals(value, "audio", StringComparison.InvariantCultureIgnoreCase)) return RecordingContent.Audio;
            if (string.Equals(value, "audioVideo", StringComparison.InvariantCultureIgnoreCase)) return RecordingContent.AudioVideo;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecordingContent value.");
        }
    }
}
