
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppRankingsItem
    {
        /// <summary>
        /// Stable numeric identifier of the app on OpenRouter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// Public display name of the app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// 1-based position of the app within this response, per the requested `sort`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// Number of requests attributed to the app inside the date window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequests { get; set; }

        /// <summary>
        /// Sum of `prompt_tokens + completion_tokens` attributed to the app inside the date window, returned as a decimal string so 64-bit values are not truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRankingsItem" /> class.
        /// </summary>
        /// <param name="appId">
        /// Stable numeric identifier of the app on OpenRouter.
        /// </param>
        /// <param name="appName">
        /// Public display name of the app.
        /// </param>
        /// <param name="rank">
        /// 1-based position of the app within this response, per the requested `sort`.
        /// </param>
        /// <param name="totalRequests">
        /// Number of requests attributed to the app inside the date window.
        /// </param>
        /// <param name="totalTokens">
        /// Sum of `prompt_tokens + completion_tokens` attributed to the app inside the date window, returned as a decimal string so 64-bit values are not truncated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppRankingsItem(
            int appId,
            string appName,
            int rank,
            int totalRequests,
            string totalTokens)
        {
            this.AppId = appId;
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.Rank = rank;
            this.TotalRequests = totalRequests;
            this.TotalTokens = totalTokens ?? throw new global::System.ArgumentNullException(nameof(totalTokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRankingsItem" /> class.
        /// </summary>
        public AppRankingsItem()
        {
        }

    }
}