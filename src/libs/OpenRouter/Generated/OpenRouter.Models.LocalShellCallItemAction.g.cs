
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalShellCallItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.LocalShellCallItemActionTypeJsonConverter))]
        public global::OpenRouter.LocalShellCallItemActionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellCallItemAction" /> class.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="env"></param>
        /// <param name="timeoutMs"></param>
        /// <param name="type"></param>
        /// <param name="user"></param>
        /// <param name="workingDirectory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalShellCallItemAction(
            global::System.Collections.Generic.IList<string> command,
            global::System.Collections.Generic.Dictionary<string, string> env,
            int? timeoutMs,
            global::OpenRouter.LocalShellCallItemActionType type,
            string? user,
            string? workingDirectory)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.TimeoutMs = timeoutMs;
            this.Type = type;
            this.User = user;
            this.WorkingDirectory = workingDirectory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellCallItemAction" /> class.
        /// </summary>
        public LocalShellCallItemAction()
        {
        }

    }
}