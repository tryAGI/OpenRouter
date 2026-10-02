
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerToolNativeModel
    {
        /// <summary>
        /// Example: [Anthropic, Google]
        /// </summary>
        /// <example>[Anthropic, Google]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Providers { get; set; }

        /// <summary>
        /// Example: anthropic/claude-4.5-sonnet
        /// </summary>
        /// <example>anthropic/claude-4.5-sonnet</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolNativeModel" /> class.
        /// </summary>
        /// <param name="providers">
        /// Example: [Anthropic, Google]
        /// </param>
        /// <param name="slug">
        /// Example: anthropic/claude-4.5-sonnet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolNativeModel(
            global::System.Collections.Generic.IList<string> providers,
            string slug)
        {
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolNativeModel" /> class.
        /// </summary>
        public ServerToolNativeModel()
        {
        }

    }
}