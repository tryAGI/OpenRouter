
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider routing preferences (order, only, ignore) and provider-specific passthrough configuration
    /// </summary>
    public sealed partial class VideoGenerationRequestProvider
    {
        /// <summary>
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Ignore { get; set; }

        /// <summary>
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("only")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Only { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ProviderOptions, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? Options { get; set; }

        /// <summary>
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequestProvider" /> class.
        /// </summary>
        /// <param name="ignore">
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="only">
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="options"></param>
        /// <param name="order">
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.<br/>
        /// Example: [openai, anthropic]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequestProvider(
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? ignore,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? only,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? options,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? order)
        {
            this.Ignore = ignore;
            this.Only = only;
            this.Options = options;
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequestProvider" /> class.
        /// </summary>
        public VideoGenerationRequestProvider()
        {
        }

    }
}