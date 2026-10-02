
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop when the upstream model emits this finish reason (e.g. `length`).<br/>
    /// Example: {"reason":"length","type":"finish_reason_is"}
    /// </summary>
    public sealed partial class StopServerToolsWhenFinishReasonIs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenFinishReasonIsTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenFinishReasonIsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenFinishReasonIs" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenFinishReasonIs(
            string reason,
            global::OpenRouter.StopServerToolsWhenFinishReasonIsType type)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenFinishReasonIs" /> class.
        /// </summary>
        public StopServerToolsWhenFinishReasonIs()
        {
        }

    }
}