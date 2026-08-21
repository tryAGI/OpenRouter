
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Streaming configuration options
    /// </summary>
    public sealed partial class ChatStreamOptions
    {
        /// <summary>
        /// Deprecated: This field has no effect. Full usage details are always included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}