
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"callback_url":"https://myapp.com/auth/callback","code_challenge":"E9Melhoa2OwvFrEMTJguCHaoeK1t8URWbuGJSstw-cM","code_challenge_method":"S256","limit":100}
    /// </summary>
    public sealed partial class CreateAuthKeysCodeRequest
    {
        /// <summary>
        /// The callback URL to redirect to after authorization. Supports https URLs and localhost/127.0.0.1 URLs on any port for local CLI tools.<br/>
        /// Example: https://myapp.com/auth/callback
        /// </summary>
        /// <example>https://myapp.com/auth/callback</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallbackUrl { get; set; }

        /// <summary>
        /// PKCE code challenge for enhanced security<br/>
        /// Example: E9Melhoa2OwvFrEMTJguCHaoeK1t8URWbuGJSstw-cM
        /// </summary>
        /// <example>E9Melhoa2OwvFrEMTJguCHaoeK1t8URWbuGJSstw-cM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge")]
        public string? CodeChallenge { get; set; }

        /// <summary>
        /// The method used to generate the code challenge<br/>
        /// Example: S256
        /// </summary>
        /// <example>S256</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateAuthKeysCodeRequestCodeChallengeMethodJsonConverter))]
        public global::OpenRouter.CreateAuthKeysCodeRequestCodeChallengeMethod? CodeChallengeMethod { get; set; }

        /// <summary>
        /// Optional ISO 8601 UTC expiration timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </summary>
        /// <example>2027-12-31T23:59:59Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Optional custom label for the API key. Defaults to the app name if not provided.<br/>
        /// Example: My Custom Key
        /// </summary>
        /// <example>My Custom Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_label")]
        public string? KeyLabel { get; set; }

        /// <summary>
        /// Credit limit for the API key to be created<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Agent identifier for spawn telemetry<br/>
        /// Example: my-agent
        /// </summary>
        /// <example>my-agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spawn_agent")]
        public string? SpawnAgent { get; set; }

        /// <summary>
        /// Cloud identifier for spawn telemetry<br/>
        /// Example: aws-us-east-1
        /// </summary>
        /// <example>aws-us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spawn_cloud")]
        public string? SpawnCloud { get; set; }

        /// <summary>
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateAuthKeysCodeRequestUsageLimitTypeJsonConverter))]
        public global::OpenRouter.CreateAuthKeysCodeRequestUsageLimitType? UsageLimitType { get; set; }

        /// <summary>
        /// Optional workspace ID to associate the API key with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthKeysCodeRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl">
        /// The callback URL to redirect to after authorization. Supports https URLs and localhost/127.0.0.1 URLs on any port for local CLI tools.<br/>
        /// Example: https://myapp.com/auth/callback
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE code challenge for enhanced security<br/>
        /// Example: E9Melhoa2OwvFrEMTJguCHaoeK1t8URWbuGJSstw-cM
        /// </param>
        /// <param name="codeChallengeMethod">
        /// The method used to generate the code challenge<br/>
        /// Example: S256
        /// </param>
        /// <param name="expiresAt">
        /// Optional ISO 8601 UTC expiration timestamp. Must include seconds (YYYY-MM-DDTHH:MM:SSZ; fractional seconds allowed); minute-precision timestamps are rejected.<br/>
        /// Example: 2027-12-31T23:59:59Z
        /// </param>
        /// <param name="keyLabel">
        /// Optional custom label for the API key. Defaults to the app name if not provided.<br/>
        /// Example: My Custom Key
        /// </param>
        /// <param name="limit">
        /// Credit limit for the API key to be created<br/>
        /// Example: 100
        /// </param>
        /// <param name="spawnAgent">
        /// Agent identifier for spawn telemetry<br/>
        /// Example: my-agent
        /// </param>
        /// <param name="spawnCloud">
        /// Cloud identifier for spawn telemetry<br/>
        /// Example: aws-us-east-1
        /// </param>
        /// <param name="usageLimitType">
        /// Optional credit limit reset interval. When set, the credit limit resets on this interval.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID to associate the API key with
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAuthKeysCodeRequest(
            string callbackUrl,
            string? codeChallenge,
            global::OpenRouter.CreateAuthKeysCodeRequestCodeChallengeMethod? codeChallengeMethod,
            global::System.DateTime? expiresAt,
            string? keyLabel,
            double? limit,
            string? spawnAgent,
            string? spawnCloud,
            global::OpenRouter.CreateAuthKeysCodeRequestUsageLimitType? usageLimitType,
            global::System.Guid? workspaceId)
        {
            this.CallbackUrl = callbackUrl ?? throw new global::System.ArgumentNullException(nameof(callbackUrl));
            this.CodeChallenge = codeChallenge;
            this.CodeChallengeMethod = codeChallengeMethod;
            this.ExpiresAt = expiresAt;
            this.KeyLabel = keyLabel;
            this.Limit = limit;
            this.SpawnAgent = spawnAgent;
            this.SpawnCloud = spawnCloud;
            this.UsageLimitType = usageLimitType;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAuthKeysCodeRequest" /> class.
        /// </summary>
        public CreateAuthKeysCodeRequest()
        {
        }

    }
}