// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using DataMigration.Tests.Helpers;
using Microsoft.Azure.Management.DataMigration;
using Microsoft.Azure.Management.DataMigration.Models;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;

namespace DataMigration.Tests.ScenarioTests
{
    public class CRUDDMSTestsBase : TestBase
    {
        protected static string ResourceGroupName;
        protected static string DmsDeploymentName;
        protected static string DmsProjectName;
        protected static string DmsFileName;

        public CRUDDMSTestsBase()
        {
            ResourceGroupName = "DmsSdkRg";
            DmsDeploymentName = "DmsSdkService";
            DmsProjectName = "DmsSdkProject";
            DmsFileName = "DmsSdkFile";
        }

        protected Project CreateDMSSqlProject(MockContext context,
            DataMigrationServiceClient client,
            ResourceGroup resourceGroup,
            string dmsInstanceName,
            string dmsProjectName)
        {
            return client.Projects.CreateOrUpdate(
                new Project(TestConfiguration.Location, ProjectSourcePlatform.SQL, ProjectTargetPlatform.SQLDB),
                resourceGroup.Name,
                dmsInstanceName,
                dmsProjectName);
        }

        protected Project CreateDMSPGProject(MockContext context,
            DataMigrationServiceClient client,
            ResourceGroup resourceGroup,
            string dmsInstanceName,
            string dmsProjectName)
        {
            return client.Projects.CreateOrUpdate(
                new Project(TestConfiguration.Location, ProjectSourcePlatform.PostgreSql, ProjectTargetPlatform.AzureDbForPostgreSql),
                resourceGroup.Name,
                dmsInstanceName,
                dmsProjectName);
        }

        protected Project CreateDMSMySqlProject(MockContext context,
            DataMigrationServiceClient client,
            ResourceGroup resourceGroup,
            string dmsInstanceName,
            string dmsProjectName)
        {
            return client.Projects.CreateOrUpdate(
                new Project(TestConfiguration.Location, ProjectSourcePlatform.MySQL, ProjectTargetPlatform.AzureDbForMySql),
                resourceGroup.Name,
                dmsInstanceName,
                dmsProjectName);
        }
        
        protected DataMigrationService CreateDMSInstance(MockContext context,
            DataMigrationServiceClient client,
            ResourceGroup resourceGroup,
            string dmsInstanceName)
        {
            return client.Services.CreateOrUpdate(new DataMigrationService(
                type: "Microsoft.DataMigration/services",
                location: resourceGroup.Location,
                virtualSubnetId: TestConfiguration.VirtualSubnetId,
                sku: new ServiceSku("Premium_4vCores", "Premium")),
                    resourceGroup.Name,
                    dmsInstanceName);
        }

        protected ResourceGroup CreateResourceGroup(MockContext context,
            RecordedDelegatingHandler handler,
            string resourceGroupName,
            string location)
        {
            var resourcesClient =
                Utilities.GetResourceManagementClient(
                    context,
                    handler);

            var resourceGroup = resourcesClient.ResourceGroups.CreateOrUpdate(
                resourceGroupName,
                new ResourceGroup
                {
                    Location = location
                });

            return resourceGroup;
        }

        protected void DeleteResourceGroup(MockContext context,
            RecordedDelegatingHandler handler,
            string resourceGroupName)
        {
            var resourcesClient =
                Utilities.GetResourceManagementClient(
                    context,
                    handler);

            resourcesClient.ResourceGroups.Delete(resourceGroupName);
        }
    }
}

