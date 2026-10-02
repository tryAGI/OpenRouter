
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicEndpointNativeTools2
    {
        /// <summary>
        /// The provider tool type the request is translated to when this tool runs natively, e.g. `web_search_20260209` on Anthropic or `google_search` on Gemini.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointNativeTools2" /> class.
        /// </summary>
        /// <param name="type">
        /// The provider tool type the request is translated to when this tool runs natively, e.g. `web_search_20260209` on Anthropic or `google_search` on Gemini.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicEndpointNativeTools2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointNativeTools2" /> class.
        /// </summary>
        public PublicEndpointNativeTools2()
        {
        }

    }
}