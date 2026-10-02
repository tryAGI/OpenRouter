
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Union of supported parameters across every endpoint of this model. Coarse discovery aid; the definitive per-endpoint set is behind the endpoints URL.<br/>
    /// Example: {"output_compression":{"max":100,"min":0,"type":"range"},"resolution":{"type":"enum","values":["1K","2K","4K"]},"seed":{"type":"boolean"}}
    /// </summary>
    public sealed partial class SupportedParameters2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}