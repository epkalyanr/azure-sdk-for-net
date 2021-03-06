// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// The DevTest Labs Client.
    /// </summary>
    public partial interface IDevTestLabsClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Gets Azure subscription credentials.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Client API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the ILabOperations.
        /// </summary>
        ILabOperations Lab { get; }

        /// <summary>
        /// Gets the IArtifactSourceOperations.
        /// </summary>
        IArtifactSourceOperations ArtifactSource { get; }

        /// <summary>
        /// Gets the IArtifactOperations.
        /// </summary>
        IArtifactOperations Artifact { get; }

        /// <summary>
        /// Gets the ICostOperations.
        /// </summary>
        ICostOperations Cost { get; }

        /// <summary>
        /// Gets the ICustomImageOperations.
        /// </summary>
        ICustomImageOperations CustomImage { get; }

        /// <summary>
        /// Gets the IFormulaOperations.
        /// </summary>
        IFormulaOperations Formula { get; }

        /// <summary>
        /// Gets the IGalleryImageOperations.
        /// </summary>
        IGalleryImageOperations GalleryImage { get; }

        /// <summary>
        /// Gets the IPolicySetOperations.
        /// </summary>
        IPolicySetOperations PolicySet { get; }

        /// <summary>
        /// Gets the IPolicyOperations.
        /// </summary>
        IPolicyOperations Policy { get; }

        /// <summary>
        /// Gets the IScheduleOperations.
        /// </summary>
        IScheduleOperations Schedule { get; }

        /// <summary>
        /// Gets the IVirtualMachineOperations.
        /// </summary>
        IVirtualMachineOperations VirtualMachine { get; }

        /// <summary>
        /// Gets the IVirtualNetworkOperations.
        /// </summary>
        IVirtualNetworkOperations VirtualNetwork { get; }

    }
}
