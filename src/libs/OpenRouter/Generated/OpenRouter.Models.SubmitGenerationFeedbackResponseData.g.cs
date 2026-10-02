
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitGenerationFeedbackResponseData
    {
        /// <summary>
        /// Whether the feedback was recorded<br/>
        /// Example: true
        /// </summary>
        /// <default>true</default>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitGenerationFeedbackResponseData" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the feedback was recorded<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitGenerationFeedbackResponseData(
            bool success = true)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitGenerationFeedbackResponseData" /> class.
        /// </summary>
        public SubmitGenerationFeedbackResponseData()
        {
        }

    }
}