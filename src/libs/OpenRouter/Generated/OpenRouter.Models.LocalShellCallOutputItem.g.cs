
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Output from a local shell command execution
    /// </summary>
    public sealed partial class LocalShellCallOutputItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        public global::OpenRouter.ToolCallStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.LocalShellCallOutputItemTypeJsonConverter))]
        public global::OpenRouter.LocalShellCallOutputItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellCallOutputItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalShellCallOutputItem(
            string id,
            string output,
            global::OpenRouter.ToolCallStatus? status,
            global::OpenRouter.LocalShellCallOutputItemType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellCallOutputItem" /> class.
        /// </summary>
        public LocalShellCallOutputItem()
        {
        }

    }
}