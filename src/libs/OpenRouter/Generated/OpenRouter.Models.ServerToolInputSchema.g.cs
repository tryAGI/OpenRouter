
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// JSON Schema of the arguments the model emits when calling the tool<br/>
    /// Example: {"properties":{},"type":"object"}
    /// </summary>
    public sealed partial class ServerToolInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}