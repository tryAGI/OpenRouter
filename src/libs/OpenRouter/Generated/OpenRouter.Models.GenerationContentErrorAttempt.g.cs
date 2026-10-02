
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single failed upstream attempt recorded for the generation<br/>
    /// Example: {"code":429,"message":"Provider returned error","provider_name":"Google","raw":"{\u0022error\u0022:{\u0022code\u0022:429,\u0022message\u0022:\u0022Resource exhausted\u0022}}"}
    /// </summary>
    public sealed partial class GenerationContentErrorAttempt
    {
        /// <summary>
        /// HTTP status returned by this attempt<br/>
        /// Example: 429
        /// </summary>
        /// <example>429</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// Error message returned by this attempt<br/>
        /// Example: Provider returned error
        /// </summary>
        /// <example>Provider returned error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Provider that served this attempt, when known<br/>
        /// Example: Google
        /// </summary>
        /// <example>Google</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Raw error body returned by the provider, when stored<br/>
        /// Example: {"error":{"code":429,"message":"Resource exhausted"}}
        /// </summary>
        /// <example>{"error":{"code":429,"message":"Resource exhausted"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public string? Raw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentErrorAttempt" /> class.
        /// </summary>
        /// <param name="code">
        /// HTTP status returned by this attempt<br/>
        /// Example: 429
        /// </param>
        /// <param name="message">
        /// Error message returned by this attempt<br/>
        /// Example: Provider returned error
        /// </param>
        /// <param name="providerName">
        /// Provider that served this attempt, when known<br/>
        /// Example: Google
        /// </param>
        /// <param name="raw">
        /// Raw error body returned by the provider, when stored<br/>
        /// Example: {"error":{"code":429,"message":"Resource exhausted"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationContentErrorAttempt(
            int code,
            string message,
            string? providerName,
            string? raw)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ProviderName = providerName;
            this.Raw = raw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentErrorAttempt" /> class.
        /// </summary>
        public GenerationContentErrorAttempt()
        {
        }

    }
}