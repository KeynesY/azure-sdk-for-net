// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EventHubConnectionValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EventHubConnectionValidationResult class.
        /// </summary>
        public EventHubConnectionValidationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EventHubConnectionValidationResult class.
        /// </summary>
        /// <param name="errorMessage">A message which indicates a problem in
        /// event hub connection validation.</param>
        public EventHubConnectionValidationResult(string errorMessage = default(string))
        {
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a message which indicates a problem in event hub
        /// connection validation.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

    }
}