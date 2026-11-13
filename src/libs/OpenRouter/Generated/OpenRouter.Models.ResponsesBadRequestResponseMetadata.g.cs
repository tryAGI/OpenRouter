
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Validation details for string-coded errors; `raw` holds the serialized schema issues<br/>
    /// Example: {"raw":"[{\u0022code\u0022:\u0022invalid_value\u0022,\u0022path\u0022:[\u0022input\u0022,0,\u0022type\u0022]}]"}
    /// </summary>
    public sealed partial class ResponsesBadRequestResponseMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}