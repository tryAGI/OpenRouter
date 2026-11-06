
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content_filter_builtins":[{"action":"block","slug":"secrets"}]}
    /// </summary>
    public sealed partial class GuardrailModerationPolicyConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("armor")]
        public global::OpenRouter.GuardrailModerationPolicyConfigArmor? Armor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcast_model_armor_flagged_requests")]
        public bool? BroadcastModelArmorFlaggedRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter_blocks_requests")]
        public bool? ContentFilterBlocksRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter_builtins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltin>? ContentFilterBuiltins { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter_patterns")]
        public global::System.Collections.Generic.IList<string>? ContentFilterPatterns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigContentFilter>? ContentFilters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_model_armor_injection_protection")]
        public bool? EnableModelArmorInjectionProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lakera_injection_protection_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigLakeraInjectionProtectionModeJsonConverter))]
        public global::OpenRouter.GuardrailModerationPolicyConfigLakeraInjectionProtectionMode? LakeraInjectionProtectionMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_armor_injection_confidence_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigModelArmorInjectionConfidenceLevelJsonConverter))]
        public global::OpenRouter.GuardrailModerationPolicyConfigModelArmorInjectionConfidenceLevel? ModelArmorInjectionConfidenceLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_armor_injection_protection_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigModelArmorInjectionProtectionModeJsonConverter))]
        public global::OpenRouter.GuardrailModerationPolicyConfigModelArmorInjectionProtectionMode? ModelArmorInjectionProtectionMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_filters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigPiiFilter>? PiiFilters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_image_moderated_providers")]
        public global::System.Collections.Generic.IList<string>? PlatformImageModeratedProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_moderated_providers")]
        public global::System.Collections.Generic.IList<string>? PlatformModeratedProviders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfig" /> class.
        /// </summary>
        /// <param name="armor"></param>
        /// <param name="broadcastModelArmorFlaggedRequests"></param>
        /// <param name="contentFilterBlocksRequests"></param>
        /// <param name="contentFilterBuiltins"></param>
        /// <param name="contentFilterPatterns"></param>
        /// <param name="contentFilters"></param>
        /// <param name="enableModelArmorInjectionProtection"></param>
        /// <param name="lakeraInjectionProtectionMode"></param>
        /// <param name="modelArmorInjectionConfidenceLevel"></param>
        /// <param name="modelArmorInjectionProtectionMode"></param>
        /// <param name="piiFilters"></param>
        /// <param name="platformImageModeratedProviders"></param>
        /// <param name="platformModeratedProviders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailModerationPolicyConfig(
            global::OpenRouter.GuardrailModerationPolicyConfigArmor? armor,
            bool? broadcastModelArmorFlaggedRequests,
            bool? contentFilterBlocksRequests,
            global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltin>? contentFilterBuiltins,
            global::System.Collections.Generic.IList<string>? contentFilterPatterns,
            global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigContentFilter>? contentFilters,
            bool? enableModelArmorInjectionProtection,
            global::OpenRouter.GuardrailModerationPolicyConfigLakeraInjectionProtectionMode? lakeraInjectionProtectionMode,
            global::OpenRouter.GuardrailModerationPolicyConfigModelArmorInjectionConfidenceLevel? modelArmorInjectionConfidenceLevel,
            global::OpenRouter.GuardrailModerationPolicyConfigModelArmorInjectionProtectionMode? modelArmorInjectionProtectionMode,
            global::System.Collections.Generic.IList<global::OpenRouter.GuardrailModerationPolicyConfigPiiFilter>? piiFilters,
            global::System.Collections.Generic.IList<string>? platformImageModeratedProviders,
            global::System.Collections.Generic.IList<string>? platformModeratedProviders)
        {
            this.Armor = armor;
            this.BroadcastModelArmorFlaggedRequests = broadcastModelArmorFlaggedRequests;
            this.ContentFilterBlocksRequests = contentFilterBlocksRequests;
            this.ContentFilterBuiltins = contentFilterBuiltins;
            this.ContentFilterPatterns = contentFilterPatterns;
            this.ContentFilters = contentFilters;
            this.EnableModelArmorInjectionProtection = enableModelArmorInjectionProtection;
            this.LakeraInjectionProtectionMode = lakeraInjectionProtectionMode;
            this.ModelArmorInjectionConfidenceLevel = modelArmorInjectionConfidenceLevel;
            this.ModelArmorInjectionProtectionMode = modelArmorInjectionProtectionMode;
            this.PiiFilters = piiFilters;
            this.PlatformImageModeratedProviders = platformImageModeratedProviders;
            this.PlatformModeratedProviders = platformModeratedProviders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfig" /> class.
        /// </summary>
        public GuardrailModerationPolicyConfig()
        {
        }

    }
}