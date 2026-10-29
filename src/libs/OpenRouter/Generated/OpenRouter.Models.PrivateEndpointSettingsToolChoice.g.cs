
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointSettingsToolChoice
    {
        /// <summary>
        /// Accepts `tool_choice: "auto"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Auto { get; set; }

        /// <summary>
        /// Accepts a named function in `tool_choice`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Function { get; set; }

        /// <summary>
        /// Accepts `tool_choice: "none"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("none")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool None { get; set; }

        /// <summary>
        /// Accepts `tool_choice: "required"`.
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
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsToolChoice" /> class.
        /// </summary>
        /// <param name="auto">
        /// Accepts `tool_choice: "auto"`.
        /// </param>
        /// <param name="function">
        /// Accepts a named function in `tool_choice`.
        /// </param>
        /// <param name="none">
        /// Accepts `tool_choice: "none"`.
        /// </param>
        /// <param name="required">
        /// Accepts `tool_choice: "required"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointSettingsToolChoice(
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
        /// Initializes a new instance of the <see cref="PrivateEndpointSettingsToolChoice" /> class.
        /// </summary>
        public PrivateEndpointSettingsToolChoice()
        {
        }

    }
}