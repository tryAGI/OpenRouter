
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: returns the current date and time
    /// </summary>
    public sealed partial class DatetimeServerTool
    {
        /// <summary>
        /// Configuration for the openrouter:datetime server tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.DatetimeServerToolConfig? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DatetimeServerToolTypeJsonConverter))]
        public global::OpenRouter.DatetimeServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeServerTool" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for the openrouter:datetime server tool
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatetimeServerTool(
            global::OpenRouter.DatetimeServerToolConfig? parameters,
            global::OpenRouter.DatetimeServerToolType type)
        {
            this.Parameters = parameters;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeServerTool" /> class.
        /// </summary>
        public DatetimeServerTool()
        {
        }
    }
}