
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Enable SpaceXAI X (Twitter) search alongside native web search, with optional filters. Only applies to SpaceXAI endpoints with native search; omit to search the web only. X search is billed separately by SpaceXAI, per post and per user profile fetched.<br/>
    /// Example: {"allowed_x_handles":["OpenRouterAI"],"from_date":"2025-01-01"}
    /// </summary>
    public sealed partial class XSearchOptions
    {
        /// <summary>
        /// Only include posts from these X handles (max 20). Cannot be used with excluded_x_handles.<br/>
        /// Example: [OpenRouterAI]
        /// </summary>
        /// <example>[OpenRouterAI]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_x_handles")]
        public global::System.Collections.Generic.IList<string>? AllowedXHandles { get; set; }

        /// <summary>
        /// Analyze images attached to matching posts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_image_understanding")]
        public bool? EnableImageUnderstanding { get; set; }

        /// <summary>
        /// Analyze videos attached to matching posts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_video_understanding")]
        public bool? EnableVideoUnderstanding { get; set; }

        /// <summary>
        /// Exclude posts from these X handles (max 20). Cannot be used with allowed_x_handles.<br/>
        /// Example: [spamaccount]
        /// </summary>
        /// <example>[spamaccount]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_x_handles")]
        public global::System.Collections.Generic.IList<string>? ExcludedXHandles { get; set; }

        /// <summary>
        /// Start of the post date range (ISO 8601 date, e.g. "2025-01-01").<br/>
        /// Example: 2025-01-01
        /// </summary>
        /// <example>2025-01-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_date")]
        public global::System.DateTime? FromDate { get; set; }

        /// <summary>
        /// End of the post date range (ISO 8601 date, e.g. "2025-12-31").<br/>
        /// Example: 2025-12-31
        /// </summary>
        /// <example>2025-12-31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_date")]
        public global::System.DateTime? ToDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XSearchOptions" /> class.
        /// </summary>
        /// <param name="allowedXHandles">
        /// Only include posts from these X handles (max 20). Cannot be used with excluded_x_handles.<br/>
        /// Example: [OpenRouterAI]
        /// </param>
        /// <param name="enableImageUnderstanding">
        /// Analyze images attached to matching posts.
        /// </param>
        /// <param name="enableVideoUnderstanding">
        /// Analyze videos attached to matching posts.
        /// </param>
        /// <param name="excludedXHandles">
        /// Exclude posts from these X handles (max 20). Cannot be used with allowed_x_handles.<br/>
        /// Example: [spamaccount]
        /// </param>
        /// <param name="fromDate">
        /// Start of the post date range (ISO 8601 date, e.g. "2025-01-01").<br/>
        /// Example: 2025-01-01
        /// </param>
        /// <param name="toDate">
        /// End of the post date range (ISO 8601 date, e.g. "2025-12-31").<br/>
        /// Example: 2025-12-31
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XSearchOptions(
            global::System.Collections.Generic.IList<string>? allowedXHandles,
            bool? enableImageUnderstanding,
            bool? enableVideoUnderstanding,
            global::System.Collections.Generic.IList<string>? excludedXHandles,
            global::System.DateTime? fromDate,
            global::System.DateTime? toDate)
        {
            this.AllowedXHandles = allowedXHandles;
            this.EnableImageUnderstanding = enableImageUnderstanding;
            this.EnableVideoUnderstanding = enableVideoUnderstanding;
            this.ExcludedXHandles = excludedXHandles;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XSearchOptions" /> class.
        /// </summary>
        public XSearchOptions()
        {
        }

    }
}