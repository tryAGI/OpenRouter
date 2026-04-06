
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Related API endpoints and resources for this model.
    /// </summary>
    public sealed partial class ModelLinks
    {
        /// <summary>
        /// URL for the model details/endpoints API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelLinks" /> class.
        /// </summary>
        /// <param name="details">
        /// URL for the model details/endpoints API
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelLinks(
            string details)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelLinks" /> class.
        /// </summary>
        public ModelLinks()
        {
        }
    }
}