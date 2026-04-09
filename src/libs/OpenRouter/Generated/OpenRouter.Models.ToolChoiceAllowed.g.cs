
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Constrains the model to a pre-defined set of allowed tools
    /// </summary>
    public sealed partial class ToolChoiceAllowed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolChoiceAllowedMode Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolChoiceAllowedTypeJsonConverter))]
        public global::OpenRouter.ToolChoiceAllowedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAllowed" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="tools"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoiceAllowed(
            global::OpenRouter.ToolChoiceAllowedMode mode,
            global::System.Collections.Generic.IList<object> tools,
            global::OpenRouter.ToolChoiceAllowedType type)
        {
            this.Mode = mode;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceAllowed" /> class.
        /// </summary>
        public ToolChoiceAllowed()
        {
        }
    }
}