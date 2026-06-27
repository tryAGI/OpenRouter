
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A web page retrieved via web search during a fusion run.
    /// </summary>
    public sealed partial class FusionSource
    {
        /// <summary>
        /// Title of the retrieved web page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// URL of the web page a panel or the judge retrieved during the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionSource" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the retrieved web page.
        /// </param>
        /// <param name="url">
        /// URL of the web page a panel or the judge retrieved during the run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionSource(
            string title,
            string url)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionSource" /> class.
        /// </summary>
        public FusionSource()
        {
        }

    }
}