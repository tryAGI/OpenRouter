
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecisionsResponse
    {
        /// <summary>
        /// Sources for the request as a whole, when the provider returns them. Not attributed to individual answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.DecisionsUrlCitationAnnotation>? Annotations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Answers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        public string? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DecisionsResponseUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsResponse" /> class.
        /// </summary>
        /// <param name="answers"></param>
        /// <param name="model"></param>
        /// <param name="usage"></param>
        /// <param name="annotations">
        /// Sources for the request as a whole, when the provider returns them. Not attributed to individual answers.
        /// </param>
        /// <param name="id"></param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsResponse(
            object answers,
            string model,
            global::OpenRouter.DecisionsResponseUsage usage,
            global::System.Collections.Generic.IList<global::OpenRouter.DecisionsUrlCitationAnnotation>? annotations,
            string? id,
            string? provider)
        {
            this.Annotations = annotations;
            this.Answers = answers ?? throw new global::System.ArgumentNullException(nameof(answers));
            this.Id = id;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsResponse" /> class.
        /// </summary>
        public DecisionsResponse()
        {
        }

    }
}