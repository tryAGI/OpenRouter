
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomToolFormatVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Definition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CustomToolFormatVariant2SyntaxJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CustomToolFormatVariant2Syntax Syntax { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CustomToolFormatVariant2TypeJsonConverter))]
        public global::OpenRouter.CustomToolFormatVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormatVariant2" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="syntax"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolFormatVariant2(
            string definition,
            global::OpenRouter.CustomToolFormatVariant2Syntax syntax,
            global::OpenRouter.CustomToolFormatVariant2Type type)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Syntax = syntax;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormatVariant2" /> class.
        /// </summary>
        public CustomToolFormatVariant2()
        {
        }

    }
}