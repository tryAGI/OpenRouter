
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Captured stdout and stderr for one command of a shell call, with its exit or timeout outcome.<br/>
    /// Example: {"outcome":{"exit_code":0,"type":"exit"},"stderr":"","stdout":"total 0\n"}
    /// </summary>
    public sealed partial class ShellCallOutputContent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ShellCallOutputContentOutcomeVariant1, global::OpenRouter.ShellCallOutputContentOutcomeVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.ShellCallOutputContentOutcomeVariant1, global::OpenRouter.ShellCallOutputContentOutcomeVariant2> Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stderr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stdout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallOutputContent" /> class.
        /// </summary>
        /// <param name="outcome"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShellCallOutputContent(
            global::OpenRouter.OneOf<global::OpenRouter.ShellCallOutputContentOutcomeVariant1, global::OpenRouter.ShellCallOutputContentOutcomeVariant2> outcome,
            string stderr,
            string stdout)
        {
            this.Outcome = outcome;
            this.Stderr = stderr ?? throw new global::System.ArgumentNullException(nameof(stderr));
            this.Stdout = stdout ?? throw new global::System.ArgumentNullException(nameof(stdout));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallOutputContent" /> class.
        /// </summary>
        public ShellCallOutputContent()
        {
        }

    }
}