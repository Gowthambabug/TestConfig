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
    /// <summary> The PurviewLineages service client. </summary>
    public partial class PurviewLineages
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;
        internal ClientDiagnostics ClientDiagnostics { get; }
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewLineages for mocking. </summary>
        protected PurviewLineages()
        {
        }

        /// <summary> Get lineage info of the entity specified by GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. Allowed values: &quot;BOTH&quot; | &quot;INPUT&quot; | &quot;OUTPUT&quot;. </param>
        /// <param name="depth"> The number of hops for lineage. </param>
        /// <param name="width"> The number of max expanding width in lineage. </param>
        /// <param name="includeParent"> True to include the parent chain in the response. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> or <paramref name="direction"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   baseEntityGuid: string,
        ///   guidEntityMap: Dictionary&lt;string, AtlasEntityHeader&gt;,
        ///   widthCounts: Dictionary&lt;string, Dictionary&lt;string, AnyObject&gt;&gt;,
        ///   lineageDepth: number,
        ///   lineageWidth: number,
        ///   includeParent: boolean,
        ///   childrenCount: number,
        ///   lineageDirection: &quot;INPUT&quot; | &quot;OUTPUT&quot; | &quot;BOTH&quot;,
        ///   parentRelations: [
        ///     {
        ///       childEntityId: string,
        ///       relationshipId: string,
        ///       parentEntityId: string
        ///     }
        ///   ],
        ///   relations: [
        ///     {
        ///       fromEntityId: string,
        ///       relationshipId: string,
        ///       toEntityId: string
        ///     }
        ///   ]
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
        public virtual async Task<Response> GetLineageGraphAsync(string guid, string direction, int? depth = null, int? width = null, bool? includeParent = null, bool? getDerivedLineage = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(guid, nameof(guid));
            Argument.AssertNotNull(direction, nameof(direction));

            using var scope = ClientDiagnostics.CreateScope("PurviewLineages.GetLineageGraph");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetLineageGraphRequest(guid, direction, depth, width, includeParent, getDerivedLineage, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get lineage info of the entity specified by GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. Allowed values: &quot;BOTH&quot; | &quot;INPUT&quot; | &quot;OUTPUT&quot;. </param>
        /// <param name="depth"> The number of hops for lineage. </param>
        /// <param name="width"> The number of max expanding width in lineage. </param>
        /// <param name="includeParent"> True to include the parent chain in the response. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> or <paramref name="direction"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   baseEntityGuid: string,
        ///   guidEntityMap: Dictionary&lt;string, AtlasEntityHeader&gt;,
        ///   widthCounts: Dictionary&lt;string, Dictionary&lt;string, AnyObject&gt;&gt;,
        ///   lineageDepth: number,
        ///   lineageWidth: number,
        ///   includeParent: boolean,
        ///   childrenCount: number,
        ///   lineageDirection: &quot;INPUT&quot; | &quot;OUTPUT&quot; | &quot;BOTH&quot;,
        ///   parentRelations: [
        ///     {
        ///       childEntityId: string,
        ///       relationshipId: string,
        ///       parentEntityId: string
        ///     }
        ///   ],
        ///   relations: [
        ///     {
        ///       fromEntityId: string,
        ///       relationshipId: string,
        ///       toEntityId: string
        ///     }
        ///   ]
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
        public virtual Response GetLineageGraph(string guid, string direction, int? depth = null, int? width = null, bool? includeParent = null, bool? getDerivedLineage = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(guid, nameof(guid));
            Argument.AssertNotNull(direction, nameof(direction));

            using var scope = ClientDiagnostics.CreateScope("PurviewLineages.GetLineageGraph");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetLineageGraphRequest(guid, direction, depth, width, includeParent, getDerivedLineage, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return immediate next page lineage info about entity with pagination. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. Allowed values: &quot;BOTH&quot; | &quot;INPUT&quot; | &quot;OUTPUT&quot;. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="offset"> The offset for pagination purpose. </param>
        /// <param name="limit"> The page size - by default there is no paging. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> or <paramref name="direction"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   baseEntityGuid: string,
        ///   guidEntityMap: Dictionary&lt;string, AtlasEntityHeader&gt;,
        ///   widthCounts: Dictionary&lt;string, Dictionary&lt;string, AnyObject&gt;&gt;,
        ///   lineageDepth: number,
        ///   lineageWidth: number,
        ///   includeParent: boolean,
        ///   childrenCount: number,
        ///   lineageDirection: &quot;INPUT&quot; | &quot;OUTPUT&quot; | &quot;BOTH&quot;,
        ///   parentRelations: [
        ///     {
        ///       childEntityId: string,
        ///       relationshipId: string,
        ///       parentEntityId: string
        ///     }
        ///   ],
        ///   relations: [
        ///     {
        ///       fromEntityId: string,
        ///       relationshipId: string,
        ///       toEntityId: string
        ///     }
        ///   ]
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
        public virtual async Task<Response> NextPageLineageAsync(string guid, string direction, bool? getDerivedLineage = null, int? offset = null, int? limit = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(guid, nameof(guid));
            Argument.AssertNotNull(direction, nameof(direction));

            using var scope = ClientDiagnostics.CreateScope("PurviewLineages.NextPageLineage");
            scope.Start();
            try
            {
                using HttpMessage message = CreateNextPageLineageRequest(guid, direction, getDerivedLineage, offset, limit, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Return immediate next page lineage info about entity with pagination. </summary>
        /// <param name="guid"> The globally unique identifier of the entity. </param>
        /// <param name="direction"> The direction of the lineage, which could be INPUT, OUTPUT or BOTH. Allowed values: &quot;BOTH&quot; | &quot;INPUT&quot; | &quot;OUTPUT&quot;. </param>
        /// <param name="getDerivedLineage"> True to include derived lineage in the response. </param>
        /// <param name="offset"> The offset for pagination purpose. </param>
        /// <param name="limit"> The page size - by default there is no paging. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> or <paramref name="direction"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   baseEntityGuid: string,
        ///   guidEntityMap: Dictionary&lt;string, AtlasEntityHeader&gt;,
        ///   widthCounts: Dictionary&lt;string, Dictionary&lt;string, AnyObject&gt;&gt;,
        ///   lineageDepth: number,
        ///   lineageWidth: number,
        ///   includeParent: boolean,
        ///   childrenCount: number,
        ///   lineageDirection: &quot;INPUT&quot; | &quot;OUTPUT&quot; | &quot;BOTH&quot;,
        ///   parentRelations: [
        ///     {
        ///       childEntityId: string,
        ///       relationshipId: string,
        ///       parentEntityId: string
        ///     }
        ///   ],
        ///   relations: [
        ///     {
        ///       fromEntityId: string,
        ///       relationshipId: string,
        ///       toEntityId: string
        ///     }
        ///   ]
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
        public virtual Response NextPageLineage(string guid, string direction, bool? getDerivedLineage = null, int? offset = null, int? limit = null, RequestContext context = null)
#pragma warning restore AZC0002
        {
            Argument.AssertNotNull(guid, nameof(guid));
            Argument.AssertNotNull(direction, nameof(direction));

            using var scope = ClientDiagnostics.CreateScope("PurviewLineages.NextPageLineage");
            scope.Start();
            try
            {
                using HttpMessage message = CreateNextPageLineageRequest(guid, direction, getDerivedLineage, offset, limit, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetLineageGraphRequest(string guid, string direction, int? depth, int? width, bool? includeParent, bool? getDerivedLineage, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/atlas/v2/lineage/", false);
            uri.AppendPath(guid, true);
            uri.AppendQuery("direction", direction, true);
            if (depth != null)
            {
                uri.AppendQuery("depth", depth.Value, true);
            }
            if (width != null)
            {
                uri.AppendQuery("width", width.Value, true);
            }
            if (includeParent != null)
            {
                uri.AppendQuery("includeParent", includeParent.Value, true);
            }
            if (getDerivedLineage != null)
            {
                uri.AppendQuery("getDerivedLineage", getDerivedLineage.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateNextPageLineageRequest(string guid, string direction, bool? getDerivedLineage, int? offset, int? limit, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/lineage/", false);
            uri.AppendPath(guid, true);
            uri.AppendPath("/next/", false);
            uri.AppendQuery("direction", direction, true);
            if (getDerivedLineage != null)
            {
                uri.AppendQuery("getDerivedLineage", getDerivedLineage.Value, true);
            }
            if (offset != null)
            {
                uri.AppendQuery("offset", offset.Value, true);
            }
            if (limit != null)
            {
                uri.AppendQuery("limit", limit.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
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