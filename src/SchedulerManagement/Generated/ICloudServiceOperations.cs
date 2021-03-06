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
using Microsoft.WindowsAzure.Management.Scheduler.Models;

namespace Microsoft.WindowsAzure.Management.Scheduler
{
    public partial interface ICloudServiceOperations
    {
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// The cloud service name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginCreatingAsync(string cloudServiceName, CloudServiceCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete a cloud service.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// The cloud service name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginDeletingAsync(string cloudServiceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// The cloud service name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<CloudServiceOperationStatusResponse> CreateAsync(string cloudServiceName, CloudServiceCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete a cloud service.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// The cloud service name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<CloudServiceOperationStatusResponse> DeleteAsync(string cloudServiceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retreive a cloud service.
        /// </summary>
        /// <param name='cloudServiceName'>
        /// The cloud service name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Information about a retrieved Cloud Service.
        /// </returns>
        Task<CloudServiceGetResponse> GetAsync(string cloudServiceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Cloud Services operation enumerates services that are
        /// provisioned for a subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the Cloud Service List operation.
        /// </returns>
        Task<CloudServiceListResponse> ListAsync(CancellationToken cancellationToken);
    }
}
