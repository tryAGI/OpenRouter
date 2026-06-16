
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FusionAnalysisResultPartialCoverageItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("point")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Point { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultPartialCoverageItems" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="point"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionAnalysisResultPartialCoverageItems(
            global::System.Collections.Generic.IList<string> models,
            string point)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Point = point ?? throw new global::System.ArgumentNullException(nameof(point));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionAnalysisResultPartialCoverageItems" /> class.
        /// </summary>
        public FusionAnalysisResultPartialCoverageItems()
        {
        }

    }
}