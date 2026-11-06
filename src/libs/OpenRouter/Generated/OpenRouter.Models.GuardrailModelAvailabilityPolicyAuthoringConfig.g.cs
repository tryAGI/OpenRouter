
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}
    /// </summary>
    public sealed partial class GuardrailModelAvailabilityPolicyAuthoringConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_safety_retention_google")]
        public bool? AllowSafetyRetentionGoogle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_safety_retention_other")]
        public bool? AllowSafetyRetentionOther { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_data_regions")]
        public global::System.Collections.Generic.IList<string>? AllowedDataRegions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_providers")]
        public global::System.Collections.Generic.IList<string>? AllowedProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_free_model_publication")]
        public bool? EnableFreeModelPublication { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_free_model_training")]
        public bool? EnableFreeModelTraining { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_paid_model_training")]
        public bool? EnablePaidModelTraining { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_first_party_harness_models")]
        public bool? EnforceFirstPartyHarnessModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr")]
        public bool? EnforceZdr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_anthropic")]
        public bool? EnforceZdrAnthropic { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_google")]
        public bool? EnforceZdrGoogle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_openai")]
        public bool? EnforceZdrOpenai { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_other")]
        public bool? EnforceZdrOther { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_xai")]
        public bool? EnforceZdrXai { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_models")]
        public global::System.Collections.Generic.IList<string>? IgnoredModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_providers")]
        public global::System.Collections.Generic.IList<string>? IgnoredProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_banned_authors")]
        public global::System.Collections.Generic.IList<string>? PlatformBannedAuthors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_banned_models")]
        public global::System.Collections.Generic.IList<string>? PlatformBannedModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_banned_providers")]
        public global::System.Collections.Generic.IList<string>? PlatformBannedProviders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_eu_data_region")]
        public bool? RequireEuDataRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModelAvailabilityPolicyAuthoringConfig" /> class.
        /// </summary>
        /// <param name="allowSafetyRetentionGoogle"></param>
        /// <param name="allowSafetyRetentionOther"></param>
        /// <param name="allowedDataRegions"></param>
        /// <param name="allowedModels"></param>
        /// <param name="allowedProviders"></param>
        /// <param name="enableFreeModelPublication"></param>
        /// <param name="enableFreeModelTraining"></param>
        /// <param name="enablePaidModelTraining"></param>
        /// <param name="enforceFirstPartyHarnessModels"></param>
        /// <param name="enforceZdr"></param>
        /// <param name="enforceZdrAnthropic"></param>
        /// <param name="enforceZdrGoogle"></param>
        /// <param name="enforceZdrOpenai"></param>
        /// <param name="enforceZdrOther"></param>
        /// <param name="enforceZdrXai"></param>
        /// <param name="ignoredModels"></param>
        /// <param name="ignoredProviders"></param>
        /// <param name="platformBannedAuthors"></param>
        /// <param name="platformBannedModels"></param>
        /// <param name="platformBannedProviders"></param>
        /// <param name="requireEuDataRegion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailModelAvailabilityPolicyAuthoringConfig(
            bool? allowSafetyRetentionGoogle,
            bool? allowSafetyRetentionOther,
            global::System.Collections.Generic.IList<string>? allowedDataRegions,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            bool? enableFreeModelPublication,
            bool? enableFreeModelTraining,
            bool? enablePaidModelTraining,
            bool? enforceFirstPartyHarnessModels,
            bool? enforceZdr,
            bool? enforceZdrAnthropic,
            bool? enforceZdrGoogle,
            bool? enforceZdrOpenai,
            bool? enforceZdrOther,
            bool? enforceZdrXai,
            global::System.Collections.Generic.IList<string>? ignoredModels,
            global::System.Collections.Generic.IList<string>? ignoredProviders,
            global::System.Collections.Generic.IList<string>? platformBannedAuthors,
            global::System.Collections.Generic.IList<string>? platformBannedModels,
            global::System.Collections.Generic.IList<string>? platformBannedProviders,
            bool? requireEuDataRegion)
        {
            this.AllowSafetyRetentionGoogle = allowSafetyRetentionGoogle;
            this.AllowSafetyRetentionOther = allowSafetyRetentionOther;
            this.AllowedDataRegions = allowedDataRegions;
            this.AllowedModels = allowedModels;
            this.AllowedProviders = allowedProviders;
            this.EnableFreeModelPublication = enableFreeModelPublication;
            this.EnableFreeModelTraining = enableFreeModelTraining;
            this.EnablePaidModelTraining = enablePaidModelTraining;
            this.EnforceFirstPartyHarnessModels = enforceFirstPartyHarnessModels;
            this.EnforceZdr = enforceZdr;
            this.EnforceZdrAnthropic = enforceZdrAnthropic;
            this.EnforceZdrGoogle = enforceZdrGoogle;
            this.EnforceZdrOpenai = enforceZdrOpenai;
            this.EnforceZdrOther = enforceZdrOther;
            this.EnforceZdrXai = enforceZdrXai;
            this.IgnoredModels = ignoredModels;
            this.IgnoredProviders = ignoredProviders;
            this.PlatformBannedAuthors = platformBannedAuthors;
            this.PlatformBannedModels = platformBannedModels;
            this.PlatformBannedProviders = platformBannedProviders;
            this.RequireEuDataRegion = requireEuDataRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModelAvailabilityPolicyAuthoringConfig" /> class.
        /// </summary>
        public GuardrailModelAvailabilityPolicyAuthoringConfig()
        {
        }

    }
}