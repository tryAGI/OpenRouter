
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Per-variant `tool_choice` support. `tool_choice` in `supported_parameters` only says the parameter is accepted; these flags say which of its values passed testing.<br/>
    /// Example: {"auto":true,"function":true,"none":true,"required":true}
    /// </summary>
    public sealed partial class ToolChoiceSupport
    {
        /// <summary>
        /// Whether the endpoint supports `"tool_choice": "auto"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Auto { get; set; }

        /// <summary>
        /// Whether the endpoint supports naming a function, `"tool_choice": {"type": "function", ...}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Function { get; set; }

        /// <summary>
        /// Whether the endpoint supports `"tool_choice": "none"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("none")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool None { get; set; }

        /// <summary>
        /// Whether the endpoint supports `"tool_choice": "required"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceSupport" /> class.
        /// </summary>
        /// <param name="auto">
        /// Whether the endpoint supports `"tool_choice": "auto"`.
        /// </param>
        /// <param name="function">
        /// Whether the endpoint supports naming a function, `"tool_choice": {"type": "function", ...}`.
        /// </param>
        /// <param name="none">
        /// Whether the endpoint supports `"tool_choice": "none"`.
        /// </param>
        /// <param name="required">
        /// Whether the endpoint supports `"tool_choice": "required"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceSupport(
            bool auto,
            bool function,
            bool none,
            bool required)
        {
            this.Auto = auto;
            this.Function = function;
            this.None = none;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceSupport" /> class.
        /// </summary>
        public ToolChoiceSupport()
        {
        }

    }
}