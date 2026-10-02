
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"code":"auth_code_abc123def456","code_challenge_method":"S256","code_verifier":"dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk"}
    /// </summary>
    public sealed partial class ExchangeAuthCodeForAPIKeyRequest
    {
        /// <summary>
        /// The authorization code received from the OAuth redirect<br/>
        /// Example: auth_code_abc123def456
        /// </summary>
        /// <example>auth_code_abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The method used to generate the code challenge<br/>
        /// Example: S256
        /// </summary>
        /// <example>S256</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethodJsonConverter))]
        public global::OpenRouter.ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod? CodeChallengeMethod { get; set; }

        /// <summary>
        /// The code verifier if code_challenge was used in the authorization request<br/>
        /// Example: dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk
        /// </summary>
        /// <example>dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeAuthCodeForAPIKeyRequest" /> class.
        /// </summary>
        /// <param name="code">
        /// The authorization code received from the OAuth redirect<br/>
        /// Example: auth_code_abc123def456
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge<br/>
        /// Example: S256
        /// </param>
        /// <param name="codeVerifier">
        /// The code verifier if code_challenge was used in the authorization request<br/>
        /// Example: dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExchangeAuthCodeForAPIKeyRequest(
            string code,
            global::OpenRouter.ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod? codeChallengeMethod,
            string? codeVerifier)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CodeChallengeMethod = codeChallengeMethod;
            this.CodeVerifier = codeVerifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeAuthCodeForAPIKeyRequest" /> class.
        /// </summary>
        public ExchangeAuthCodeForAPIKeyRequest()
        {
        }

    }
}