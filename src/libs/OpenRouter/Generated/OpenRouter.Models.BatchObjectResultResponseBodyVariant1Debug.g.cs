
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1Debug
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo_upstream_body")]
        public object? EchoUpstreamBody { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timings")]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimings? Timings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1Debug" /> class.
        /// </summary>
        /// <param name="echoUpstreamBody"></param>
        /// <param name="timings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1Debug(
            object? echoUpstreamBody,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1DebugTimings? timings)
        {
            this.EchoUpstreamBody = echoUpstreamBody;
            this.Timings = timings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1Debug" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1Debug()
        {
        }

    }
}