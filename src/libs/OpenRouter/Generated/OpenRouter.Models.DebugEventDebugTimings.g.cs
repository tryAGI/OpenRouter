
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DebugEventDebugTimings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epoch_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EpochMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DebugEventDebugTimingsEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DebugEventDebugTimingsEvent Event { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugEventDebugTimings" /> class.
        /// </summary>
        /// <param name="epochMs"></param>
        /// <param name="event"></param>
        /// <param name="startMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DebugEventDebugTimings(
            int epochMs,
            global::OpenRouter.DebugEventDebugTimingsEvent @event,
            int startMs)
        {
            this.EpochMs = epochMs;
            this.Event = @event;
            this.StartMs = startMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugEventDebugTimings" /> class.
        /// </summary>
        public DebugEventDebugTimings()
        {
        }

    }
}