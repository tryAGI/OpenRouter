
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The accepted `speed` range. Absent: the provider documents no range; some providers still forward `speed`.<br/>
    /// Example: {"max":4,"min":0.25,"type":"range"}
    /// </summary>
    public sealed partial class SpeechRangeParameter
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechRangeParameterTypeJsonConverter))]
        public global::OpenRouter.SpeechRangeParameterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRangeParameter" /> class.
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRangeParameter(
            double max,
            double min,
            global::OpenRouter.SpeechRangeParameterType type)
        {
            this.Max = max;
            this.Min = min;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRangeParameter" /> class.
        /// </summary>
        public SpeechRangeParameter()
        {
        }

    }
}