
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechTurn
    {
        /// <summary>
        /// Delivery instructions for this turn, such as tone, pacing, or emotion. Overrides the top-level `instructions`.<br/>
        /// Example: whispering
        /// </summary>
        /// <example>whispering</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Text to synthesize<br/>
        /// Example: Hi Jane.
        /// </summary>
        /// <example>Hi Jane.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Voice for this turn. Defaults to the top-level `voice`.<br/>
        /// Example: Kore
        /// </summary>
        /// <example>Kore</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTurn" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to synthesize<br/>
        /// Example: Hi Jane.
        /// </param>
        /// <param name="instructions">
        /// Delivery instructions for this turn, such as tone, pacing, or emotion. Overrides the top-level `instructions`.<br/>
        /// Example: whispering
        /// </param>
        /// <param name="voice">
        /// Voice for this turn. Defaults to the top-level `voice`.<br/>
        /// Example: Kore
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechTurn(
            string text,
            string? instructions,
            string? voice)
        {
            this.Instructions = instructions;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechTurn" /> class.
        /// </summary>
        public SpeechTurn()
        {
        }

    }
}