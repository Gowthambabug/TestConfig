// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    internal partial class CommunityGalleryImageVersionsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of CommunityGalleryImageVersionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public CommunityGalleryImageVersionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-07-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string location, string publicGalleryName, string galleryImageName, string galleryImageVersionName)
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
            uri.AppendPath("/communityGalleries/", false);
            uri.AppendPath(publicGalleryName, true);
            uri.AppendPath("/images/", false);
            uri.AppendPath(galleryImageName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(galleryImageVersionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Get a community gallery image version. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="galleryImageVersionName"> The name of the community gallery image version. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="publicGalleryName"/>, <paramref name="galleryImageName"/>, or <paramref name="galleryImageVersionName"/> is null. </exception>
        public async Task<Response<CommunityGalleryImageVersion>> GetAsync(string subscriptionId, string location, string publicGalleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publicGalleryName == null)
            {
                throw new ArgumentNullException(nameof(publicGalleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateGetRequest(subscriptionId, location, publicGalleryName, galleryImageName, galleryImageVersionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersion value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunityGalleryImageVersion.DeserializeCommunityGalleryImageVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a community gallery image version. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="publicGalleryName"> The public name of the community gallery. </param>
        /// <param name="galleryImageName"> The name of the community gallery image definition. </param>
        /// <param name="galleryImageVersionName"> The name of the community gallery image version. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, <paramref name="publicGalleryName"/>, <paramref name="galleryImageName"/>, or <paramref name="galleryImageVersionName"/> is null. </exception>
        public Response<CommunityGalleryImageVersion> Get(string subscriptionId, string location, string publicGalleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publicGalleryName == null)
            {
                throw new ArgumentNullException(nameof(publicGalleryName));
            }
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImageVersionName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageVersionName));
            }

            using var message = CreateGetRequest(subscriptionId, location, publicGalleryName, galleryImageName, galleryImageVersionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunityGalleryImageVersion value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunityGalleryImageVersion.DeserializeCommunityGalleryImageVersion(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}