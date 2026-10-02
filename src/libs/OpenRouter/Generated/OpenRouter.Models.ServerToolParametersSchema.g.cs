
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// JSON Schema for the caller-side `tools[].parameters` object<br/>
    /// Example: {"properties":{},"type":"object"}
    /// </summary>
    public sealed partial class ServerToolParametersSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}