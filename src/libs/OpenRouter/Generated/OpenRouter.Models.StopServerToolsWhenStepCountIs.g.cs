
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop after the agent loop has executed this many steps.<br/>
    /// Example: {"step_count":5,"type":"step_count_is"}
    /// </summary>
    public sealed partial class StopServerToolsWhenStepCountIs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StepCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenStepCountIsTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenStepCountIsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenStepCountIs" /> class.
        /// </summary>
        /// <param name="stepCount"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenStepCountIs(
            int stepCount,
            global::OpenRouter.StopServerToolsWhenStepCountIsType type)
        {
            this.StepCount = stepCount;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenStepCountIs" /> class.
        /// </summary>
        public StopServerToolsWhenStepCountIs()
        {
        }

    }
}