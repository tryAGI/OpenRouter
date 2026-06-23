
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskClassificationResponseData
    {
        /// <summary>
        /// UTC date (YYYY-MM-DD) of the window upper bound (yesterday). Data is exclusive of the current incomplete UTC day. This is the expected latest date in the snapshot; it does not confirm data presence for that date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AsOf { get; set; }

        /// <summary>
        /// Per-task classification market-share data, sorted by usage_share descending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationItem> Classifications { get; set; }

        /// <summary>
        /// Aggregate market-share data per macro-category (code, data, agent, general).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macro_categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationMacroCategory> MacroCategories { get; set; }

        /// <summary>
        /// Number of trailing days covered by this snapshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationResponseData" /> class.
        /// </summary>
        /// <param name="asOf">
        /// UTC date (YYYY-MM-DD) of the window upper bound (yesterday). Data is exclusive of the current incomplete UTC day. This is the expected latest date in the snapshot; it does not confirm data presence for that date.
        /// </param>
        /// <param name="classifications">
        /// Per-task classification market-share data, sorted by usage_share descending.
        /// </param>
        /// <param name="macroCategories">
        /// Aggregate market-share data per macro-category (code, data, agent, general).
        /// </param>
        /// <param name="windowDays">
        /// Number of trailing days covered by this snapshot.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskClassificationResponseData(
            string asOf,
            global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationItem> classifications,
            global::System.Collections.Generic.IList<global::OpenRouter.TaskClassificationMacroCategory> macroCategories,
            int windowDays)
        {
            this.AsOf = asOf ?? throw new global::System.ArgumentNullException(nameof(asOf));
            this.Classifications = classifications ?? throw new global::System.ArgumentNullException(nameof(classifications));
            this.MacroCategories = macroCategories ?? throw new global::System.ArgumentNullException(nameof(macroCategories));
            this.WindowDays = windowDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskClassificationResponseData" /> class.
        /// </summary>
        public TaskClassificationResponseData()
        {
        }

    }
}