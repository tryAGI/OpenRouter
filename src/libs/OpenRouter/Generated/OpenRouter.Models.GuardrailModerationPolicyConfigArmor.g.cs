
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailModerationPolicyConfigArmor
    {
        /// <summary>
        /// The Armor context: Claude Code's `classifier_context` (v1), with `auto_mode.{hard_deny,soft_deny,allow}` rules as strings or `{ id, instructions, threshold? }` objects and `auto_mode.environment` entries as `"Name: value"` strings or `{ name, value }` objects. `threshold` applies when Armor evaluates; when the provider evaluates natively (Anthropic dangerous-tool-use beta) rules are judged at the provider's own boundary.<br/>
        /// Example: {"auto_mode":{"allow":[],"environment":["Trusted repo: github.com/acme/app"],"hard_deny":[],"soft_deny":[{"id":"secrets-in-vcs","instructions":"Staging, committing or pushing a file that holds secrets, including indirectly through git add -A when the tree shows one."}]},"v":1}
        /// </summary>
        /// <example>{"auto_mode":{"allow":[],"environment":["Trusted repo: github.com/acme/app"],"hard_deny":[],"soft_deny":[{"id":"secrets-in-vcs","instructions":"Staging, committing or pushing a file that holds secrets, including indirectly through git add -A when the tree shows one."}]},"v":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_context")]
        public global::OpenRouter.ArmorContext? ClassifierContext { get; set; }

        /// <summary>
        /// `enforce` withholds blocked calls; `audit` evaluates and reports the same verdicts without withholding any calls, regardless of `on_error`. Default `enforce`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigArmorModeJsonConverter))]
        public global::OpenRouter.GuardrailModerationPolicyConfigArmorMode? Mode { get; set; }

        /// <summary>
        /// When the classifier cannot answer (timeout, upstream error, context too long) the call is reported `unavailable`; `block` rejects it and `log` releases it. Default `block`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigArmorOnErrorJsonConverter))]
        public global::OpenRouter.GuardrailModerationPolicyConfigArmorOnError? OnError { get; set; }

        /// <summary>
        /// Prepend Claude Code's built-in auto-mode rule set (1 hard-deny, 72 soft-deny, 17 allow, 21 environment slots) ahead of every configured rule. Defaults to true on the Anthropic Messages API and false elsewhere.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cc_style_default_rules")]
        public bool? UseCcStyleDefaultRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfigArmor" /> class.
        /// </summary>
        /// <param name="classifierContext">
        /// The Armor context: Claude Code's `classifier_context` (v1), with `auto_mode.{hard_deny,soft_deny,allow}` rules as strings or `{ id, instructions, threshold? }` objects and `auto_mode.environment` entries as `"Name: value"` strings or `{ name, value }` objects. `threshold` applies when Armor evaluates; when the provider evaluates natively (Anthropic dangerous-tool-use beta) rules are judged at the provider's own boundary.<br/>
        /// Example: {"auto_mode":{"allow":[],"environment":["Trusted repo: github.com/acme/app"],"hard_deny":[],"soft_deny":[{"id":"secrets-in-vcs","instructions":"Staging, committing or pushing a file that holds secrets, including indirectly through git add -A when the tree shows one."}]},"v":1}
        /// </param>
        /// <param name="mode">
        /// `enforce` withholds blocked calls; `audit` evaluates and reports the same verdicts without withholding any calls, regardless of `on_error`. Default `enforce`.
        /// </param>
        /// <param name="onError">
        /// When the classifier cannot answer (timeout, upstream error, context too long) the call is reported `unavailable`; `block` rejects it and `log` releases it. Default `block`.
        /// </param>
        /// <param name="useCcStyleDefaultRules">
        /// Prepend Claude Code's built-in auto-mode rule set (1 hard-deny, 72 soft-deny, 17 allow, 21 environment slots) ahead of every configured rule. Defaults to true on the Anthropic Messages API and false elsewhere.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailModerationPolicyConfigArmor(
            global::OpenRouter.ArmorContext? classifierContext,
            global::OpenRouter.GuardrailModerationPolicyConfigArmorMode? mode,
            global::OpenRouter.GuardrailModerationPolicyConfigArmorOnError? onError,
            bool? useCcStyleDefaultRules)
        {
            this.ClassifierContext = classifierContext;
            this.Mode = mode;
            this.OnError = onError;
            this.UseCcStyleDefaultRules = useCcStyleDefaultRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfigArmor" /> class.
        /// </summary>
        public GuardrailModerationPolicyConfigArmor()
        {
        }

    }
}