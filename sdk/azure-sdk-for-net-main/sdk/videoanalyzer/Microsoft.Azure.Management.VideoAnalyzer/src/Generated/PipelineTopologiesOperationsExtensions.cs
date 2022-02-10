// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PipelineTopologiesOperations.
    /// </summary>
    public static partial class PipelineTopologiesOperationsExtensions
    {
            /// <summary>
            /// Retrieves a list of pipeline topologies.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of pipeline topologies that have been added to the
            /// account, if any, along with their JSON representation.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned.
            /// </param>
            /// <param name='top'>
            /// Specifies a non-negative integer n that limits the number of items returned
            /// from a collection. The service returns the number of available items up to
            /// but not greater than the specified value n.
            /// </param>
            public static IPage<PipelineTopology> List(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string filter = default(string), int? top = default(int?))
            {
                return operations.ListAsync(resourceGroupName, accountName, filter, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of pipeline topologies.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of pipeline topologies that have been added to the
            /// account, if any, along with their JSON representation.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned.
            /// </param>
            /// <param name='top'>
            /// Specifies a non-negative integer n that limits the number of items returned
            /// from a collection. The service returns the number of available items up to
            /// but not greater than the specified value n.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PipelineTopology>> ListAsync(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, filter, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a specific pipeline topology by name.
            /// </summary>
            /// <remarks>
            /// Retrieves a specific pipeline topology by name. If a topology with that
            /// name has been previously created, the call will return the JSON
            /// representation of that topology.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            public static PipelineTopology Get(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName)
            {
                return operations.GetAsync(resourceGroupName, accountName, pipelineTopologyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a specific pipeline topology by name.
            /// </summary>
            /// <remarks>
            /// Retrieves a specific pipeline topology by name. If a topology with that
            /// name has been previously created, the call will return the JSON
            /// representation of that topology.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineTopology> GetAsync(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, pipelineTopologyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a pipeline topology.
            /// </summary>
            /// <remarks>
            /// Creates a new pipeline topology or updates an existing one, with the given
            /// name. A pipeline topology describes the processing steps to be applied when
            /// processing content for a particular outcome. The topology should be defined
            /// according to the scenario to be achieved and can be reused across many
            /// pipeline instances which share the same processing characteristics.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static PipelineTopology CreateOrUpdate(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName, PipelineTopology parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, pipelineTopologyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a pipeline topology.
            /// </summary>
            /// <remarks>
            /// Creates a new pipeline topology or updates an existing one, with the given
            /// name. A pipeline topology describes the processing steps to be applied when
            /// processing content for a particular outcome. The topology should be defined
            /// according to the scenario to be achieved and can be reused across many
            /// pipeline instances which share the same processing characteristics.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineTopology> CreateOrUpdateAsync(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName, PipelineTopology parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, pipelineTopologyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a pipeline topology.
            /// </summary>
            /// <remarks>
            /// Deletes a pipeline topology with the given name. This method should be
            /// called after all instances of the topology have been stopped and deleted.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            public static void Delete(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, pipelineTopologyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a pipeline topology.
            /// </summary>
            /// <remarks>
            /// Deletes a pipeline topology with the given name. This method should be
            /// called after all instances of the topology have been stopped and deleted.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, pipelineTopologyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an existing pipeline topology.
            /// </summary>
            /// <remarks>
            /// Updates an existing pipeline topology with the given name. If the
            /// associated live pipelines or pipeline jobs are in active or processing
            /// state, respectively, then only the description can be updated. Else, the
            /// properties that can be updated include: description, parameter
            /// declarations, sources, processors, and sinks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            public static PipelineTopology Update(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName, PipelineTopologyUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, pipelineTopologyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing pipeline topology.
            /// </summary>
            /// <remarks>
            /// Updates an existing pipeline topology with the given name. If the
            /// associated live pipelines or pipeline jobs are in active or processing
            /// state, respectively, then only the description can be updated. Else, the
            /// properties that can be updated include: description, parameter
            /// declarations, sources, processors, and sinks.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Video Analyzer account name.
            /// </param>
            /// <param name='pipelineTopologyName'>
            /// Pipeline topology unique identifier.
            /// </param>
            /// <param name='parameters'>
            /// The request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PipelineTopology> UpdateAsync(this IPipelineTopologiesOperations operations, string resourceGroupName, string accountName, string pipelineTopologyName, PipelineTopologyUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, pipelineTopologyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a list of pipeline topologies.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of pipeline topologies that have been added to the
            /// account, if any, along with their JSON representation.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PipelineTopology> ListNext(this IPipelineTopologiesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of pipeline topologies.
            /// </summary>
            /// <remarks>
            /// Retrieves a list of pipeline topologies that have been added to the
            /// account, if any, along with their JSON representation.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PipelineTopology>> ListNextAsync(this IPipelineTopologiesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}