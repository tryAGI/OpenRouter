
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BaseInputsVariant2ItemContentVariant1ItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseInputsVariant2ItemContentVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsVariant2ItemContentVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseInputsVariant2ItemContentVariant1ItemDiscriminator(
            global::OpenRouter.BaseInputsVariant2ItemContentVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsVariant2ItemContentVariant1ItemDiscriminator" /> class.
        /// </summary>
        public BaseInputsVariant2ItemContentVariant1ItemDiscriminator()
        {
        }

    }
}