// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Output for the task that migrates on-prem SQL Server databases to Azure
    /// SQL Database for online migrations
    /// </summary>
    public partial class MigrateSqlServerSqlDbSyncTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerSqlDbSyncTaskOutput class.
        /// </summary>
        public MigrateSqlServerSqlDbSyncTaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrateSqlServerSqlDbSyncTaskOutput class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        public MigrateSqlServerSqlDbSyncTaskOutput(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}