
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File File { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1TypeJsonConverter))]
        public global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1(
            global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File file,
            global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1Type type)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1" /> class.
        /// </summary>
        public BatchResultResponseBodyVariant1ChoiceMessageAnnotationVariant1()
        {
        }

    }
}