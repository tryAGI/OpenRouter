
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BaseInputsVariant2Item2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>, string> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1?, global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2?, object>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1?, global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2?, object>? Phase { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.BaseInputsVariant2ItemRoleVariant1?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant2?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant3?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant4?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2ItemRoleVariant1?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant2?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant3?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant4?> Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseInputsVariant2ItemTypeJsonConverter))]
        public global::OpenRouter.BaseInputsVariant2ItemType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsVariant2Item2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="phase"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseInputsVariant2Item2(
            global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<global::OpenRouter.ContentVariant1Item>, string> content,
            global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2ItemRoleVariant1?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant2?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant3?, global::OpenRouter.BaseInputsVariant2ItemRoleVariant4?> role,
            global::OpenRouter.AnyOf<global::OpenRouter.BaseInputsVariant2ItemPhaseVariant1?, global::OpenRouter.BaseInputsVariant2ItemPhaseVariant2?, object>? phase,
            global::OpenRouter.BaseInputsVariant2ItemType? type)
        {
            this.Content = content;
            this.Phase = phase;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsVariant2Item2" /> class.
        /// </summary>
        public BaseInputsVariant2Item2()
        {
        }

    }
}