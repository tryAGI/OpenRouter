
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionsResponse
    {
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
        /// The text that spans index into, when requested through provider options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_text")]
        public string? StateText { get; set; }

        /// <summary>
        /// True when the provider read only a prefix of the state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        public bool? Truncated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ExtractionsUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionsResponse" /> class.
        /// </summary>
        /// <param name="answers"></param>
        /// <param name="model"></param>
        /// <param name="usage"></param>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <param name="stateText">
        /// The text that spans index into, when requested through provider options.
        /// </param>
        /// <param name="truncated">
        /// True when the provider read only a prefix of the state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionsResponse(
            object answers,
            string model,
            global::OpenRouter.ExtractionsUsage usage,
            string? id,
            string? provider,
            string? stateText,
            bool? truncated)
        {
            this.Answers = answers ?? throw new global::System.ArgumentNullException(nameof(answers));
            this.Id = id;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.StateText = stateText;
            this.Truncated = truncated;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionsResponse" /> class.
        /// </summary>
        public ExtractionsResponse()
        {
        }

    }
}