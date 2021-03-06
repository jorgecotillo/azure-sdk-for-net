// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WorkflowTriggersOperations.
    /// </summary>
    public static partial class WorkflowTriggersOperationsExtensions
    {
            /// <summary>
            /// Gets a list of workflow triggers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<WorkflowTrigger> List(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, ODataQuery<WorkflowTriggerFilter> odataQuery = default(ODataQuery<WorkflowTriggerFilter>))
            {
                return operations.ListAsync(resourceGroupName, workflowName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow triggers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowTrigger>> ListAsync(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, ODataQuery<WorkflowTriggerFilter> odataQuery = default(ODataQuery<WorkflowTriggerFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workflowName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            public static WorkflowTrigger Get(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName)
            {
                return operations.GetAsync(resourceGroupName, workflowName, triggerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowTrigger> GetAsync(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Resets a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            public static void Reset(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName)
            {
                operations.ResetAsync(resourceGroupName, workflowName, triggerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ResetAsync(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ResetWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Runs a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            public static object Run(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName)
            {
                return operations.RunAsync(resourceGroupName, workflowName, triggerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Runs a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RunAsync(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RunWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the trigger schema as JSON.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            public static JsonSchema GetSchemaJson(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName)
            {
                return operations.GetSchemaJsonAsync(resourceGroupName, workflowName, triggerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the trigger schema as JSON.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JsonSchema> GetSchemaJsonAsync(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSchemaJsonWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the state of a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='setState'>
            /// The workflow trigger state.
            /// </param>
            public static void SetState(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName, SetTriggerStateActionDefinition setState)
            {
                operations.SetStateAsync(resourceGroupName, workflowName, triggerName, setState).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the state of a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='setState'>
            /// The workflow trigger state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetStateAsync(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName, SetTriggerStateActionDefinition setState, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetStateWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, setState, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the callback URL for a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            public static WorkflowTriggerCallbackUrl ListCallbackUrl(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName)
            {
                return operations.ListCallbackUrlAsync(resourceGroupName, workflowName, triggerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the callback URL for a workflow trigger.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='triggerName'>
            /// The workflow trigger name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowTriggerCallbackUrl> ListCallbackUrlAsync(this IWorkflowTriggersOperations operations, string resourceGroupName, string workflowName, string triggerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCallbackUrlWithHttpMessagesAsync(resourceGroupName, workflowName, triggerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of workflow triggers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkflowTrigger> ListNext(this IWorkflowTriggersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of workflow triggers.
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
            public static async Task<IPage<WorkflowTrigger>> ListNextAsync(this IWorkflowTriggersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
