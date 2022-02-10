// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class StartRecordingResult
    {
        internal static StartRecordingResult DeserializeStartRecordingResult(JsonElement element)
        {
            Optional<string> recordingId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingId"))
                {
                    recordingId = property.Value.GetString();
                    continue;
                }
            }
            return new StartRecordingResult(recordingId.Value);
        }
    }
}