
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Replaces the whole pricing object: omitting `cache_read` or `cache_write` reverts that rate to the pricing strategy default.
    /// </summary>
    public sealed partial class UpdatePrivateEndpointRequestPricing
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}