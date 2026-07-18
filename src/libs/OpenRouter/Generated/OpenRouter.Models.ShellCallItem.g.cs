
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A shell command execution call (newer variant)
    /// </summary>
    public sealed partial class ShellCallItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ShellCallItemAction Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Any type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public object? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ToolCallStatus?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ToolCallStatus?, object>? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellCallItemTypeJsonConverter))]
        public global::OpenRouter.ShellCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallItem" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="callId"></param>
        /// <param name="environment">
        /// Any type
        /// </param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShellCallItem(
            global::OpenRouter.ShellCallItemAction action,
            string callId,
            object? environment,
            string? id,
            global::OpenRouter.OneOf<global::OpenRouter.ToolCallStatus?, object>? status,
            global::OpenRouter.ShellCallItemType type)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Environment = environment;
            this.Id = id;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallItem" /> class.
        /// </summary>
        public ShellCallItem()
        {
        }

    }
}