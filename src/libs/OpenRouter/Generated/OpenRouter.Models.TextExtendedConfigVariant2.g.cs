
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextExtendedConfigVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.TextExtendedConfigVariant2VerbosityJsonConverter))]
        public global::OpenRouter.TextExtendedConfigVariant2Verbosity? Verbosity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExtendedConfigVariant2" /> class.
        /// </summary>
        /// <param name="verbosity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextExtendedConfigVariant2(
            global::OpenRouter.TextExtendedConfigVariant2Verbosity? verbosity)
        {
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExtendedConfigVariant2" /> class.
        /// </summary>
        public TextExtendedConfigVariant2()
        {
        }

    }
}