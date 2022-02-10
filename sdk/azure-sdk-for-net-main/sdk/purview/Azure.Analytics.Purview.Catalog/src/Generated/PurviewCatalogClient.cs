// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Catalog
{
    /// <summary> The PurviewCatalog service client. </summary>
    public partial class PurviewCatalogClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;
        internal ClientDiagnostics ClientDiagnostics { get; }
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewCatalogClient for mocking. </summary>
        protected PurviewCatalogClient()
        {
        }

        /// <summary> Initializes a new instance of PurviewCatalogClient. </summary>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public PurviewCatalogClient(Uri endpoint, TokenCredential credential, PurviewCatalogClientOptions options = null)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new PurviewCatalogClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Gets data using search. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   offset: number,
        ///   limit: number,
        ///   filter: AnyObject,
        ///   facets: [
        ///     {
        ///       count: number,
        ///       facet: string,
        ///       sort: AnyObject
        ///     }
        ///   ],
        ///   taxonomySetting: {
        ///     assetTypes: [string],
        ///     facet: SearchFacetItem
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   @search.facets: {
        ///     assetType: [
        ///       {
        ///         count: number,
        ///         value: string
        ///       }
        ///     ],
        ///     classification: [SearchFacetItemValue],
        ///     classificationCategory: [SearchFacetItemValue],
        ///     contactId: [SearchFacetItemValue],
        ///     fileExtension: [SearchFacetItemValue],
        ///     label: [SearchFacetItemValue],
        ///     term: [SearchFacetItemValue]
        ///   },
        ///   value: [SearchResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> SearchAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSearchRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets data using search. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   offset: number,
        ///   limit: number,
        ///   filter: AnyObject,
        ///   facets: [
        ///     {
        ///       count: number,
        ///       facet: string,
        ///       sort: AnyObject
        ///     }
        ///   ],
        ///   taxonomySetting: {
        ///     assetTypes: [string],
        ///     facet: SearchFacetItem
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   @search.facets: {
        ///     assetType: [
        ///       {
        ///         count: number,
        ///         value: string
        ///       }
        ///     ],
        ///     classification: [SearchFacetItemValue],
        ///     classificationCategory: [SearchFacetItemValue],
        ///     contactId: [SearchFacetItemValue],
        ///     fileExtension: [SearchFacetItemValue],
        ///     label: [SearchFacetItemValue],
        ///     term: [SearchFacetItemValue]
        ///   },
        ///   value: [SearchResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Search(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Search");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSearchRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [SuggestResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> SuggestAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSuggestRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get search suggestions by query criteria. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [SuggestResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Suggest(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Suggest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSuggestRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Browse entities by path or entity type. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   entityType: string,
        ///   path: string,
        ///   limit: number,
        ///   offset: number
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   value: [BrowseResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> BrowseAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Browse");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBrowseRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Browse entities by path or entity type. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   entityType: string,
        ///   path: string,
        ///   limit: number,
        ///   offset: number
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   @search.count: number,
        ///   value: [BrowseResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Browse(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.Browse");
            scope.Start();
            try
            {
                using HttpMessage message = CreateBrowseRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get auto complete options. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [AutoCompleteResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> AutoCompleteAsync(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAutoCompleteRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get auto complete options. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   keywords: string,
        ///   limit: number,
        ///   filter: AnyObject
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [AutoCompleteResultValue]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response AutoComplete(RequestContent content, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCatalogClient.AutoComplete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAutoCompleteRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateSearchRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/query", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateSuggestRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/suggest", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateBrowseRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/browse", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateAutoCompleteRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/search/autocomplete", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}