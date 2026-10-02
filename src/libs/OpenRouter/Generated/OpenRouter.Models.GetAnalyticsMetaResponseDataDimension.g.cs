
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsMetaResponseDataDimension
    {
        /// <summary>
        /// Human-readable label<br/>
        /// Example: Model
        /// </summary>
        /// <example>Model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayLabel { get; set; }

        /// <summary>
        /// Dimension identifier used in query requests<br/>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsMetaResponseDataDimension" /> class.
        /// </summary>
        /// <param name="displayLabel">
        /// Human-readable label<br/>
        /// Example: Model
        /// </param>
        /// <param name="name">
        /// Dimension identifier used in query requests<br/>
        /// Example: model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsMetaResponseDataDimension(
            string displayLabel,
            string name)
        {
            this.DisplayLabel = displayLabel ?? throw new global::System.ArgumentNullException(nameof(displayLabel));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsMetaResponseDataDimension" /> class.
        /// </summary>
        public GetAnalyticsMetaResponseDataDimension()
        {
        }

    }
}