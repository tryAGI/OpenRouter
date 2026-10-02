
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"app_id":12345,"app_name":"Cline","rank":1,"total_requests":4321,"total_tokens":"12345678"}
    /// </summary>
    public sealed partial class AppRankingsItem
    {
        /// <summary>
        /// Stable numeric identifier of the app on OpenRouter.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// Public display name of the app.<br/>
        /// Example: Cline
        /// </summary>
        /// <example>Cline</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// 1-based position of the app within this response, per the requested `sort`.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// Number of requests attributed to the app inside the date window.<br/>
        /// Example: 4321
        /// </summary>
        /// <example>4321</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequests { get; set; }

        /// <summary>
        /// Sum of `prompt_tokens + completion_tokens` attributed to the app inside the date window, returned as a decimal string so 64-bit values are not truncated.<br/>
        /// Example: 12345678
        /// </summary>
        /// <example>12345678</example>
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
        /// Stable numeric identifier of the app on OpenRouter.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="appName">
        /// Public display name of the app.<br/>
        /// Example: Cline
        /// </param>
        /// <param name="rank">
        /// 1-based position of the app within this response, per the requested `sort`.<br/>
        /// Example: 1
        /// </param>
        /// <param name="totalRequests">
        /// Number of requests attributed to the app inside the date window.<br/>
        /// Example: 4321
        /// </param>
        /// <param name="totalTokens">
        /// Sum of `prompt_tokens + completion_tokens` attributed to the app inside the date window, returned as a decimal string so 64-bit values are not truncated.<br/>
        /// Example: 12345678
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