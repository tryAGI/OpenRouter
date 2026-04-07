
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicServerToolUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebSearchRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_fetch_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebFetchRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicServerToolUsage" /> class.
        /// </summary>
        /// <param name="webSearchRequests"></param>
        /// <param name="webFetchRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicServerToolUsage(
            int webSearchRequests,
            int webFetchRequests)
        {
            this.WebSearchRequests = webSearchRequests;
            this.WebFetchRequests = webFetchRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicServerToolUsage" /> class.
        /// </summary>
        public AnthropicServerToolUsage()
        {
        }
    }
}