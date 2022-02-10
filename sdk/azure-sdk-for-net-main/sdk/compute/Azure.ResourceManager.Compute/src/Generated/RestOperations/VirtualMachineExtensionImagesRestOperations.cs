// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    internal partial class VirtualMachineExtensionImagesRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of VirtualMachineExtensionImagesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public VirtualMachineExtensionImagesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-07-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string location, string publisherName, string type, string version)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmextension/types/", false);
            uri.AppendPath(type, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets a virtual machine extension image. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public async Task<Response<VirtualMachineExtensionImageData>> GetAsync(string subscriptionId, string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(subscriptionId, location, publisherName, type, version);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineExtensionImageData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualMachineExtensionImageData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a virtual machine extension image. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public Response<VirtualMachineExtensionImageData> Get(string subscriptionId, string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var message = CreateGetRequest(subscriptionId, location, publisherName, type, version);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineExtensionImageData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualMachineExtensionImageData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListTypesRequest(string subscriptionId, string location, string publisherName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmextension/types", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets a list of virtual machine extension image types. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, or <paramref name="publisherName"/> is null. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineExtensionImageData>>> ListTypesAsync(string subscriptionId, string location, string publisherName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }

            using var message = CreateListTypesRequest(subscriptionId, location, publisherName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineExtensionImageData> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineExtensionImageData> array = new List<VirtualMachineExtensionImageData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of virtual machine extension image types. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, or <paramref name="publisherName"/> is null. </exception>
        public Response<IReadOnlyList<VirtualMachineExtensionImageData>> ListTypes(string subscriptionId, string location, string publisherName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }

            using var message = CreateListTypesRequest(subscriptionId, location, publisherName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineExtensionImageData> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineExtensionImageData> array = new List<VirtualMachineExtensionImageData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListVersionsRequest(string subscriptionId, string location, string publisherName, string type, string filter, int? top, string orderby)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmextension/types/", false);
            uri.AppendPath(type, true);
            uri.AppendPath("/versions", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets a list of virtual machine extension image versions. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="publisherName"/>, or <paramref name="type"/> is null. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineExtensionImageData>>> ListVersionsAsync(string subscriptionId, string location, string publisherName, string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            using var message = CreateListVersionsRequest(subscriptionId, location, publisherName, type, filter, top, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineExtensionImageData> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineExtensionImageData> array = new List<VirtualMachineExtensionImageData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets a list of virtual machine extension image versions. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="publisherName"/>, or <paramref name="type"/> is null. </exception>
        public Response<IReadOnlyList<VirtualMachineExtensionImageData>> ListVersions(string subscriptionId, string location, string publisherName, string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            using var message = CreateListVersionsRequest(subscriptionId, location, publisherName, type, filter, top, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineExtensionImageData> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineExtensionImageData> array = new List<VirtualMachineExtensionImageData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineExtensionImageData.DeserializeVirtualMachineExtensionImageData(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}