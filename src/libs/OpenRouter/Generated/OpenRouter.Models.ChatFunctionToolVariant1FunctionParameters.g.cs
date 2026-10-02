
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Function parameters as JSON Schema object<br/>
    /// Example: {"properties":{"location":{"description":"City name","type":"string"}},"required":["location"],"type":"object"}
    /// </summary>
    public sealed partial class ChatFunctionToolVariant1FunctionParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}