
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"date":"2026-05-11","model_permaslug":"openai/gpt-4o-2024-05-13","total_tokens":"12345678"}
    /// </summary>
    public sealed partial class RankingsDailyItem
    {
        /// <summary>
        /// UTC calendar date the row is aggregated over (YYYY-MM-DD).<br/>
        /// Example: 2026-05-11
        /// </summary>
        /// <example>2026-05-11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Model variant permaslug (e.g. `openai/gpt-4o-2024-05-13`, `openai/gpt-4o-2024-05-13:free`). Non-default variants include a `:variant` suffix and are ranked as their own entry. The reserved value `other` denotes the aggregated row covering every model outside the daily top 50 for that date — always sorted last within its date.<br/>
        /// Example: openai/gpt-4o-2024-05-13
        /// </summary>
        /// <example>openai/gpt-4o-2024-05-13</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Sum of `prompt_tokens + completion_tokens` for the day, returned as a decimal string so 64-bit values are not truncated.<br/>
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
        /// Initializes a new instance of the <see cref="RankingsDailyItem" /> class.
        /// </summary>
        /// <param name="date">
        /// UTC calendar date the row is aggregated over (YYYY-MM-DD).<br/>
        /// Example: 2026-05-11
        /// </param>
        /// <param name="modelPermaslug">
        /// Model variant permaslug (e.g. `openai/gpt-4o-2024-05-13`, `openai/gpt-4o-2024-05-13:free`). Non-default variants include a `:variant` suffix and are ranked as their own entry. The reserved value `other` denotes the aggregated row covering every model outside the daily top 50 for that date — always sorted last within its date.<br/>
        /// Example: openai/gpt-4o-2024-05-13
        /// </param>
        /// <param name="totalTokens">
        /// Sum of `prompt_tokens + completion_tokens` for the day, returned as a decimal string so 64-bit values are not truncated.<br/>
        /// Example: 12345678
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankingsDailyItem(
            string date,
            string modelPermaslug,
            string totalTokens)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.TotalTokens = totalTokens ?? throw new global::System.ArgumentNullException(nameof(totalTokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsDailyItem" /> class.
        /// </summary>
        public RankingsDailyItem()
        {
        }

    }
}