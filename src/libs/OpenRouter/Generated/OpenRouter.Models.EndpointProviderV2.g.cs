
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndpointProviderV2
    {
        /// <summary>
        /// Provider display name<br/>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Provider slug, as listed by `GET /api/v1/providers` and accepted by the `provider.order` and `provider.only` routing preferences<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Routing tag of the deployment serving this endpoint: the provider slug, extended with a region or tier segment when the provider runs several deployments (e.g. `azure/global`)<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointProviderV2" /> class.
        /// </summary>
        /// <param name="name">
        /// Provider display name<br/>
        /// Example: OpenAI
        /// </param>
        /// <param name="slug">
        /// Provider slug, as listed by `GET /api/v1/providers` and accepted by the `provider.order` and `provider.only` routing preferences<br/>
        /// Example: openai
        /// </param>
        /// <param name="tag">
        /// Routing tag of the deployment serving this endpoint: the provider slug, extended with a region or tier segment when the provider runs several deployments (e.g. `azure/global`)<br/>
        /// Example: openai
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointProviderV2(
            string name,
            string slug,
            string tag)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointProviderV2" /> class.
        /// </summary>
        public EndpointProviderV2()
        {
        }

    }
}