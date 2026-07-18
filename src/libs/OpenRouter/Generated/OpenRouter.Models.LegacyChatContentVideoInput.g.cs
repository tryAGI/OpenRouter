
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Video input object
    /// </summary>
    public sealed partial class LegacyChatContentVideoInput
    {
        /// <summary>
        /// URL of the video (data: URLs supported)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyChatContentVideoInput" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the video (data: URLs supported)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyChatContentVideoInput(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyChatContentVideoInput" /> class.
        /// </summary>
        public LegacyChatContentVideoInput()
        {
        }

    }
}