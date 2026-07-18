
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Pagination links
    /// </summary>
    public sealed partial class ModelsListResponseLinks
    {
        /// <summary>
        /// URL for the next page of results, or null if this is the last page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponseLinks" /> class.
        /// </summary>
        /// <param name="next">
        /// URL for the next page of results, or null if this is the last page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsListResponseLinks(
            string? next)
        {
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponseLinks" /> class.
        /// </summary>
        public ModelsListResponseLinks()
        {
        }

    }
}