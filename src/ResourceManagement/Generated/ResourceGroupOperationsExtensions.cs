// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources
{
    public static partial class ResourceGroupOperationsExtensions
    {
        /// <summary>
        /// Begin deleting resource group.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be deleted. The name is
        /// case insensitive.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginDeleting(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).BeginDeletingAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begin deleting resource group.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be deleted. The name is
        /// case insensitive.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginDeletingAsync(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return operations.BeginDeletingAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Checks whether resource group exists.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to check. The name is case
        /// insensitive.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static ResourceGroupExistsResult CheckExistence(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).CheckExistenceAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Checks whether resource group exists.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to check. The name is case
        /// insensitive.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static Task<ResourceGroupExistsResult> CheckExistenceAsync(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return operations.CheckExistenceAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create or update resource
        /// group service operation.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static ResourceGroupCreateOrUpdateResult CreateOrUpdate(this IResourceGroupOperations operations, string resourceGroupName, BasicResourceGroup parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create or update resource
        /// group service operation.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static Task<ResourceGroupCreateOrUpdateResult> CreateOrUpdateAsync(this IResourceGroupOperations operations, string resourceGroupName, BasicResourceGroup parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete resource group and all of its resources.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be deleted. The name is
        /// case insensitive.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).DeleteAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete resource group and all of its resources.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be deleted. The name is
        /// case insensitive.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return operations.DeleteAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to get. The name is case
        /// insensitive.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static ResourceGroupGetResult Get(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).GetAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to get. The name is case
        /// insensitive.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static Task<ResourceGroupGetResult> GetAsync(this IResourceGroupOperations operations, string resourceGroupName)
        {
            return operations.GetAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a collection of resource groups.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns all resource
        /// groups.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static ResourceGroupListResult List(this IResourceGroupOperations operations, ResourceGroupListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).ListAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a collection of resource groups.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If null is passed returns all resource
        /// groups.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static Task<ResourceGroupListResult> ListAsync(this IResourceGroupOperations operations, ResourceGroupListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static ResourceGroupListResult ListNext(this IResourceGroupOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        public static Task<ResourceGroupListResult> ListNextAsync(this IResourceGroupOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Resource groups can be updated through a simple PATCH operation to
        /// a group address. The format of the request is the same as that for
        /// creating a resource groups, though if a field is unspecified
        /// current value will be carried over.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be created or updated.
        /// The name is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the update state resource group
        /// service operation.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static ResourceGroupPatchResult Patch(this IResourceGroupOperations operations, string resourceGroupName, BasicResourceGroup parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IResourceGroupOperations)s).PatchAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Resource groups can be updated through a simple PATCH operation to
        /// a group address. The format of the request is the same as that for
        /// creating a resource groups, though if a field is unspecified
        /// current value will be carried over.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IResourceGroupOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group to be created or updated.
        /// The name is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the update state resource group
        /// service operation.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        public static Task<ResourceGroupPatchResult> PatchAsync(this IResourceGroupOperations operations, string resourceGroupName, BasicResourceGroup parameters)
        {
            return operations.PatchAsync(resourceGroupName, parameters, CancellationToken.None);
        }
    }
}
