
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsMetaResponseDataGranularitie
    {
        /// <summary>
        /// Human-readable label<br/>
        /// Example: Day
        /// </summary>
        /// <example>Day</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayLabel { get; set; }

        /// <summary>
        /// Granularity identifier<br/>
        /// Example: day
        /// </summary>
        /// <example>day</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GetAnalyticsMetaResponseDataGranularitieNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GetAnalyticsMetaResponseDataGranularitieName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsMetaResponseDataGranularitie" /> class.
        /// </summary>
        /// <param name="displayLabel">
        /// Human-readable label<br/>
        /// Example: Day
        /// </param>
        /// <param name="name">
        /// Granularity identifier<br/>
        /// Example: day
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsMetaResponseDataGranularitie(
            string displayLabel,
            global::OpenRouter.GetAnalyticsMetaResponseDataGranularitieName name)
        {
            this.DisplayLabel = displayLabel ?? throw new global::System.ArgumentNullException(nameof(displayLabel));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsMetaResponseDataGranularitie" /> class.
        /// </summary>
        public GetAnalyticsMetaResponseDataGranularitie()
        {
        }

    }
}