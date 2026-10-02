
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnthropicAdvisorMessageUsageIterationVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicAdvisorMessageUsageIterationVariant2TypeJsonConverter))]
        public global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicAdvisorMessageUsageIterationVariant2" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicAdvisorMessageUsageIterationVariant2(
            string model,
            global::OpenRouter.AnthropicAdvisorMessageUsageIterationVariant2Type type)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicAdvisorMessageUsageIterationVariant2" /> class.
        /// </summary>
        public AnthropicAdvisorMessageUsageIterationVariant2()
        {
        }

    }
}