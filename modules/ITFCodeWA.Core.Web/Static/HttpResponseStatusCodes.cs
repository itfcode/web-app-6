using System.Net;

namespace ITFCodeWA.Core.Web.Static
{
    /// <summary>
    /// 
    /// </summary>
    public static class HttpResponseStatusCodes
    {
        #region Private Fields

        private static readonly IReadOnlyDictionary<HttpStatusCode, string> _all;

        private static readonly IReadOnlyDictionary<HttpStatusCode, string> _informational;
        private static readonly IReadOnlyDictionary<HttpStatusCode, string> _successful;
        private static readonly IReadOnlyDictionary<HttpStatusCode, string> _redirection;
        private static readonly IReadOnlyDictionary<HttpStatusCode, string> _clientError;
        private static readonly IReadOnlyDictionary<HttpStatusCode, string> _serverError;

        #endregion

        #region Public Properties 

        public static IReadOnlyDictionary<HttpStatusCode, string> All => _all;

        public static IReadOnlyDictionary<HttpStatusCode, string> Informational => _informational;
        public static IReadOnlyDictionary<HttpStatusCode, string> Successful => _successful;
        public static IReadOnlyDictionary<HttpStatusCode, string> Redirection => _redirection;
        public static IReadOnlyDictionary<HttpStatusCode, string> ClientError => _clientError;
        public static IReadOnlyDictionary<HttpStatusCode, string> ServerError => _serverError;

        #endregion

        #region Constructors 

        static HttpResponseStatusCodes()
        {
            _informational = new Dictionary<HttpStatusCode, string>()
            {
                { HttpStatusCode.Continue, "Continue"}, // 100
                { HttpStatusCode.SwitchingProtocols, "Switching Protocols"}, // 101
                { HttpStatusCode.Processing, "Processing"}, // 102 
                { HttpStatusCode.EarlyHints, "Early Hints"}, // 103
            };

            _successful = new Dictionary<HttpStatusCode, string>()
            {
                { HttpStatusCode.OK, "OK"}, // 200 
                { HttpStatusCode.Created, "Created"}, // 201
                { HttpStatusCode.Accepted, "Accepted"}, // 202
                { HttpStatusCode.NonAuthoritativeInformation, "Non-Authoritative Information"}, // 203
                { HttpStatusCode.NoContent, "No Content"}, //204
                { HttpStatusCode.ResetContent, "Reset Content"}, // 205
                { HttpStatusCode.PartialContent, "Partial Content"}, // 206
                { HttpStatusCode.MultiStatus, "Multi Status"}, // 207
                { HttpStatusCode.AlreadyReported, "Already Reported"}, // 208
                { HttpStatusCode.IMUsed, "IM Used"}, // 226
            };

            _redirection = new Dictionary<HttpStatusCode, string>()
            {
                { HttpStatusCode.Ambiguous, "Ambiguous"}, // 300,
                { HttpStatusCode.MultipleChoices, "Multiple Choices"}, // 300,
                { HttpStatusCode.Moved, "Moved"}, // 301,
                { HttpStatusCode.MovedPermanently, "Moved Permanently"}, // 301,
                { HttpStatusCode.Found, "Found"}, // 302,
                { HttpStatusCode.Redirect, ""}, // 302,
                { HttpStatusCode.RedirectMethod, ""}, // 303,
                { HttpStatusCode.SeeOther, "See Other"}, // 303,
                { HttpStatusCode.NotModified, "Not Modified"}, // 304,
                { HttpStatusCode.UseProxy, "Use Proxy"}, // 305,
                { HttpStatusCode.Unused, "Unused"}, // 306,
                { HttpStatusCode.RedirectKeepVerb, "Redirect Keep Verb"}, // 307,
                { HttpStatusCode.TemporaryRedirect, "Temporary Redirect"}, // 307,
                { HttpStatusCode.PermanentRedirect, "Permanent Redirect"}, // 308,
            };

            _clientError = new Dictionary<HttpStatusCode, string>()
            {
                { HttpStatusCode.BadRequest, "Bad Request"}, // 400,
                { HttpStatusCode.Unauthorized, "Unauthorized"}, // 401,
                { HttpStatusCode.PaymentRequired, "Payment Required"}, // 402,
                { HttpStatusCode.Forbidden, "Forbidden"}, // 403,
                { HttpStatusCode.NotFound, "Not Found"}, // 404,
                { HttpStatusCode.MethodNotAllowed, "Method Not Allowed"}, // 405,
                { HttpStatusCode.NotAcceptable, "Not Acceptable"}, // 406,
                { HttpStatusCode.ProxyAuthenticationRequired, "Proxy Authentication Required"}, // 407,
                { HttpStatusCode.RequestTimeout, "Request Timeout"}, // 408,
                { HttpStatusCode.Conflict, "Conflict"}, // 409,
                { HttpStatusCode.Gone, "Gone"}, // 410,
                { HttpStatusCode.LengthRequired, "Length Required"}, // 411,
                { HttpStatusCode.PreconditionFailed, "Precondition Failed"}, // 412,
                { HttpStatusCode.RequestEntityTooLarge, "Request Payload Too Large"}, // 413,
                { HttpStatusCode.RequestUriTooLong, "Request URI Too Long"}, // 414,
                { HttpStatusCode.UnsupportedMediaType, "Unsupported Media Type"}, // 415,
                { HttpStatusCode.RequestedRangeNotSatisfiable, "Requested Range Not Satisfiable"}, // 416,
                { HttpStatusCode.ExpectationFailed, "Expectation Failed"}, // 417,
                { HttpStatusCode.MisdirectedRequest, "Misdirected Request"}, // 421,
                { HttpStatusCode.UnprocessableEntity, "Unprocessable Entity"}, // 422,
                    //418 I'm a teapot
                    //425 Too Early
                { HttpStatusCode.Locked, "Locked"}, // 423,
                { HttpStatusCode.FailedDependency, "Failed Dependency"}, // 424,
                { HttpStatusCode.UpgradeRequired, "Upgrade Required"}, // 426,
                { HttpStatusCode.PreconditionRequired, "Precondition Required"}, // 428,
                { HttpStatusCode.TooManyRequests, "Too Many Requests"}, // 429,
                { HttpStatusCode.RequestHeaderFieldsTooLarge, "Request Header Fields Too Large"}, // 431,
                { HttpStatusCode.UnavailableForLegalReasons, "Unavailable For Legal Reasons"}, // 451,
            };

            _serverError = new Dictionary<HttpStatusCode, string>()
            {
                { HttpStatusCode.InternalServerError, "Internal Server Error"}, // 500,
                { HttpStatusCode.NotImplemented, "Not Implemented"}, // 501,
                { HttpStatusCode.BadGateway, "Bad Gateway"}, // 502,
                { HttpStatusCode.ServiceUnavailable, "Service Unavailable"}, // 503,
                { HttpStatusCode.GatewayTimeout, "Gateway Timeout"}, // 504,
                { HttpStatusCode.HttpVersionNotSupported, "HTTP Version Not Supported"}, // 505,
                { HttpStatusCode.VariantAlsoNegotiates, "Variant Also Negotiates"}, // 506,
                { HttpStatusCode.InsufficientStorage, "Insufficient Storage"}, // 507,
                { HttpStatusCode.LoopDetected, "Loop Detected"}, // 508,
                { HttpStatusCode.NotExtended, "Not Extended"}, // 510,
                { HttpStatusCode.NetworkAuthenticationRequired, "Network Authentication Required"}, // 511
            };

            _all = _informational
                .Concat(_successful)
                .Concat(_redirection)
                .Concat(_clientError)
                .Concat(_serverError)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        #endregion
    }
}
