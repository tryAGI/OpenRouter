
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant5AudioVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("byte_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ByteLength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Channels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant5AudioVariant2FormatJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant2Format Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha256 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant5AudioVariant2" /> class.
        /// </summary>
        /// <param name="bitsPerSample"></param>
        /// <param name="byteLength"></param>
        /// <param name="channels"></param>
        /// <param name="sampleRate"></param>
        /// <param name="sha256"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant5AudioVariant2(
            double bitsPerSample,
            int byteLength,
            int channels,
            int sampleRate,
            string sha256,
            global::OpenRouter.BatchObjectResultResponseBodyVariant5AudioVariant2Format format)
        {
            this.BitsPerSample = bitsPerSample;
            this.ByteLength = byteLength;
            this.Channels = channels;
            this.Format = format;
            this.SampleRate = sampleRate;
            this.Sha256 = sha256 ?? throw new global::System.ArgumentNullException(nameof(sha256));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant5AudioVariant2" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant5AudioVariant2()
        {
        }

    }
}