
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant3Usage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? Iterations { get; set; }

        /// <summary>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicSpeedJsonConverter))]
        public global::OpenRouter.AnthropicSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant3Usage" /> class.
        /// </summary>
        /// <param name="iterations"></param>
        /// <param name="speed">
        /// Example: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant3Usage(
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>? iterations,
            global::OpenRouter.AnthropicSpeed? speed)
        {
            this.Iterations = iterations;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant3Usage" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant3Usage()
        {
        }

    }
}