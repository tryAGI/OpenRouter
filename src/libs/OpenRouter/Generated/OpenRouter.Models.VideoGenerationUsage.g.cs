
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Usage and cost information for the video generation. Available once the job has completed.
    /// </summary>
    public sealed partial class VideoGenerationUsage
    {
        /// <summary>
        /// The cost of the video generation in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Whether the request was made using a Bring Your Own Key configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationUsage" /> class.
        /// </summary>
        /// <param name="cost">
        /// The cost of the video generation in USD.
        /// </param>
        /// <param name="isByok">
        /// Whether the request was made using a Bring Your Own Key configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationUsage(
            double? cost,
            bool? isByok)
        {
            this.Cost = cost;
            this.IsByok = isByok;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationUsage" /> class.
        /// </summary>
        public VideoGenerationUsage()
        {
        }
    }
}