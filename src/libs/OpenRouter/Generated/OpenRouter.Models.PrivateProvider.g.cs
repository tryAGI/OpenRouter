
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"base_url":"https://inference.example.com/v1","created_at":"2026-10-06T12:00:00.000Z","data_policy":{"prompt_retention_days":null,"retains_prompts":false,"training":false},"display_name":"Acme","name":"Acme","slug":"acme"}
    /// </summary>
    public sealed partial class PrivateProvider
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Your declared data policy, or `null` when none was declared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_policy")]
        public global::OpenRouter.PrivateProviderDataPolicy? DataPolicy { get; set; }

        /// <summary>
        /// Example: Acme
        /// </summary>
        /// <example>Acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Provider name, shown in your activity, logs and Broadcast output. 2-64 letters, numbers, spaces, dots, underscores or hyphens. Cannot be changed later. Neither the name nor its slug may match a public provider name or slug (case-insensitive); other customers may use the same name.<br/>
        /// Example: Acme
        /// </summary>
        /// <example>Acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The slug you chose, unique within your account. Use it as `provider_slug` when creating private endpoints and BYOK keys, and in `provider.order`, `only` and `ignore`.<br/>
        /// Example: acme
        /// </summary>
        /// <example>acme</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProvider" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="displayName">
        /// Example: Acme
        /// </param>
        /// <param name="name">
        /// Provider name, shown in your activity, logs and Broadcast output. 2-64 letters, numbers, spaces, dots, underscores or hyphens. Cannot be changed later. Neither the name nor its slug may match a public provider name or slug (case-insensitive); other customers may use the same name.<br/>
        /// Example: Acme
        /// </param>
        /// <param name="slug">
        /// The slug you chose, unique within your account. Use it as `provider_slug` when creating private endpoints and BYOK keys, and in `provider.order`, `only` and `ignore`.<br/>
        /// Example: acme
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of an OpenAI-compatible API, used by private endpoints under this provider that set no URL of their own. Without it, each endpoint must set its own. Private, internal, metadata and OpenRouter hosts are rejected.<br/>
        /// Example: https://inference.example.com/v1
        /// </param>
        /// <param name="dataPolicy">
        /// Your declared data policy, or `null` when none was declared.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateProvider(
            string createdAt,
            string displayName,
            string name,
            string slug,
            string? baseUrl,
            global::OpenRouter.PrivateProviderDataPolicy? dataPolicy)
        {
            this.BaseUrl = baseUrl;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DataPolicy = dataPolicy;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateProvider" /> class.
        /// </summary>
        public PrivateProvider()
        {
        }

    }
}