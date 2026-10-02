
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Default reasoning effort when the client enables reasoning without specifying effort. Maps to `reasoning.effort` in chat requests. When `"none"`, prefer omitting effort unless the user explicitly disables reasoning.
    /// </summary>
    public sealed partial class ModelReasoningDefaultEffort
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}