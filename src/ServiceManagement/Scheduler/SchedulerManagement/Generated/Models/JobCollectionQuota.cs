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
using Microsoft.WindowsAzure.Management.Scheduler.Models;

namespace Microsoft.WindowsAzure.Management.Scheduler.Models
{
    public partial class JobCollectionQuota
    {
        private int? _maxJobCount;
        
        /// <summary>
        /// Optional. Maximum number of jobs that can be created in this job
        /// collection. Maximum value is dependent on the plan.
        /// </summary>
        public int? MaxJobCount
        {
            get { return this._maxJobCount; }
            set { this._maxJobCount = value; }
        }
        
        private int? _maxJobOccurrence;
        
        /// <summary>
        /// Optional. Maximum number of occurrences for all jobs in the job
        /// collection.
        /// </summary>
        public int? MaxJobOccurrence
        {
            get { return this._maxJobOccurrence; }
            set { this._maxJobOccurrence = value; }
        }
        
        private JobCollectionMaxRecurrence _maxRecurrence;
        
        /// <summary>
        /// Optional. Defines the maximum recurrences that can be specified in
        /// any job in this job collection.
        /// </summary>
        public JobCollectionMaxRecurrence MaxRecurrence
        {
            get { return this._maxRecurrence; }
            set { this._maxRecurrence = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobCollectionQuota class.
        /// </summary>
        public JobCollectionQuota()
        {
        }
    }
}