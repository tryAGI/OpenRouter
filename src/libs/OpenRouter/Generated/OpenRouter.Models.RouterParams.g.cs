
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RouterParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_floor")]
        public double? QualityFloor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throughput_floor")]
        public double? ThroughputFloor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_group")]
        public string? VersionGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterParams" /> class.
        /// </summary>
        /// <param name="qualityFloor"></param>
        /// <param name="throughputFloor"></param>
        /// <param name="versionGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouterParams(
            double? qualityFloor,
            double? throughputFloor,
            string? versionGroup)
        {
            this.QualityFloor = qualityFloor;
            this.ThroughputFloor = throughputFloor;
            this.VersionGroup = versionGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterParams" /> class.
        /// </summary>
        public RouterParams()
        {
        }

    }
}