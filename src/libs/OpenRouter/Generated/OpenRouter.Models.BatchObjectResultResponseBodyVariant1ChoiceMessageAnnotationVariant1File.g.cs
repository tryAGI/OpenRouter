
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1, global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="hash"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File(
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant1, global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1FileContentItemVariant2>> content,
            string hash,
            string? name)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant1File()
        {
        }

    }
}