
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant5AudioVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bits_per_sample")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BitsPerSample { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Channels { get; set; }

        /// <summary>
        /// Base64-encoded PCM16 audio in the format the sibling fields give.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant5AudioVariant1FormatJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant1Format Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant5AudioVariant1" /> class.
        /// </summary>
        /// <param name="bitsPerSample"></param>
        /// <param name="channels"></param>
        /// <param name="data">
        /// Base64-encoded PCM16 audio in the format the sibling fields give.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant5AudioVariant1(
            double bitsPerSample,
            int channels,
            string data,
            int sampleRate,
            global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant1Format format)
        {
            this.BitsPerSample = bitsPerSample;
            this.Channels = channels;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant5AudioVariant1" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant5AudioVariant1()
        {
        }

    }
}