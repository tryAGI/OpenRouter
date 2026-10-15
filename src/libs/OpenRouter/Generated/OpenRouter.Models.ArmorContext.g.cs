
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The Armor context: Claude Code's `classifier_context` (v1), with `auto_mode.{hard_deny,soft_deny,allow}` rules as strings or `{ id, instructions, threshold? }` objects and `auto_mode.environment` entries as `"Name: value"` strings or `{ name, value }` objects. `threshold` applies when Armor evaluates; when the provider evaluates natively (Anthropic dangerous-tool-use beta) rules are judged at the provider's own boundary.<br/>
    /// Example: {"auto_mode":{"allow":[],"environment":["Trusted repo: github.com/acme/app"],"hard_deny":[],"soft_deny":[{"id":"secrets-in-vcs","instructions":"Staging, committing or pushing a file that holds secrets, including indirectly through git add -A when the tree shows one."}]},"v":1}
    /// </summary>
    public sealed partial class ArmorContext
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode")]
        public global::OpenRouter.ArmorAutoMode? AutoMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double V { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorContext" /> class.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="autoMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArmorContext(
            double v,
            global::OpenRouter.ArmorAutoMode? autoMode)
        {
            this.AutoMode = autoMode;
            this.V = v;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArmorContext" /> class.
        /// </summary>
        public ArmorContext()
        {
        }

    }
}