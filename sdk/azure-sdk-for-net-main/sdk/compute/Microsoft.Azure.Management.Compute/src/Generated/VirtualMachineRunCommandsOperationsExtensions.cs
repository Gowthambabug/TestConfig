// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineRunCommandsOperations.
    /// </summary>
    public static partial class VirtualMachineRunCommandsOperationsExtensions
    {
            /// <summary>
            /// Lists all available run commands for a subscription in a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location upon which run commands is queried.
            /// </param>
            public static IPage<RunCommandDocumentBase> List(this IVirtualMachineRunCommandsOperations operations, string location)
            {
                return operations.ListAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all available run commands for a subscription in a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location upon which run commands is queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RunCommandDocumentBase>> ListAsync(this IVirtualMachineRunCommandsOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets specific run command for a subscription in a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location upon which run commands is queried.
            /// </param>
            /// <param name='commandId'>
            /// The command id.
            /// </param>
            public static RunCommandDocument Get(this IVirtualMachineRunCommandsOperations operations, string location, string commandId)
            {
                return operations.GetAsync(location, commandId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets specific run command for a subscription in a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location upon which run commands is queried.
            /// </param>
            /// <param name='commandId'>
            /// The command id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RunCommandDocument> GetAsync(this IVirtualMachineRunCommandsOperations operations, string location, string commandId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, commandId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be created or
            /// updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Create Virtual Machine RunCommand operation.
            /// </param>
            public static VirtualMachineRunCommand CreateOrUpdate(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommand runCommand)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, vmName, runCommandName, runCommand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be created or
            /// updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Create Virtual Machine RunCommand operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineRunCommand> CreateOrUpdateAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommand runCommand, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, runCommandName, runCommand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Update Virtual Machine RunCommand operation.
            /// </param>
            public static VirtualMachineRunCommand Update(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommandUpdate runCommand)
            {
                return operations.UpdateAsync(resourceGroupName, vmName, runCommandName, runCommand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Update Virtual Machine RunCommand operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineRunCommand> UpdateAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommandUpdate runCommand, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, vmName, runCommandName, runCommand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be deleted.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            public static void Delete(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName)
            {
                operations.DeleteAsync(resourceGroupName, vmName, runCommandName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be deleted.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmName, runCommandName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation to get the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the run command.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            public static VirtualMachineRunCommand GetByVirtualMachine(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, string expand = default(string))
            {
                return operations.GetByVirtualMachineAsync(resourceGroupName, vmName, runCommandName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the run command.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineRunCommand> GetByVirtualMachineAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByVirtualMachineWithHttpMessagesAsync(resourceGroupName, vmName, runCommandName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to get all run commands of a Virtual Machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the run command.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            public static IPage<VirtualMachineRunCommand> ListByVirtualMachine(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string expand = default(string))
            {
                return operations.ListByVirtualMachineAsync(resourceGroupName, vmName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get all run commands of a Virtual Machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the run command.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachineRunCommand>> ListByVirtualMachineAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVirtualMachineWithHttpMessagesAsync(resourceGroupName, vmName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be created or
            /// updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Create Virtual Machine RunCommand operation.
            /// </param>
            public static VirtualMachineRunCommand BeginCreateOrUpdate(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommand runCommand)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, vmName, runCommandName, runCommand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be created or
            /// updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Create Virtual Machine RunCommand operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineRunCommand> BeginCreateOrUpdateAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommand runCommand, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, runCommandName, runCommand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Update Virtual Machine RunCommand operation.
            /// </param>
            public static VirtualMachineRunCommand BeginUpdate(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommandUpdate runCommand)
            {
                return operations.BeginUpdateAsync(resourceGroupName, vmName, runCommandName, runCommand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be updated.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='runCommand'>
            /// Parameters supplied to the Update Virtual Machine RunCommand operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineRunCommand> BeginUpdateAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, VirtualMachineRunCommandUpdate runCommand, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, vmName, runCommandName, runCommand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be deleted.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            public static void BeginDelete(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName)
            {
                operations.BeginDeleteAsync(resourceGroupName, vmName, runCommandName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the run command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the run command should be deleted.
            /// </param>
            /// <param name='runCommandName'>
            /// The name of the virtual machine run command.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualMachineRunCommandsOperations operations, string resourceGroupName, string vmName, string runCommandName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmName, runCommandName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all available run commands for a subscription in a location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RunCommandDocumentBase> ListNext(this IVirtualMachineRunCommandsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all available run commands for a subscription in a location.
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
            public static async Task<IPage<RunCommandDocumentBase>> ListNextAsync(this IVirtualMachineRunCommandsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to get all run commands of a Virtual Machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualMachineRunCommand> ListByVirtualMachineNext(this IVirtualMachineRunCommandsOperations operations, string nextPageLink)
            {
                return operations.ListByVirtualMachineNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get all run commands of a Virtual Machine.
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
            public static async Task<IPage<VirtualMachineRunCommand>> ListByVirtualMachineNextAsync(this IVirtualMachineRunCommandsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVirtualMachineNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}