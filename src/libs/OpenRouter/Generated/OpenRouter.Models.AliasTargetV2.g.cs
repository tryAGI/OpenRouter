
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// For an `alias` record, the model it currently resolves to; absent while the alias has no live target
    /// </summary>
    public sealed partial class AliasTargetV2
    {
        /// <summary>
        /// Name of the model the alias currently resolves to<br/>
        /// Example: Anthropic: Claude Opus 4.5
        /// </summary>
        /// <example>Anthropic: Claude Opus 4.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Slug of the model the alias currently resolves to<br/>
        /// Example: anthropic/claude-opus-4.5
        /// </summary>
        /// <example>anthropic/claude-opus-4.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasTargetV2" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the model the alias currently resolves to<br/>
        /// Example: Anthropic: Claude Opus 4.5
        /// </param>
        /// <param name="slug">
        /// Slug of the model the alias currently resolves to<br/>
        /// Example: anthropic/claude-opus-4.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasTargetV2(
            string name,
            string slug)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasTargetV2" /> class.
        /// </summary>
        public AliasTargetV2()
        {
        }

    }
}