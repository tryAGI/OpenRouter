
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAnalyticsRequestFilter
    {
        /// <summary>
        /// Dimension to filter on. Use the /meta endpoint for available dimensions.<br/>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Include rows where the dimension has no value. Applies only to the `in` and `not_in` operators and dimensions that have an unset bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_unset")]
        public bool? IncludeUnset { get; set; }

        /// <summary>
        /// Filter operator<br/>
        /// Example: eq
        /// </summary>
        /// <example>eq</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Filter value (scalar or array depending on operator). Several dimensions are enriched in responses (returned as human-readable labels), but filters must use the underlying ID: `api_key_id` — numeric ID (from generation metadata) or key hash (64-char hex from GET /api/v1/keys, resolved server-side); `user` — Clerk user ID (e.g. "user_abc123"), not the display name; `workspace` — workspace UUID, not the workspace name (filtering or grouping by the account default workspace also covers activity recorded before workspace resolution existed, which is attributed to that default workspace); `app` — numeric app ID, not the app title; `model` — permaslug (e.g. "openai/gpt-4o"), not the display name. Other dimensions (provider, origin, country, etc.) are not enriched and accept the value as returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, double?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// Dimension to filter on. Use the /meta endpoint for available dimensions.<br/>
        /// Example: model
        /// </param>
        /// <param name="operator">
        /// Filter operator<br/>
        /// Example: eq
        /// </param>
        /// <param name="value">
        /// Filter value (scalar or array depending on operator). Several dimensions are enriched in responses (returned as human-readable labels), but filters must use the underlying ID: `api_key_id` — numeric ID (from generation metadata) or key hash (64-char hex from GET /api/v1/keys, resolved server-side); `user` — Clerk user ID (e.g. "user_abc123"), not the display name; `workspace` — workspace UUID, not the workspace name (filtering or grouping by the account default workspace also covers activity recorded before workspace resolution existed, which is attributed to that default workspace); `app` — numeric app ID, not the app title; `model` — permaslug (e.g. "openai/gpt-4o"), not the display name. Other dimensions (provider, origin, country, etc.) are not enriched and accept the value as returned.
        /// </param>
        /// <param name="includeUnset">
        /// Include rows where the dimension has no value. Applies only to the `in` and `not_in` operators and dimensions that have an unset bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAnalyticsRequestFilter(
            string field,
            string @operator,
            global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>> value,
            bool? includeUnset)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.IncludeUnset = includeUnset;
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestFilter" /> class.
        /// </summary>
        public QueryAnalyticsRequestFilter()
        {
        }

    }
}