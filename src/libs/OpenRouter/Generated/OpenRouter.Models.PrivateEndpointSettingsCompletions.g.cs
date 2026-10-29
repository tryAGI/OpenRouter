
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointSettingsCompletions
    {
        /// <summary>
        /// Serves `/chat/completions`; `null` uses the provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public bool? Chat { get; set; }

        /// <summary>
        /// Serves `/completions`; `null` uses the provider default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public bool? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsCompletions" /> class.
        /// </summary>
        /// <param name="chat">
        /// Serves `/chat/completions`; `null` uses the provider default.
        /// </param>
        /// <param name="text">
        /// Serves `/completions`; `null` uses the provider default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointSettingsCompletions(
            bool? chat,
            bool? text)
        {
            this.Chat = chat;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsCompletions" /> class.
        /// </summary>
        public PrivateEndpointSettingsCompletions()
        {
        }

    }
}