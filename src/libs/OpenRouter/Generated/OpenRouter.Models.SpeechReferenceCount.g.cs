
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"max":1,"min":1,"type":"integer"}
    /// </summary>
    public sealed partial class SpeechReferenceCount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public int? Max { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechReferenceCountTypeJsonConverter))]
        public global::OpenRouter.SpeechReferenceCountType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechReferenceCount" /> class.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechReferenceCount(
            int min,
            int? max,
            global::OpenRouter.SpeechReferenceCountType type)
        {
            this.Max = max;
            this.Min = min;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechReferenceCount" /> class.
        /// </summary>
        public SpeechReferenceCount()
        {
        }

    }
}