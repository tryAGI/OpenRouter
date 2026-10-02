
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The stored failure for this generation, or null when it succeeded<br/>
    /// Example: {"message":"Timed out waiting for the provider","previous_errors":[{"code":429,"message":"Provider returned error","provider_name":"Google","raw":"{\u0022error\u0022:{\u0022code\u0022:429,\u0022message\u0022:\u0022Resource exhausted\u0022}}"}],"provider_name":"Vertex","raw":"{\u0022error\u0022:{\u0022code\u0022:504,\u0022message\u0022:\u0022Deadline exceeded\u0022}}","status":504}
    /// </summary>
    public sealed partial class GenerationContentError
    {
        /// <summary>
        /// Error message returned to the client<br/>
        /// Example: Timed out waiting for the provider
        /// </summary>
        /// <example>Timed out waiting for the provider</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Every upstream attempt that failed before the returned error, in attempt order
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.GenerationContentErrorAttempt> PreviousErrors { get; set; }

        /// <summary>
        /// Provider whose error was returned to the client, when known<br/>
        /// Example: Vertex
        /// </summary>
        /// <example>Vertex</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Raw error body behind the returned error, when stored<br/>
        /// Example: {"error":{"code":504,"message":"Deadline exceeded"}}
        /// </summary>
        /// <example>{"error":{"code":504,"message":"Deadline exceeded"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public string? Raw { get; set; }

        /// <summary>
        /// HTTP status returned to the client<br/>
        /// Example: 504
        /// </summary>
        /// <example>504</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentError" /> class.
        /// </summary>
        /// <param name="previousErrors">
        /// Every upstream attempt that failed before the returned error, in attempt order
        /// </param>
        /// <param name="message">
        /// Error message returned to the client<br/>
        /// Example: Timed out waiting for the provider
        /// </param>
        /// <param name="providerName">
        /// Provider whose error was returned to the client, when known<br/>
        /// Example: Vertex
        /// </param>
        /// <param name="raw">
        /// Raw error body behind the returned error, when stored<br/>
        /// Example: {"error":{"code":504,"message":"Deadline exceeded"}}
        /// </param>
        /// <param name="status">
        /// HTTP status returned to the client<br/>
        /// Example: 504
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationContentError(
            global::System.Collections.Generic.IList<global::OpenRouter.GenerationContentErrorAttempt> previousErrors,
            string? message,
            string? providerName,
            string? raw,
            int? status)
        {
            this.Message = message;
            this.PreviousErrors = previousErrors ?? throw new global::System.ArgumentNullException(nameof(previousErrors));
            this.ProviderName = providerName;
            this.Raw = raw;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentError" /> class.
        /// </summary>
        public GenerationContentError()
        {
        }

    }
}