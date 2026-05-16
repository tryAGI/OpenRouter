
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservabilityLangfuseDestinationConfig
    {
        /// <summary>
        /// Default Value: https://us.cloud.langfuse.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityLangfuseDestinationConfig" /> class.
        /// </summary>
        /// <param name="publicKey"></param>
        /// <param name="secretKey"></param>
        /// <param name="baseUrl">
        /// Default Value: https://us.cloud.langfuse.com
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityLangfuseDestinationConfig(
            string publicKey,
            string secretKey,
            string? baseUrl,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.BaseUrl = baseUrl;
            this.Headers = headers;
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityLangfuseDestinationConfig" /> class.
        /// </summary>
        public ObservabilityLangfuseDestinationConfig()
        {
        }

    }
}