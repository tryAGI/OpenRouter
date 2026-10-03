
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndpointDataPolicyV2
    {
        /// <summary>
        /// Whether the provider retains prompts; `false` is a zero-data-retention endpoint, as listed by `GET /api/v1/endpoints/zdr`<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retains_prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RetainsPrompts { get; set; }

        /// <summary>
        /// How long retained prompts are kept, when the provider states it<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Whether the provider may train on prompts sent to this endpoint<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("training")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Training { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointDataPolicyV2" /> class.
        /// </summary>
        /// <param name="retainsPrompts">
        /// Whether the provider retains prompts; `false` is a zero-data-retention endpoint, as listed by `GET /api/v1/endpoints/zdr`<br/>
        /// Example: false
        /// </param>
        /// <param name="training">
        /// Whether the provider may train on prompts sent to this endpoint<br/>
        /// Example: false
        /// </param>
        /// <param name="retentionDays">
        /// How long retained prompts are kept, when the provider states it<br/>
        /// Example: 30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointDataPolicyV2(
            bool retainsPrompts,
            bool training,
            int? retentionDays)
        {
            this.RetainsPrompts = retainsPrompts;
            this.RetentionDays = retentionDays;
            this.Training = training;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointDataPolicyV2" /> class.
        /// </summary>
        public EndpointDataPolicyV2()
        {
        }

    }
}