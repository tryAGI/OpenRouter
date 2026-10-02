
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FunctionCallOutputItemVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>))]
        public global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemVariant2" /> class.
        /// </summary>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallOutputItemVariant2(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.InputText, global::OpenRouter.AllOf<global::OpenRouter.InputImage, object>?, global::OpenRouter.InputFile>>>? output)
        {
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallOutputItemVariant2" /> class.
        /// </summary>
        public FunctionCallOutputItemVariant2()
        {
        }

    }
}