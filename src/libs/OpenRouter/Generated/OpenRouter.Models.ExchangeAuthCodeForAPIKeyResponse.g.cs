
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"key":"example-api-key","user_id":"user_2yOPcMpKoQhcd4bVgSMlELRaIah"}
    /// </summary>
    public sealed partial class ExchangeAuthCodeForAPIKeyResponse
    {
        /// <summary>
        /// The API key to use for OpenRouter requests<br/>
        /// Example: example-api-key
        /// </summary>
        /// <example>example-api-key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// User ID associated with the API key<br/>
        /// Example: user_2yOPcMpKoQhcd4bVgSMlELRaIah
        /// </summary>
        /// <example>user_2yOPcMpKoQhcd4bVgSMlELRaIah</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeAuthCodeForAPIKeyResponse" /> class.
        /// </summary>
        /// <param name="key">
        /// The API key to use for OpenRouter requests<br/>
        /// Example: example-api-key
        /// </param>
        /// <param name="userId">
        /// User ID associated with the API key<br/>
        /// Example: user_2yOPcMpKoQhcd4bVgSMlELRaIah
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExchangeAuthCodeForAPIKeyResponse(
            string key,
            string? userId)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeAuthCodeForAPIKeyResponse" /> class.
        /// </summary>
        public ExchangeAuthCodeForAPIKeyResponse()
        {
        }

    }
}