
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Selected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SortRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_value")]
        public double? SortValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointInfo" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="selected"></param>
        /// <param name="sortRank"></param>
        /// <param name="sortValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointInfo(
            string model,
            string provider,
            bool selected,
            int sortRank,
            double? sortValue)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Selected = selected;
            this.SortRank = sortRank;
            this.SortValue = sortValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointInfo" /> class.
        /// </summary>
        public EndpointInfo()
        {
        }
    }
}