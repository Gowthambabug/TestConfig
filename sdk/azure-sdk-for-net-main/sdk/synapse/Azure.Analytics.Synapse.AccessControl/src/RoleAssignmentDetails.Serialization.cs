// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.AccessControl
{
    public partial class RoleAssignmentDetails
    {
        internal static RoleAssignmentDetails DeserializeRoleAssignmentDetails(JsonElement element)
        {
            Optional<string> id = default;
            Optional<Guid> roleDefinitionId = default;
            Optional<Guid> principalId = default;
            Optional<string> scope = default;
            Optional<string> principalType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roleDefinitionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("scope"))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalType"))
                {
                    principalType = property.Value.GetString();
                    continue;
                }
            }
            return new RoleAssignmentDetails(id.Value, Optional.ToNullable(roleDefinitionId), Optional.ToNullable(principalId), scope.Value, principalType.Value);
        }
    }
}
