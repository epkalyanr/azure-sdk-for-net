namespace Microsoft.Azure.Management.Resources
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class ManagementLocksOperationsExtensions
    {
            /// <summary>
            /// Create or update a management lock at the resource group level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='lockName'>
            /// The lock name.
            /// </param>
            /// <param name='parameters'>
            /// The management lock parameters.
            /// </param>
            public static ManagementLock CreateOrUpdateAtResourceGroupLevel(this IManagementLocksOperations operations, string resourceGroupName, string lockName, ManagementLock parameters)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).CreateOrUpdateAtResourceGroupLevelAsync(resourceGroupName, lockName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a management lock at the resource group level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='lockName'>
            /// The lock name.
            /// </param>
            /// <param name='parameters'>
            /// The management lock parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ManagementLock> CreateOrUpdateAtResourceGroupLevelAsync( this IManagementLocksOperations operations, string resourceGroupName, string lockName, ManagementLock parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ManagementLock> result = await operations.CreateOrUpdateAtResourceGroupLevelWithHttpMessagesAsync(resourceGroupName, lockName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Create or update a management lock at the resource level or any level
            /// below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='parentResourcePath'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceName'>
            /// Resource identity.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            /// <param name='parameters'>
            /// Create or update management lock parameters.
            /// </param>
            public static ManagementLock CreateOrUpdateAtResourceLevel(this IManagementLocksOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string lockName, ManagementLock parameters)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).CreateOrUpdateAtResourceLevelAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, lockName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a management lock at the resource level or any level
            /// below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='parentResourcePath'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceName'>
            /// Resource identity.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            /// <param name='parameters'>
            /// Create or update management lock parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ManagementLock> CreateOrUpdateAtResourceLevelAsync( this IManagementLocksOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string lockName, ManagementLock parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ManagementLock> result = await operations.CreateOrUpdateAtResourceLevelWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, lockName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes the management lock of a resource or any level below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='parentResourcePath'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceName'>
            /// Resource identity.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            public static void DeleteAtResourceLevel(this IManagementLocksOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string lockName)
            {
                Task.Factory.StartNew(s => ((IManagementLocksOperations)s).DeleteAtResourceLevelAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, lockName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the management lock of a resource or any level below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='parentResourcePath'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceName'>
            /// Resource identity.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAtResourceLevelAsync( this IManagementLocksOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string lockName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAtResourceLevelWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, lockName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create or update a management lock at the subscription level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            /// <param name='parameters'>
            /// The management lock parameters.
            /// </param>
            public static ManagementLock CreateOrUpdateAtSubscriptionLevel(this IManagementLocksOperations operations, string lockName, ManagementLock parameters)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).CreateOrUpdateAtSubscriptionLevelAsync(lockName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a management lock at the subscription level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            /// <param name='parameters'>
            /// The management lock parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ManagementLock> CreateOrUpdateAtSubscriptionLevelAsync( this IManagementLocksOperations operations, string lockName, ManagementLock parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ManagementLock> result = await operations.CreateOrUpdateAtSubscriptionLevelWithHttpMessagesAsync(lockName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes the management lock of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            public static void DeleteAtSubscriptionLevel(this IManagementLocksOperations operations, string lockName)
            {
                Task.Factory.StartNew(s => ((IManagementLocksOperations)s).DeleteAtSubscriptionLevelAsync(lockName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the management lock of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAtSubscriptionLevelAsync( this IManagementLocksOperations operations, string lockName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAtSubscriptionLevelWithHttpMessagesAsync(lockName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the management lock of a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lockName'>
            /// Name of the management lock.
            /// </param>
            public static ManagementLock Get(this IManagementLocksOperations operations, string lockName)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).GetAsync(lockName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the management lock of a scope.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='lockName'>
            /// Name of the management lock.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ManagementLock> GetAsync( this IManagementLocksOperations operations, string lockName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ManagementLock> result = await operations.GetWithHttpMessagesAsync(lockName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Deletes the management lock of a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group names.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            public static void DeleteAtResourceGroupLevel(this IManagementLocksOperations operations, string resourceGroup, string lockName)
            {
                Task.Factory.StartNew(s => ((IManagementLocksOperations)s).DeleteAtResourceGroupLevelAsync(resourceGroup, lockName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the management lock of a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group names.
            /// </param>
            /// <param name='lockName'>
            /// The name of lock.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAtResourceGroupLevelAsync( this IManagementLocksOperations operations, string resourceGroup, string lockName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAtResourceGroupLevelWithHttpMessagesAsync(resourceGroup, lockName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets all the management locks of a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static Page<ManagementLock> ListAtResourceGroupLevel(this IManagementLocksOperations operations, string resourceGroupName, Expression<Func<ManagementLock, bool>> filter = default(Expression<Func<ManagementLock, bool>>))
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListAtResourceGroupLevelAsync(resourceGroupName, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the management locks of a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListAtResourceGroupLevelAsync( this IManagementLocksOperations operations, string resourceGroupName, Expression<Func<ManagementLock, bool>> filter = default(Expression<Func<ManagementLock, bool>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListAtResourceGroupLevelWithHttpMessagesAsync(resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets all the management locks of a resource or any level below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='parentResourcePath'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceName'>
            /// Resource identity.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static Page<ManagementLock> ListAtResourceLevel(this IManagementLocksOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, Expression<Func<ManagementLock, bool>> filter = default(Expression<Func<ManagementLock, bool>>))
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListAtResourceLevelAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the management locks of a resource or any level below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// Resource identity.
            /// </param>
            /// <param name='parentResourcePath'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceType'>
            /// Resource identity.
            /// </param>
            /// <param name='resourceName'>
            /// Resource identity.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListAtResourceLevelAsync( this IManagementLocksOperations operations, string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, Expression<Func<ManagementLock, bool>> filter = default(Expression<Func<ManagementLock, bool>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListAtResourceLevelWithHttpMessagesAsync(resourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get a list of management locks at resource level or below.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<ManagementLock> ListNext(this IManagementLocksOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of management locks at resource level or below.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListNextAsync( this IManagementLocksOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets all the management locks of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static Page<ManagementLock> ListAtSubscriptionLevel(this IManagementLocksOperations operations, Expression<Func<ManagementLock, bool>> filter = default(Expression<Func<ManagementLock, bool>>))
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListAtSubscriptionLevelAsync(filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the management locks of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListAtSubscriptionLevelAsync( this IManagementLocksOperations operations, Expression<Func<ManagementLock, bool>> filter = default(Expression<Func<ManagementLock, bool>>), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListAtSubscriptionLevelWithHttpMessagesAsync(filter, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets all the management locks of a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<ManagementLock> ListAtResourceGroupLevelNext(this IManagementLocksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListAtResourceGroupLevelNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the management locks of a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListAtResourceGroupLevelNextAsync( this IManagementLocksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListAtResourceGroupLevelNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets all the management locks of a resource or any level below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<ManagementLock> ListAtResourceLevelNext(this IManagementLocksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListAtResourceLevelNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the management locks of a resource or any level below resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListAtResourceLevelNextAsync( this IManagementLocksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListAtResourceLevelNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get a list of management locks at resource level or below.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<ManagementLock> ListNextNext(this IManagementLocksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListNextNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of management locks at resource level or below.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListNextNextAsync( this IManagementLocksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListNextNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets all the management locks of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static Page<ManagementLock> ListAtSubscriptionLevelNext(this IManagementLocksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IManagementLocksOperations)s).ListAtSubscriptionLevelNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the management locks of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Page<ManagementLock>> ListAtSubscriptionLevelNextAsync( this IManagementLocksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Page<ManagementLock>> result = await operations.ListAtSubscriptionLevelNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}