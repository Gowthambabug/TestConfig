// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a active directory administrator. </summary>
    public partial class ServerExternalAdministrator
    {
        /// <summary> Initializes a new instance of ServerExternalAdministrator. </summary>
        public ServerExternalAdministrator()
        {
        }

        /// <summary> Initializes a new instance of ServerExternalAdministrator. </summary>
        /// <param name="administratorType"> Type of the sever administrator. </param>
        /// <param name="principalType"> Principal Type of the sever administrator. </param>
        /// <param name="login"> Login name of the server administrator. </param>
        /// <param name="sid"> SID (object ID) of the server administrator. </param>
        /// <param name="tenantId"> Tenant ID of the administrator. </param>
        /// <param name="azureADOnlyAuthentication"> Azure Active Directory only Authentication enabled. </param>
        internal ServerExternalAdministrator(AdministratorType? administratorType, PrincipalType? principalType, string login, Guid? sid, Guid? tenantId, bool? azureADOnlyAuthentication)
        {
            AdministratorType = administratorType;
            PrincipalType = principalType;
            Login = login;
            Sid = sid;
            TenantId = tenantId;
            AzureADOnlyAuthentication = azureADOnlyAuthentication;
        }

        /// <summary> Type of the sever administrator. </summary>
        public AdministratorType? AdministratorType { get; set; }
        /// <summary> Principal Type of the sever administrator. </summary>
        public PrincipalType? PrincipalType { get; set; }
        /// <summary> Login name of the server administrator. </summary>
        public string Login { get; set; }
        /// <summary> SID (object ID) of the server administrator. </summary>
        public Guid? Sid { get; set; }
        /// <summary> Tenant ID of the administrator. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Azure Active Directory only Authentication enabled. </summary>
        public bool? AzureADOnlyAuthentication { get; set; }
    }
}