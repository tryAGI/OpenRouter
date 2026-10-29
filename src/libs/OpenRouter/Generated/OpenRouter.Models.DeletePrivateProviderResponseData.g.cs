
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeletePrivateProviderResponseData
    {
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
        /// Initializes a new instance of the <see cref="DeletePrivateProviderResponseData" /> class.
        /// </summary>
        /// <param name="slug">
        /// The slug you chose, unique within your account. Use it as `provider_slug` when creating private endpoints and BYOK keys, and in `provider.order`, `only` and `ignore`.<br/>
        /// Example: acme
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletePrivateProviderResponseData(
            string slug)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePrivateProviderResponseData" /> class.
        /// </summary>
        public DeletePrivateProviderResponseData()
        {
        }

    }
}