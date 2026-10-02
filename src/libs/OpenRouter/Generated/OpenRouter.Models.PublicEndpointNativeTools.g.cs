
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The server tools this endpoint accepts as the provider's own built-in tool (`engine: "native"`) instead of an OpenRouter engine, keyed by canonical `openrouter:*` name. Each value names the provider tool type the request is translated to. Where that tool runs (provider-side, or returned to the client as with Anthropic bash) is documented per tool. Empty when the provider has none.<br/>
    /// Example: {"openrouter:web_search":{"type":"web_search_20260209"}}
    /// </summary>
    public sealed partial class PublicEndpointNativeTools
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}