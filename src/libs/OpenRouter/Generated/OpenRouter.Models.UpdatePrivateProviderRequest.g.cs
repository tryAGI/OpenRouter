
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePrivateProviderRequest
    {
        /// <summary>
        /// HTTPS base URL of an OpenAI-compatible API, used by private endpoints under this provider that set no URL of their own. Without it, each endpoint must set its own. Private, internal, metadata and OpenRouter hosts are rejected.<br/>
        /// Example: https://inference.example.com/v1
        /// </summary>
        /// <example>https://inference.example.com/v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_policy")]
        public global::OpenRouter.UpdatePrivateProviderRequestDataPolicy? DataPolicy { get; set; }

        /// <summary>
        /// Example: Acme
        /// </summary>
        /// <example>Acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateProviderRequest" /> class.
        /// </summary>
        /// <param name="baseUrl">
        /// HTTPS base URL of an OpenAI-compatible API, used by private endpoints under this provider that set no URL of their own. Without it, each endpoint must set its own. Private, internal, metadata and OpenRouter hosts are rejected.<br/>
        /// Example: https://inference.example.com/v1
        /// </param>
        /// <param name="dataPolicy"></param>
        /// <param name="displayName">
        /// Example: Acme
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateProviderRequest(
            string? baseUrl,
            global::OpenRouter.UpdatePrivateProviderRequestDataPolicy? dataPolicy,
            string? displayName)
        {
            this.BaseUrl = baseUrl;
            this.DataPolicy = dataPolicy;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateProviderRequest" /> class.
        /// </summary>
        public UpdatePrivateProviderRequest()
        {
        }

    }
}