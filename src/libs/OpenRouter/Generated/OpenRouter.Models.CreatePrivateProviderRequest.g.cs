
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePrivateProviderRequest
    {
        /// <summary>
        /// HTTPS base URL of an OpenAI-compatible API, used by private endpoints under this provider that set no URL of their own. Without it, each endpoint must set its own. Private, internal, metadata and OpenRouter hosts are rejected.<br/>
        /// Example: https://inference.example.com/v1
        /// </summary>
        /// <example>https://inference.example.com/v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Defaults to training on and retaining prompts, the most conservative declaration. Your own declaration; it applies to your own traffic and OpenRouter does not verify it.<br/>
        /// Example: {"prompt_retention_days":null,"retains_prompts":false,"training":false}
        /// </summary>
        /// <example>{"prompt_retention_days":null,"retains_prompts":false,"training":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_policy")]
        public global::OpenRouter.PrivateProviderDataPolicy2? DataPolicy { get; set; }

        /// <summary>
        /// Defaults to `name`.<br/>
        /// Example: Acme
        /// </summary>
        /// <example>Acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Provider name, shown in your activity, logs and Broadcast output. 2-64 letters, numbers, spaces, dots, underscores or hyphens. Cannot be changed later. Neither the name nor its slug may match a public provider name or slug (case-insensitive); other customers may use the same name.<br/>
        /// Example: Acme
        /// </summary>
        /// <example>Acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 2-64 lowercase letters and numbers, separated by single hyphens. Cannot be changed later. Defaults to the name lowercased, with every run of other characters replaced by a hyphen (`Acme Inference` becomes `acme-inference`).<br/>
        /// Example: acme
        /// </summary>
        /// <example>acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateProviderRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Provider name, shown in your activity, logs and Broadcast output. 2-64 letters, numbers, spaces, dots, underscores or hyphens. Cannot be changed later. Neither the name nor its slug may match a public provider name or slug (case-insensitive); other customers may use the same name.<br/>
        /// Example: Acme
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of an OpenAI-compatible API, used by private endpoints under this provider that set no URL of their own. Without it, each endpoint must set its own. Private, internal, metadata and OpenRouter hosts are rejected.<br/>
        /// Example: https://inference.example.com/v1
        /// </param>
        /// <param name="dataPolicy">
        /// Defaults to training on and retaining prompts, the most conservative declaration. Your own declaration; it applies to your own traffic and OpenRouter does not verify it.<br/>
        /// Example: {"prompt_retention_days":null,"retains_prompts":false,"training":false}
        /// </param>
        /// <param name="displayName">
        /// Defaults to `name`.<br/>
        /// Example: Acme
        /// </param>
        /// <param name="slug">
        /// 2-64 lowercase letters and numbers, separated by single hyphens. Cannot be changed later. Defaults to the name lowercased, with every run of other characters replaced by a hyphen (`Acme Inference` becomes `acme-inference`).<br/>
        /// Example: acme
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePrivateProviderRequest(
            string name,
            string? baseUrl,
            global::OpenRouter.PrivateProviderDataPolicy2? dataPolicy,
            string? displayName,
            string? slug)
        {
            this.BaseUrl = baseUrl;
            this.DataPolicy = dataPolicy;
            this.DisplayName = displayName;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateProviderRequest" /> class.
        /// </summary>
        public CreatePrivateProviderRequest()
        {
        }

    }
}