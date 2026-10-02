
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Approximate user location for location-biased search results. Passed through to native providers that support it (e.g. Anthropic).<br/>
    /// Example: {"city":"San Francisco","country":"US","region":"California","timezone":"America/Los_Angeles","type":"approximate"}
    /// </summary>
    public sealed partial class WebSearchPluginUserLocation
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}