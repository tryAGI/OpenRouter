
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)<br/>
    /// Example: {"session_id":"session-456","user_id":"user-123"}
    /// </summary>
    public sealed partial class ChatRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}