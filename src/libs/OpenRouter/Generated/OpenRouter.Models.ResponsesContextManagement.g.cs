
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A server-side context management entry. With `compaction`, the provider compacts the conversation once input exceeds `compact_threshold` and returns a `compaction` output item; pass that item back in `input` on later turns.<br/>
    /// Example: {"compact_threshold":200000,"type":"compaction"}
    /// </summary>
    public sealed partial class ResponsesContextManagement
    {
        /// <summary>
        /// Input token count at which server-side compaction is triggered.<br/>
        /// Example: 200000
        /// </summary>
        /// <example>200000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_threshold")]
        public int? CompactThreshold { get; set; }

        /// <summary>
        /// The context management strategy. Currently only `compaction` is supported.<br/>
        /// Example: compaction
        /// </summary>
        /// <example>compaction</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesContextManagement" /> class.
        /// </summary>
        /// <param name="type">
        /// The context management strategy. Currently only `compaction` is supported.<br/>
        /// Example: compaction
        /// </param>
        /// <param name="compactThreshold">
        /// Input token count at which server-side compaction is triggered.<br/>
        /// Example: 200000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesContextManagement(
            string type,
            int? compactThreshold)
        {
            this.CompactThreshold = compactThreshold;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesContextManagement" /> class.
        /// </summary>
        public ResponsesContextManagement()
        {
        }

    }
}