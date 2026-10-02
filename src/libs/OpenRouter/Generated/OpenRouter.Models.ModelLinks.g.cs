
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Related API endpoints and resources for this model.<br/>
    /// Example: {"details":"/api/v1/models/openai/gpt-5.4/endpoints"}
    /// </summary>
    public sealed partial class ModelLinks
    {
        /// <summary>
        /// URL for the model details/endpoints API<br/>
        /// Example: /api/v1/models/openai/gpt-5.4/endpoints
        /// </summary>
        /// <example>/api/v1/models/openai/gpt-5.4/endpoints</example>
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
        /// URL for the model details/endpoints API<br/>
        /// Example: /api/v1/models/openai/gpt-5.4/endpoints
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