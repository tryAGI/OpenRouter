
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems
    {
        /// <summary>
        /// Error message describing why the model failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Slug of the analysis model that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// HTTP status code from the upstream response, when available (e.g. 402, 429).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems" /> class.
        /// </summary>
        /// <param name="error">
        /// Error message describing why the model failed.
        /// </param>
        /// <param name="model">
        /// Slug of the analysis model that failed.
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code from the upstream response, when available (e.g. 402, 429).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems(
            string error,
            string model,
            int? statusCode)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems" /> class.
        /// </summary>
        public OutputItemsDiscriminatorMappingOpenrouterFusionFailedModelsItems()
        {
        }

    }
}