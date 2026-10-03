
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Pagination links
    /// </summary>
    public sealed partial class ModelsV2ListResponseLinks
    {
        /// <summary>
        /// URL of the next page, or null on the last page or when pagination was not requested<br/>
        /// Example: /api/v2/models?limit=500&amp;cursor=eyJ2IjoxLCJxIjoiYjVmMWE4MDEiLCJrIjpbIm9wZW5haS9ncHQtNCJdfQ
        /// </summary>
        /// <example>/api/v2/models?limit=500&amp;cursor=eyJ2IjoxLCJxIjoiYjVmMWE4MDEiLCJrIjpbIm9wZW5haS9ncHQtNCJdfQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsV2ListResponseLinks" /> class.
        /// </summary>
        /// <param name="next">
        /// URL of the next page, or null on the last page or when pagination was not requested<br/>
        /// Example: /api/v2/models?limit=500&amp;cursor=eyJ2IjoxLCJxIjoiYjVmMWE4MDEiLCJrIjpbIm9wZW5haS9ncHQtNCJdfQ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsV2ListResponseLinks(
            string? next)
        {
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsV2ListResponseLinks" /> class.
        /// </summary>
        public ModelsV2ListResponseLinks()
        {
        }

    }
}