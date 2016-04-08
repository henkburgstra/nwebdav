﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using NWebDav.Server.Http;

namespace NWebDav.Server.HttpListener
{
    public partial class HttpContext
    {
        private class HttpRequest : IHttpRequest
        {
            private readonly HttpListenerRequest _request;

            internal HttpRequest(HttpListenerRequest request)
            {
                _request = request;
            }

            public string HttpMethod => _request.HttpMethod;
            public Uri Url => _request.Url;
            public IPEndPoint RemoteEndPoint => _request.RemoteEndPoint;
            public IEnumerable<string> Headers => _request.Headers.AllKeys;
            public string GetHeaderValue(string header) => _request.Headers[header];
            public Stream Stream => _request.InputStream;
        }
    }
}