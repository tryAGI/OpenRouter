
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// List of available models
    /// </summary>
    public sealed partial class ModelsListResponse
    {
        /// <summary>
        /// List of available models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Model> Data { get; set; }

        /// <summary>
        /// Pagination links
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelsListResponseLinks Links { get; set; }

        /// <summary>
        /// Total number of models matching the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of available models
        /// </param>
        /// <param name="links">
        /// Pagination links
        /// </param>
        /// <param name="totalCount">
        /// Total number of models matching the query
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.Model> data,
            global::OpenRouter.ModelsListResponseLinks links,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        public ModelsListResponse()
        {
        }

    }
}