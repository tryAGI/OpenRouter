
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The audio of the withheld message: its `id` and `transcript`. The plugin does not retain `data` or `expires_at`.<br/>
    /// Example: {"id":"audio_abc123","transcript":"Sure, I can take 20% off your order."}
    /// </summary>
    public sealed partial class AlignmentChatAudio
    {
        /// <summary>
        /// The provider id of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The transcript of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentChatAudio" /> class.
        /// </summary>
        /// <param name="transcript">
        /// The transcript of the audio.
        /// </param>
        /// <param name="id">
        /// The provider id of the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentChatAudio(
            string transcript,
            string? id)
        {
            this.Id = id;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentChatAudio" /> class.
        /// </summary>
        public AlignmentChatAudio()
        {
        }

    }
}