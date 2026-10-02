
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionCostMeta
    {
        /// <summary>
        /// ISO-8601 timestamp when the response was generated.<br/>
        /// Example: 2026-05-12T02:00:00.000Z
        /// </summary>
        /// <example>2026-05-12T02:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AsOf { get; set; }

        /// <summary>
        /// Dataset version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SessionCostMetaVersionJsonConverter))]
        public global::OpenRouter.SessionCostMetaVersion Version { get; set; }

        /// <summary>
        /// Number of days in the weekly session sample window, or null when no snapshot is published.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_days")]
        public int? WindowDays { get; set; }

        /// <summary>
        /// UTC date of the final day in the session sample window, or null when no snapshot is published.<br/>
        /// Example: 2026-05-11
        /// </summary>
        /// <example>2026-05-11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_end_date")]
        public string? WindowEndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCostMeta" /> class.
        /// </summary>
        /// <param name="asOf">
        /// ISO-8601 timestamp when the response was generated.<br/>
        /// Example: 2026-05-12T02:00:00.000Z
        /// </param>
        /// <param name="version">
        /// Dataset version.
        /// </param>
        /// <param name="windowDays">
        /// Number of days in the weekly session sample window, or null when no snapshot is published.<br/>
        /// Example: 30
        /// </param>
        /// <param name="windowEndDate">
        /// UTC date of the final day in the session sample window, or null when no snapshot is published.<br/>
        /// Example: 2026-05-11
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionCostMeta(
            string asOf,
            global::OpenRouter.SessionCostMetaVersion version,
            int? windowDays,
            string? windowEndDate)
        {
            this.AsOf = asOf ?? throw new global::System.ArgumentNullException(nameof(asOf));
            this.Version = version;
            this.WindowDays = windowDays;
            this.WindowEndDate = windowEndDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCostMeta" /> class.
        /// </summary>
        public SessionCostMeta()
        {
        }

    }
}