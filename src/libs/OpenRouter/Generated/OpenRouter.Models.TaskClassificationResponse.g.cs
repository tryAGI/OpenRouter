
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"as_of":"2026-06-17","classifications":[{"category_token_share":0.48,"category_usage_share":0.51,"display_name":"Code Generation","macro_category":"code","models":[{"id":"openai/gpt-4.1-mini","tag_token_share":0.75,"tag_usage_share":0.55}],"tag":"code:general_impl","token_share":0.31,"usage_share":0.23}],"macro_categories":[{"key":"code","label":"Code","token_share":0.52,"usage_share":0.45}],"window_days":7}}
    /// </summary>
    public sealed partial class TaskClassificationResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.TaskClassificationResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskClassificationResponse(
            global::OpenRouter.TaskClassificationResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationResponse" /> class.
        /// </summary>
        public TaskClassificationResponse()
        {
        }

    }
}