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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a Task object.
    /// </summary>
    public partial class AsrTask : ServiceResourceBase
    {
        private IList<string> _actions;
        
        /// <summary>
        /// Required. Actions applicable on this task.
        /// </summary>
        public IList<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }
        
        private DateTime _endTime;
        
        /// <summary>
        /// Required. End time of the task.
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _extendedDetails;
        
        /// <summary>
        /// Required. Extended details of the task.
        /// </summary>
        public string ExtendedDetails
        {
            get { return this._extendedDetails; }
            set { this._extendedDetails = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Required. Start time of the task.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Required. State of the task.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _stateDescription;
        
        /// <summary>
        /// Required. StateDescription of the task.
        /// </summary>
        public string StateDescription
        {
            get { return this._stateDescription; }
            set { this._stateDescription = value; }
        }
        
        private string _taskName;
        
        /// <summary>
        /// Required. Name of the task.
        /// </summary>
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }
        
        private string _taskType;
        
        /// <summary>
        /// Required. Exact type of the task. Accordingly ExtentedDetails will
        /// have data.
        /// </summary>
        public string TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AsrTask class.
        /// </summary>
        public AsrTask()
        {
            this.Actions = new List<string>();
        }
    }
}