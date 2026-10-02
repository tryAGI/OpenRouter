
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Optional partner-defined identity associated with the created API key.
    /// </summary>
    public sealed partial class CreateKeysRequestExternal
    {
        /// <summary>
        /// Optional partner-supplied API key with a minimum length of 32 characters and sufficient entropy. Stored as a SHA-256 hash and never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Partner's end-user identifier for attribution.<br/>
        /// Example: partner-user-123
        /// </summary>
        /// <example>partner-user-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysRequestExternal" /> class.
        /// </summary>
        /// <param name="user">
        /// Partner's end-user identifier for attribution.<br/>
        /// Example: partner-user-123
        /// </param>
        /// <param name="apiKey">
        /// Optional partner-supplied API key with a minimum length of 32 characters and sufficient entropy. Stored as a SHA-256 hash and never returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKeysRequestExternal(
            string user,
            string? apiKey)
        {
            this.ApiKey = apiKey;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysRequestExternal" /> class.
        /// </summary>
        public CreateKeysRequestExternal()
        {
        }

    }
}