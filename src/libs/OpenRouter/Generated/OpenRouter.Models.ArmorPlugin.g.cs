
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Evaluates every client tool call the model emits against a rule stack (hard-deny, soft-deny, allow) before it reaches the caller. The stack merges the workspace guardrail, this plugin, and any Anthropic `safeguards`; on endpoints that support Anthropic's `dangerous-tool-use` beta the evaluation is native, elsewhere it is one decisions call per tool call. Evaluation is not billed during the beta. Verdicts are reported as `safeguard_results`.<br/>
    /// Example: {"classifier_context":{"auto_mode":{"environment":["Trusted repo: github.com/acme/app"],"soft_deny":[{"id":"no-migrations-delete","instructions":"Deleting a file under db/migrations."}]},"v":1},"id":"armor","use_cc_style_default_rules":true}
    /// </summary>
    public sealed partial class ArmorPlugin
    {
        /// <summary>
        /// The Armor context: Claude Code's `classifier_context` (v1), with `auto_mode.{hard_deny,soft_deny,allow}` rules as strings or `{ id, instructions, threshold? }` objects and `auto_mode.environment` entries as `"Name: value"` strings or `{ name, value }` objects. `threshold` applies when Armor evaluates; when the provider evaluates natively (Anthropic dangerous-tool-use beta) rules are judged at the provider's own boundary.<br/>
        /// Example: {"auto_mode":{"allow":[],"environment":["Trusted repo: github.com/acme/app"],"hard_deny":[],"soft_deny":[{"id":"secrets-in-vcs","instructions":"Staging, committing or pushing a file that holds secrets, including indirectly through git add -A when the tree shows one."}]},"v":1}
        /// </summary>
        /// <example>{"auto_mode":{"allow":[],"environment":["Trusted repo: github.com/acme/app"],"hard_deny":[],"soft_deny":[{"id":"secrets-in-vcs","instructions":"Staging, committing or pushing a file that holds secrets, including indirectly through git add -A when the tree shows one."}]},"v":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_context")]
        public global::OpenRouter.ArmorContext? ClassifierContext { get; set; }

        /// <summary>
        /// Set to false to disable Armor for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Run provider-native server tools (web search, code execution, ...) through the agent loop so Armor evaluates them too. Defaults to false: native passthrough stands and such calls are reported `skipped`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluate_native_tools")]
        public bool? EvaluateNativeTools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorPluginIdJsonConverter))]
        public global::OpenRouter.ArmorPluginId Id { get; set; }

        /// <summary>
        /// `enforce` withholds blocked calls; `audit` evaluates and reports the same verdicts without withholding any calls, regardless of `on_error`. Default `enforce`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorPluginModeJsonConverter))]
        public global::OpenRouter.ArmorPluginMode? Mode { get; set; }

        /// <summary>
        /// When the classifier cannot answer (timeout, upstream error, context too long) the call is reported `unavailable`; `block` rejects it and `log` releases it. Default `block`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorPluginOnErrorJsonConverter))]
        public global::OpenRouter.ArmorPluginOnError? OnError { get; set; }

        /// <summary>
        /// How a blocked call reaches the caller. `text` (the default): the call is withheld and an `&lt;openrouter_armor_blocked&gt;` marker stands in assistant text. `custom_item` (Responses API only): the call is withheld and an `openrouter:armor_blocked` output item carries its id, name, arguments and the rule that fired. `claude_code_compatibility` (Messages API only; the default when the request carries a `dangerous_tool_use` safeguard, i.e. the client speaks Claude Code's protocol): the `tool_use` stays in `content[]` and the verdict is `flagged` in `safeguard_results`, so the client withholds execution and writes the error tool result as under the native classifier. Under `text` and `custom_item` the model received a failure result in the loop and continued in the same request; under `claude_code_compatibility` the turn ends on the flagged call and the model continues on the next request, after the client's denial.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ArmorPluginOutputModeJsonConverter))]
        public global::OpenRouter.ArmorPluginOutputMode? OutputMode { get; set; }

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
        /// Initializes a new instance of the <see cref="ArmorPlugin" /> class.
        /// </summary>
        /// <param name="classifierContext">
        /// The Armor context: Claude Code's `classifier_context` (v1), with `auto_mode.{hard_deny,soft_deny,allow}` rules as strings or `{ id, instructions, threshold? }` objects and `auto_mode.environment` entries as `"Name: value"` strings or `{ name, value }` objects. `threshold` applies when Armor evaluates; when the provider evaluates natively (Anthropic dangerous-tool-use beta) rules are judged at the provider's own boundary.<br/>
        /// Example: {"auto_mode":{"allow":[],"environment":["Trusted repo: github.com/acme/app"],"hard_deny":[],"soft_deny":[{"id":"secrets-in-vcs","instructions":"Staging, committing or pushing a file that holds secrets, including indirectly through git add -A when the tree shows one."}]},"v":1}
        /// </param>
        /// <param name="enabled">
        /// Set to false to disable Armor for this request. Defaults to true.
        /// </param>
        /// <param name="evaluateNativeTools">
        /// Run provider-native server tools (web search, code execution, ...) through the agent loop so Armor evaluates them too. Defaults to false: native passthrough stands and such calls are reported `skipped`.
        /// </param>
        /// <param name="id"></param>
        /// <param name="mode">
        /// `enforce` withholds blocked calls; `audit` evaluates and reports the same verdicts without withholding any calls, regardless of `on_error`. Default `enforce`.
        /// </param>
        /// <param name="onError">
        /// When the classifier cannot answer (timeout, upstream error, context too long) the call is reported `unavailable`; `block` rejects it and `log` releases it. Default `block`.
        /// </param>
        /// <param name="outputMode">
        /// How a blocked call reaches the caller. `text` (the default): the call is withheld and an `&lt;openrouter_armor_blocked&gt;` marker stands in assistant text. `custom_item` (Responses API only): the call is withheld and an `openrouter:armor_blocked` output item carries its id, name, arguments and the rule that fired. `claude_code_compatibility` (Messages API only; the default when the request carries a `dangerous_tool_use` safeguard, i.e. the client speaks Claude Code's protocol): the `tool_use` stays in `content[]` and the verdict is `flagged` in `safeguard_results`, so the client withholds execution and writes the error tool result as under the native classifier. Under `text` and `custom_item` the model received a failure result in the loop and continued in the same request; under `claude_code_compatibility` the turn ends on the flagged call and the model continues on the next request, after the client's denial.
        /// </param>
        /// <param name="useCcStyleDefaultRules">
        /// Prepend Claude Code's built-in auto-mode rule set (1 hard-deny, 72 soft-deny, 17 allow, 21 environment slots) ahead of every configured rule. Defaults to true on the Anthropic Messages API and false elsewhere.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArmorPlugin(
            global::OpenRouter.ArmorContext? classifierContext,
            bool? enabled,
            bool? evaluateNativeTools,
            global::OpenRouter.ArmorPluginId id,
            global::OpenRouter.ArmorPluginMode? mode,
            global::OpenRouter.ArmorPluginOnError? onError,
            global::OpenRouter.ArmorPluginOutputMode? outputMode,
            bool? useCcStyleDefaultRules)
        {
            this.ClassifierContext = classifierContext;
            this.Enabled = enabled;
            this.EvaluateNativeTools = evaluateNativeTools;
            this.Id = id;
            this.Mode = mode;
            this.OnError = onError;
            this.OutputMode = outputMode;
            this.UseCcStyleDefaultRules = useCcStyleDefaultRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorPlugin" /> class.
        /// </summary>
        public ArmorPlugin()
        {
        }

    }
}