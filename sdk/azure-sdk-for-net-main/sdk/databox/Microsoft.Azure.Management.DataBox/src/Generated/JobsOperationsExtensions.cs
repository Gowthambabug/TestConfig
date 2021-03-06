// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobsOperations.
    /// </summary>
    public static partial class JobsOperationsExtensions
    {
            /// <summary>
            /// Lists all the jobs available under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on Get list of jobs, which provides the next page
            /// in the list of jobs.
            /// </param>
            public static IPage<JobResource> List(this IJobsOperations operations, string skipToken = default(string))
            {
                return operations.ListAsync(skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the jobs available under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on Get list of jobs, which provides the next page
            /// in the list of jobs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobResource>> ListAsync(this IJobsOperations operations, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request to mark devices for a given job as shipped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='deliverToDcPackageDetails'>
            /// Delivery package details
            /// </param>
            public static void MarkDevicesShipped(this IJobsOperations operations, string jobName, string resourceGroupName, PackageCarrierInfo deliverToDcPackageDetails)
            {
                operations.MarkDevicesShippedAsync(jobName, resourceGroupName, deliverToDcPackageDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request to mark devices for a given job as shipped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='deliverToDcPackageDetails'>
            /// Delivery package details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MarkDevicesShippedAsync(this IJobsOperations operations, string jobName, string resourceGroupName, PackageCarrierInfo deliverToDcPackageDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.MarkDevicesShippedWithHttpMessagesAsync(jobName, resourceGroupName, deliverToDcPackageDetails, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all the jobs available under the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on Get list of jobs, which provides the next page
            /// in the list of jobs.
            /// </param>
            public static IPage<JobResource> ListByResourceGroup(this IJobsOperations operations, string resourceGroupName, string skipToken = default(string))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the jobs available under the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on Get list of jobs, which provides the next page
            /// in the list of jobs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobResource>> ListByResourceGroupAsync(this IJobsOperations operations, string resourceGroupName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets information about the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='expand'>
            /// $expand is supported on details parameter for job, which provides details
            /// on the job stages.
            /// </param>
            public static JobResource Get(this IJobsOperations operations, string resourceGroupName, string jobName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, jobName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets information about the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='expand'>
            /// $expand is supported on details parameter for job, which provides details
            /// on the job stages.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResource> GetAsync(this IJobsOperations operations, string resourceGroupName, string jobName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, jobName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new job with the specified parameters. Existing job cannot be
            /// updated with this API and should instead be updated with the Update job
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResource'>
            /// Job details from request body.
            /// </param>
            public static JobResource Create(this IJobsOperations operations, string resourceGroupName, string jobName, JobResource jobResource)
            {
                return operations.CreateAsync(resourceGroupName, jobName, jobResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new job with the specified parameters. Existing job cannot be
            /// updated with this API and should instead be updated with the Update job
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResource'>
            /// Job details from request body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResource> CreateAsync(this IJobsOperations operations, string resourceGroupName, string jobName, JobResource jobResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, jobName, jobResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            public static void Delete(this IJobsOperations operations, string resourceGroupName, string jobName)
            {
                operations.DeleteAsync(resourceGroupName, jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJobsOperations operations, string resourceGroupName, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, jobName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the properties of an existing job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResourceUpdateParameter'>
            /// Job update parameters from request body.
            /// </param>
            /// <param name='ifMatch'>
            /// Defines the If-Match condition. The patch will be performed only if the
            /// ETag of the job on the server matches this value.
            /// </param>
            public static JobResource Update(this IJobsOperations operations, string resourceGroupName, string jobName, JobResourceUpdateParameter jobResourceUpdateParameter, string ifMatch = default(string))
            {
                return operations.UpdateAsync(resourceGroupName, jobName, jobResourceUpdateParameter, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of an existing job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResourceUpdateParameter'>
            /// Job update parameters from request body.
            /// </param>
            /// <param name='ifMatch'>
            /// Defines the If-Match condition. The patch will be performed only if the
            /// ETag of the job on the server matches this value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResource> UpdateAsync(this IJobsOperations operations, string resourceGroupName, string jobName, JobResourceUpdateParameter jobResourceUpdateParameter, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, jobName, jobResourceUpdateParameter, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Book shipment pick up.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='shipmentPickUpRequest'>
            /// Details of shipment pick up request.
            /// </param>
            public static ShipmentPickUpResponse BookShipmentPickUp(this IJobsOperations operations, string resourceGroupName, string jobName, ShipmentPickUpRequest shipmentPickUpRequest)
            {
                return operations.BookShipmentPickUpAsync(resourceGroupName, jobName, shipmentPickUpRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Book shipment pick up.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='shipmentPickUpRequest'>
            /// Details of shipment pick up request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ShipmentPickUpResponse> BookShipmentPickUpAsync(this IJobsOperations operations, string resourceGroupName, string jobName, ShipmentPickUpRequest shipmentPickUpRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BookShipmentPickUpWithHttpMessagesAsync(resourceGroupName, jobName, shipmentPickUpRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// CancelJob.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='reason'>
            /// Reason for cancellation.
            /// </param>
            public static void Cancel(this IJobsOperations operations, string resourceGroupName, string jobName, string reason)
            {
                operations.CancelAsync(resourceGroupName, jobName, reason).GetAwaiter().GetResult();
            }

            /// <summary>
            /// CancelJob.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='reason'>
            /// Reason for cancellation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync(this IJobsOperations operations, string resourceGroupName, string jobName, string reason, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(resourceGroupName, jobName, reason, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// This method gets the unencrypted secrets related to the job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            public static IEnumerable<UnencryptedCredentials> ListCredentials(this IJobsOperations operations, string resourceGroupName, string jobName)
            {
                return operations.ListCredentialsAsync(resourceGroupName, jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// This method gets the unencrypted secrets related to the job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<UnencryptedCredentials>> ListCredentialsAsync(this IJobsOperations operations, string resourceGroupName, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCredentialsWithHttpMessagesAsync(resourceGroupName, jobName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new job with the specified parameters. Existing job cannot be
            /// updated with this API and should instead be updated with the Update job
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResource'>
            /// Job details from request body.
            /// </param>
            public static JobResource BeginCreate(this IJobsOperations operations, string resourceGroupName, string jobName, JobResource jobResource)
            {
                return operations.BeginCreateAsync(resourceGroupName, jobName, jobResource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new job with the specified parameters. Existing job cannot be
            /// updated with this API and should instead be updated with the Update job
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResource'>
            /// Job details from request body.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResource> BeginCreateAsync(this IJobsOperations operations, string resourceGroupName, string jobName, JobResource jobResource, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, jobName, jobResource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            public static void BeginDelete(this IJobsOperations operations, string resourceGroupName, string jobName)
            {
                operations.BeginDeleteAsync(resourceGroupName, jobName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IJobsOperations operations, string resourceGroupName, string jobName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, jobName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates the properties of an existing job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResourceUpdateParameter'>
            /// Job update parameters from request body.
            /// </param>
            /// <param name='ifMatch'>
            /// Defines the If-Match condition. The patch will be performed only if the
            /// ETag of the job on the server matches this value.
            /// </param>
            public static JobResource BeginUpdate(this IJobsOperations operations, string resourceGroupName, string jobName, JobResourceUpdateParameter jobResourceUpdateParameter, string ifMatch = default(string))
            {
                return operations.BeginUpdateAsync(resourceGroupName, jobName, jobResourceUpdateParameter, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the properties of an existing job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The Resource Group Name
            /// </param>
            /// <param name='jobName'>
            /// The name of the job Resource within the specified resource group. job names
            /// must be between 3 and 24 characters in length and use any alphanumeric and
            /// underscore only
            /// </param>
            /// <param name='jobResourceUpdateParameter'>
            /// Job update parameters from request body.
            /// </param>
            /// <param name='ifMatch'>
            /// Defines the If-Match condition. The patch will be performed only if the
            /// ETag of the job on the server matches this value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResource> BeginUpdateAsync(this IJobsOperations operations, string resourceGroupName, string jobName, JobResourceUpdateParameter jobResourceUpdateParameter, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, jobName, jobResourceUpdateParameter, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the jobs available under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobResource> ListNext(this IJobsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the jobs available under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobResource>> ListNextAsync(this IJobsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the jobs available under the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobResource> ListByResourceGroupNext(this IJobsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the jobs available under the given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobResource>> ListByResourceGroupNextAsync(this IJobsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
