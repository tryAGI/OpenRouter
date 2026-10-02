
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListToolsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerTool> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ListToolsResponseLinks Links { get; set; }

        /// <summary>
        /// Total number of tools<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="links"></param>
        /// <param name="totalCount">
        /// Total number of tools<br/>
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListToolsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.ServerTool> data,
            global::OpenRouter.ListToolsResponseLinks links,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListToolsResponse" /> class.
        /// </summary>
        public ListToolsResponse()
        {
        }

    }
}