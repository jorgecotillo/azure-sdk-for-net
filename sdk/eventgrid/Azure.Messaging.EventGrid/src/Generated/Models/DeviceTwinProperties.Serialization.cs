// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class DeviceTwinProperties
    {
        internal static DeviceTwinProperties DeserializeDeviceTwinProperties(JsonElement element)
        {
            Optional<DeviceTwinMetadata> metadata = default;
            Optional<float> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = DeviceTwinMetadata.DeserializeDeviceTwinMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetSingle();
                    continue;
                }
            }
            return new DeviceTwinProperties(metadata.Value, Optional.ToNullable(version));
        }
    }
}
