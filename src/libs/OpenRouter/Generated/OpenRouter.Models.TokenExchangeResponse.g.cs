
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// RFC 8693 token exchange response.<br/>
    /// Example: {"access_token":"\u003Cshort-lived openrouter access token jwt\u003E","expires_in":900,"issued_token_type":"urn:ietf:params:oauth:token-type:access_token","scope":"inference","token_type":"Bearer"}
    /// </summary>
    public sealed partial class TokenExchangeResponse
    {
        /// <summary>
        /// A short-lived JWT to send as `Authorization: Bearer` to the inference API.<br/>
        /// Example: &lt;short-lived openrouter access token jwt&gt;
        /// </summary>
        /// <example>&lt;short-lived openrouter access token jwt&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Seconds until the access token expires: at most 15 minutes, and never later than the subject token expires.<br/>
        /// Example: 900
        /// </summary>
        /// <example>900</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// Example: urn:ietf:params:oauth:token-type:access_token
        /// </summary>
        /// <example>urn:ietf:params:oauth:token-type:access_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issued_token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TokenExchangeResponseIssuedTokenTypeJsonConverter))]
        public global::OpenRouter.TokenExchangeResponseIssuedTokenType IssuedTokenType { get; set; }

        /// <summary>
        /// Example: inference
        /// </summary>
        /// <example>inference</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        /// Example: Bearer
        /// </summary>
        /// <example>Bearer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TokenExchangeResponseTokenTypeJsonConverter))]
        public global::OpenRouter.TokenExchangeResponseTokenType TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeResponse" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// A short-lived JWT to send as `Authorization: Bearer` to the inference API.<br/>
        /// Example: &lt;short-lived openrouter access token jwt&gt;
        /// </param>
        /// <param name="expiresIn">
        /// Seconds until the access token expires: at most 15 minutes, and never later than the subject token expires.<br/>
        /// Example: 900
        /// </param>
        /// <param name="scope">
        /// Example: inference
        /// </param>
        /// <param name="issuedTokenType">
        /// Example: urn:ietf:params:oauth:token-type:access_token
        /// </param>
        /// <param name="tokenType">
        /// Example: Bearer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenExchangeResponse(
            string accessToken,
            int expiresIn,
            string scope,
            global::OpenRouter.TokenExchangeResponseIssuedTokenType issuedTokenType,
            global::OpenRouter.TokenExchangeResponseTokenType tokenType)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresIn = expiresIn;
            this.IssuedTokenType = issuedTokenType;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeResponse" /> class.
        /// </summary>
        public TokenExchangeResponse()
        {
        }

    }
}