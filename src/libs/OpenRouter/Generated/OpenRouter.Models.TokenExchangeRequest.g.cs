
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// RFC 8693 token exchange request body (application/x-www-form-urlencoded).<br/>
    /// Example: {"federation_policy_id":"4b2f7d1e-8c3a-4e5f-9a6b-1c2d3e4f5a6b","grant_type":"urn:ietf:params:oauth:grant-type:token-exchange","subject_token":"\u003Cjwt from your identity provider\u003E","subject_token_type":"urn:ietf:params:oauth:token-type:jwt"}
    /// </summary>
    public sealed partial class TokenExchangeRequest
    {
        /// <summary>
        /// The federation policy to evaluate, from Settings → Workload identity. Binds the exchange to one organization.<br/>
        /// Example: 4b2f7d1e-8c3a-4e5f-9a6b-1c2d3e4f5a6b
        /// </summary>
        /// <example>4b2f7d1e-8c3a-4e5f-9a6b-1c2d3e4f5a6b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("federation_policy_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FederationPolicyId { get; set; }

        /// <summary>
        /// Must be `urn:ietf:params:oauth:grant-type:token-exchange`.<br/>
        /// Example: urn:ietf:params:oauth:grant-type:token-exchange
        /// </summary>
        /// <example>urn:ietf:params:oauth:grant-type:token-exchange</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TokenExchangeRequestGrantTypeJsonConverter))]
        public global::OpenRouter.TokenExchangeRequestGrantType GrantType { get; set; }

        /// <summary>
        /// Optional; when present must be `urn:ietf:params:oauth:token-type:access_token`.<br/>
        /// Example: urn:ietf:params:oauth:token-type:access_token
        /// </summary>
        /// <example>urn:ietf:params:oauth:token-type:access_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TokenExchangeRequestRequestedTokenTypeJsonConverter))]
        public global::OpenRouter.TokenExchangeRequestRequestedTokenType? RequestedTokenType { get; set; }

        /// <summary>
        /// Optional; only `inference` is available.<br/>
        /// Example: inference
        /// </summary>
        /// <example>inference</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TokenExchangeRequestScopeJsonConverter))]
        public global::OpenRouter.TokenExchangeRequestScope? Scope { get; set; }

        /// <summary>
        /// The JWT issued by your identity provider.<br/>
        /// Example: &lt;jwt from your identity provider&gt;
        /// </summary>
        /// <example>&lt;jwt from your identity provider&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectToken { get; set; }

        /// <summary>
        /// Must be `urn:ietf:params:oauth:token-type:jwt`.<br/>
        /// Example: urn:ietf:params:oauth:token-type:jwt
        /// </summary>
        /// <example>urn:ietf:params:oauth:token-type:jwt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TokenExchangeRequestSubjectTokenTypeJsonConverter))]
        public global::OpenRouter.TokenExchangeRequestSubjectTokenType SubjectTokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeRequest" /> class.
        /// </summary>
        /// <param name="federationPolicyId">
        /// The federation policy to evaluate, from Settings → Workload identity. Binds the exchange to one organization.<br/>
        /// Example: 4b2f7d1e-8c3a-4e5f-9a6b-1c2d3e4f5a6b
        /// </param>
        /// <param name="subjectToken">
        /// The JWT issued by your identity provider.<br/>
        /// Example: &lt;jwt from your identity provider&gt;
        /// </param>
        /// <param name="grantType">
        /// Must be `urn:ietf:params:oauth:grant-type:token-exchange`.<br/>
        /// Example: urn:ietf:params:oauth:grant-type:token-exchange
        /// </param>
        /// <param name="requestedTokenType">
        /// Optional; when present must be `urn:ietf:params:oauth:token-type:access_token`.<br/>
        /// Example: urn:ietf:params:oauth:token-type:access_token
        /// </param>
        /// <param name="scope">
        /// Optional; only `inference` is available.<br/>
        /// Example: inference
        /// </param>
        /// <param name="subjectTokenType">
        /// Must be `urn:ietf:params:oauth:token-type:jwt`.<br/>
        /// Example: urn:ietf:params:oauth:token-type:jwt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenExchangeRequest(
            global::System.Guid federationPolicyId,
            string subjectToken,
            global::OpenRouter.TokenExchangeRequestGrantType grantType,
            global::OpenRouter.TokenExchangeRequestRequestedTokenType? requestedTokenType,
            global::OpenRouter.TokenExchangeRequestScope? scope,
            global::OpenRouter.TokenExchangeRequestSubjectTokenType subjectTokenType)
        {
            this.FederationPolicyId = federationPolicyId;
            this.GrantType = grantType;
            this.RequestedTokenType = requestedTokenType;
            this.Scope = scope;
            this.SubjectToken = subjectToken ?? throw new global::System.ArgumentNullException(nameof(subjectToken));
            this.SubjectTokenType = subjectTokenType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeRequest" /> class.
        /// </summary>
        public TokenExchangeRequest()
        {
        }

    }
}