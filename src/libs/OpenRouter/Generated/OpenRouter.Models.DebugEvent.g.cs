
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Debug event emitted when debug.echo_upstream_body is true. Contains the transformed upstream request body or timing milestones.<br/>
    /// Example: {"debug":{"echo_upstream_body":{"messages":[],"model":"anthropic/claude-sonnet-4"}},"sequence_number":1,"type":"response.debug"}
    /// </summary>
    public sealed partial class DebugEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DebugEventDebug Debug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DebugEventTypeJsonConverter))]
        public global::OpenRouter.DebugEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugEvent" /> class.
        /// </summary>
        /// <param name="debug"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DebugEvent(
            global::OpenRouter.DebugEventDebug debug,
            int sequenceNumber,
            global::OpenRouter.DebugEventType type)
        {
            this.Debug = debug ?? throw new global::System.ArgumentNullException(nameof(debug));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugEvent" /> class.
        /// </summary>
        public DebugEvent()
        {
        }

    }
}