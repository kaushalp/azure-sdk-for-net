// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Task counts for a Job.
    /// </summary>
    public partial class TaskCounts
    {
        /// <summary>
        /// Initializes a new instance of the TaskCounts class.
        /// </summary>
        public TaskCounts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskCounts class.
        /// </summary>
        /// <param name="active">The number of Tasks in the active
        /// state.</param>
        /// <param name="running">The number of Tasks in the running or
        /// preparing state.</param>
        /// <param name="completed">The number of Tasks in the completed
        /// state.</param>
        /// <param name="succeeded">The number of Tasks which succeeded. A Task
        /// succeeds if its result (found in the executionInfo property) is
        /// 'success'.</param>
        /// <param name="failed">The number of Tasks which failed. A Task fails
        /// if its result (found in the executionInfo property) is
        /// 'failure'.</param>
        public TaskCounts(int active, int running, int completed, int succeeded, int failed)
        {
            Active = active;
            Running = running;
            Completed = completed;
            Succeeded = succeeded;
            Failed = failed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of Tasks in the active state.
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public int Active { get; set; }

        /// <summary>
        /// Gets or sets the number of Tasks in the running or preparing state.
        /// </summary>
        [JsonProperty(PropertyName = "running")]
        public int Running { get; set; }

        /// <summary>
        /// Gets or sets the number of Tasks in the completed state.
        /// </summary>
        [JsonProperty(PropertyName = "completed")]
        public int Completed { get; set; }

        /// <summary>
        /// Gets or sets the number of Tasks which succeeded. A Task succeeds
        /// if its result (found in the executionInfo property) is 'success'.
        /// </summary>
        [JsonProperty(PropertyName = "succeeded")]
        public int Succeeded { get; set; }

        /// <summary>
        /// Gets or sets the number of Tasks which failed. A Task fails if its
        /// result (found in the executionInfo property) is 'failure'.
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        public int Failed { get; set; }

    }
}
