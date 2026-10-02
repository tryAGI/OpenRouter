
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"app_id":12345,"app_name":"Cline","rank":1,"total_requests":4321,"total_tokens":"12345678"},{"app_id":67890,"app_name":"Roo Code","rank":2,"total_requests":2109,"total_tokens":"9876543"}],"meta":{"as_of":"2026-05-12T02:00:00.000Z","end_date":"2026-05-11","start_date":"2026-04-12","version":"v1"}}
    /// </summary>
    public sealed partial class AppRankingsResponse
    {
        /// <summary>
        /// Apps ranked per the requested `sort`, re-numbered 1..N after category filtering. `popular` sorts by `total_tokens` descending; `trending` sorts by absolute excess token growth descending and may return fewer than `limit` rows when few apps are growing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AppRankingsItem> Data { get; set; }

        /// <summary>
        /// Example: {"as_of":"2026-05-12T02:00:00.000Z","end_date":"2026-05-11","start_date":"2026-04-12","version":"v1"}
        /// </summary>
        /// <example>{"as_of":"2026-05-12T02:00:00.000Z","end_date":"2026-05-11","start_date":"2026-04-12","version":"v1"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.RankingsDailyMeta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRankingsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Apps ranked per the requested `sort`, re-numbered 1..N after category filtering. `popular` sorts by `total_tokens` descending; `trending` sorts by absolute excess token growth descending and may return fewer than `limit` rows when few apps are growing.
        /// </param>
        /// <param name="meta">
        /// Example: {"as_of":"2026-05-12T02:00:00.000Z","end_date":"2026-05-11","start_date":"2026-04-12","version":"v1"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppRankingsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.AppRankingsItem> data,
            global::OpenRouter.RankingsDailyMeta meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppRankingsResponse" /> class.
        /// </summary>
        public AppRankingsResponse()
        {
        }

    }
}