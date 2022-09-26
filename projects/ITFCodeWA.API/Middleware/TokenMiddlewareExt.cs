namespace ITFCodeWA.API.Middleware
{
    public static class TokenMiddlewareExt
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
        {
            return builder.UseMiddleware<TokenMiddleware>(pattern);
        }
    }
}
