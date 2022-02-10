// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayInfo))
            {
                writer.WritePropertyName("displayInfo");
                writer.WriteObjectValue(DisplayInfo);
            }
            writer.WritePropertyName("hierarchyInformation");
            writer.WriteObjectValue(HierarchyInformation);
            writer.WriteEndObject();
        }

        internal static ProductDetails DeserializeProductDetails(JsonElement element)
        {
            Optional<DisplayInfo> displayInfo = default;
            HierarchyInformation hierarchyInformation = default;
            Optional<int> count = default;
            Optional<DoubleEncryptionStatus> productDoubleEncryptionStatus = default;
            Optional<IReadOnlyList<DeviceDetails>> deviceDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayInfo = DisplayInfo.DeserializeDisplayInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("hierarchyInformation"))
                {
                    hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("productDoubleEncryptionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    productDoubleEncryptionStatus = new DoubleEncryptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deviceDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeviceDetails> array = new List<DeviceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.DeviceDetails.DeserializeDeviceDetails(item));
                    }
                    deviceDetails = array;
                    continue;
                }
            }
            return new ProductDetails(displayInfo.Value, hierarchyInformation, Optional.ToNullable(count), Optional.ToNullable(productDoubleEncryptionStatus), Optional.ToList(deviceDetails));
        }
    }
}