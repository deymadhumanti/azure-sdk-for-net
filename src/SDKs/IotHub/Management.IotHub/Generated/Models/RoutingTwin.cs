// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Twin reference input parameter. This is an optional parameter
    /// </summary>
    public partial class RoutingTwin
    {
        /// <summary>
        /// Initializes a new instance of the RoutingTwin class.
        /// </summary>
        public RoutingTwin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoutingTwin class.
        /// </summary>
        /// <param name="tags">Twin Tags</param>
        public RoutingTwin(object tags = default(object), RoutingTwinProperties properties = default(RoutingTwinProperties))
        {
            Tags = tags;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets twin Tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public object Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RoutingTwinProperties Properties { get; set; }

    }
}