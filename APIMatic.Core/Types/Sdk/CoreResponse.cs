﻿// <copyright file="CoreResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities;
using System.Collections.Generic;
using System.IO;

namespace APIMatic.Core.Types.Sdk
{
    /// <summary>
    /// CoreResponse.
    /// </summary>
    public class CoreResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpResponse"/> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="headers">headers.</param>
        /// <param name="rawBody">rawBody.</param>
        /// <param name="body">body.</param>
        public CoreResponse(int statusCode, Dictionary<string, string> headers, Stream rawBody, string body = null)
            => (StatusCode, Headers, RawBody, Body) = (statusCode, headers, rawBody, body);

        /// <summary>
        /// Gets the HTTP Status code of the http response.
        /// </summary>
        public int StatusCode { get; }

        /// <summary>
        /// Gets the headers of the http response.
        /// </summary>
        public Dictionary<string, string> Headers { get; }

        /// <summary>
        /// Gets the stream of the body.
        /// </summary>
        public Stream RawBody { get; }

        /// <summary>
        /// Gets the raw string body of the http response.
        /// </summary>
        public string Body { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $" StatusCode = {StatusCode}, " +
                $" Headers = {CoreHelper.JsonSerialize(Headers)}" +
                $" RawBody = {RawBody}";
        }
    }
}