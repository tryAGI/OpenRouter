
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Concrete model targeted by this tilde-latest alias, when applicable<br/>
    /// Example: {"name":"Claude Sonnet 4.5","slug":"anthropic/claude-sonnet-4.5"}
    /// </summary>
    public sealed partial class ModelAliasTarget
    {
        /// <summary>
        /// Human-readable name of the concrete model targeted by this alias
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Routable model ID of the concrete target, matching that model row's id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAliasTarget" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name of the concrete model targeted by this alias
        /// </param>
        /// <param name="slug">
        /// Routable model ID of the concrete target, matching that model row's id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAliasTarget(
            string name,
            string slug)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAliasTarget" /> class.
        /// </summary>
        public ModelAliasTarget()
        {
        }

    }
}