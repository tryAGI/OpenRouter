
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A timestamped word, returned when the provider includes word-level timestamps
    /// </summary>
    public sealed partial class STTWord
    {
        /// <summary>
        /// Word end time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Word start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// The transcribed word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTWord" /> class.
        /// </summary>
        /// <param name="end">
        /// Word end time in seconds
        /// </param>
        /// <param name="start">
        /// Word start time in seconds
        /// </param>
        /// <param name="word">
        /// The transcribed word
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTWord(
            double end,
            double start,
            string word)
        {
            this.End = end;
            this.Start = start;
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTWord" /> class.
        /// </summary>
        public STTWord()
        {
        }

    }
}