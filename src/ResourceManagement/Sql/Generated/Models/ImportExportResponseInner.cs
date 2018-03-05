// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response for Import/Export Get operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImportExportResponseInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ImportExportResponseInner class.
        /// </summary>
        public ImportExportResponseInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportExportResponseInner class.
        /// </summary>
        /// <param name="requestType">The request type of the
        /// operation.</param>
        /// <param name="requestId">The request type of the operation.</param>
        /// <param name="serverName">The name of the server.</param>
        /// <param name="databaseName">The name of the database.</param>
        /// <param name="status">The status message returned from the
        /// server.</param>
        /// <param name="lastModifiedTime">The operation status last modified
        /// time.</param>
        /// <param name="queuedTime">The operation queued time.</param>
        /// <param name="blobUri">The blob uri.</param>
        /// <param name="errorMessage">The error message returned from the
        /// server.</param>
        public ImportExportResponseInner(string id = default(string), string name = default(string), string type = default(string), string requestType = default(string), System.Guid? requestId = default(System.Guid?), string serverName = default(string), string databaseName = default(string), string status = default(string), string lastModifiedTime = default(string), string queuedTime = default(string), string blobUri = default(string), string errorMessage = default(string))
            : base(id, name, type)
        {
            RequestType = requestType;
            RequestId = requestId;
            ServerName = serverName;
            DatabaseName = databaseName;
            Status = status;
            LastModifiedTime = lastModifiedTime;
            QueuedTime = queuedTime;
            BlobUri = blobUri;
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the request type of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestType")]
        public string RequestType { get; private set; }

        /// <summary>
        /// Gets the request type of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestId")]
        public System.Guid? RequestId { get; private set; }

        /// <summary>
        /// Gets the name of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverName")]
        public string ServerName { get; private set; }

        /// <summary>
        /// Gets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; private set; }

        /// <summary>
        /// Gets the status message returned from the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the operation status last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public string LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the operation queued time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queuedTime")]
        public string QueuedTime { get; private set; }

        /// <summary>
        /// Gets the blob uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.blobUri")]
        public string BlobUri { get; private set; }

        /// <summary>
        /// Gets the error message returned from the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; private set; }

    }
}
