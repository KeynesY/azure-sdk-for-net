// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Policy.
    /// </summary>
    [JsonTransformation]
    public partial class Policy : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Policy class.
        /// </summary>
        public Policy() { }

        /// <summary>
        /// Initializes a new instance of the Policy class.
        /// </summary>
        public Policy(string description = default(string), string status = default(string), string factName = default(string), string factData = default(string), string threshold = default(string), string evaluatorType = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string), string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Description = description;
            Status = status;
            FactName = factName;
            FactData = factData;
            Threshold = threshold;
            EvaluatorType = evaluatorType;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
        }

        /// <summary>
        /// The description of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// The status of the policy. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// The fact name of the policy. Possible values include:
        /// 'UserOwnedLabVmCount', 'LabVmCount', 'LabVmSize', 'GalleryImage',
        /// 'UserOwnedLabVmCountInSubnet'
        /// </summary>
        [JsonProperty(PropertyName = "properties.factName")]
        public string FactName { get; set; }

        /// <summary>
        /// The fact data of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.factData")]
        public string FactData { get; set; }

        /// <summary>
        /// The threshold of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.threshold")]
        public string Threshold { get; set; }

        /// <summary>
        /// The evaluator type of the policy. Possible values include:
        /// 'AllowedValuesPolicy', 'MaxValuePolicy'
        /// </summary>
        [JsonProperty(PropertyName = "properties.evaluatorType")]
        public string EvaluatorType { get; set; }

        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// The unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// The identifier of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// The tags of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
