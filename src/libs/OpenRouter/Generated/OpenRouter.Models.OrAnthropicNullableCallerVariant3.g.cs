
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// direct variant
    /// </summary>
    public sealed partial class OrAnthropicNullableCallerVariant3
    {
        /// <summary>
        /// Discriminator value: direct
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OrAnthropicNullableCallerVariant3TypeJsonConverter))]
        public global::OpenRouter.OrAnthropicNullableCallerVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrAnthropicNullableCallerVariant3" /> class.
        /// </summary>
        /// <param name="type">
        /// Discriminator value: direct
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrAnthropicNullableCallerVariant3(
            global::OpenRouter.OrAnthropicNullableCallerVariant3Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrAnthropicNullableCallerVariant3" /> class.
        /// </summary>
        public OrAnthropicNullableCallerVariant3()
        {
        }

    }
}