
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// ELO range across all returned models for normalization.
    /// </summary>
    public sealed partial class BenchmarksDaMetaEloBounds
    {
        /// <summary>
        /// Maximum ELO in the result set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

        /// <summary>
        /// Minimum ELO in the result set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksDaMetaEloBounds" /> class.
        /// </summary>
        /// <param name="max">
        /// Maximum ELO in the result set.
        /// </param>
        /// <param name="min">
        /// Minimum ELO in the result set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BenchmarksDaMetaEloBounds(
            double max,
            double min)
        {
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarksDaMetaEloBounds" /> class.
        /// </summary>
        public BenchmarksDaMetaEloBounds()
        {
        }

    }
}