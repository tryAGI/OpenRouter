
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant1, global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant1, global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant2> Audio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant5ObjectJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant5Object Object { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchObjectResultResponseBodyVariant5Usage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant5" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="model"></param>
        /// <param name="usage"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant5(
            global::OpenRouter.AnyOf<global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant1, global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant2> audio,
            string model,
            global::OpenRouter.BatchObjectResultResponseBodyVariant5Usage usage,
            global::OpenRouter.BatchObjectResultResponseBodyVariant5Object @object)
        {
            this.Audio = audio;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant5" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant5()
        {
        }

    }
}