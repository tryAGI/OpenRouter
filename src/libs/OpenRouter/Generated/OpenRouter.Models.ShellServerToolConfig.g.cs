
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:shell server tool
    /// </summary>
    public sealed partial class ShellServerToolConfig
    {
        /// <summary>
        /// Which shell engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) keeps the provider's native hosted shell when available (OpenAI); on other providers the call is routed to the OpenRouter sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellServerToolEngineJsonConverter))]
        public global::OpenRouter.ShellServerToolEngine? Engine { get; set; }

        /// <summary>
        /// Server-side execution environment for the shell tool. Only container-backed environments are supported; "local" shells are not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellServerToolEnvironmentJsonConverter))]
        public global::OpenRouter.ShellServerToolEnvironment? Environment { get; set; }

        /// <summary>
        /// How long (in seconds) the container stays warm after its last command before sleeping, freeing its capacity slot. Idle-based: each command renews the timer. Defaults to 900 (15 minutes); capped at 2592000 (30 days).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_after_seconds")]
        public int? SleepAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolConfig" /> class.
        /// </summary>
        /// <param name="engine">
        /// Which shell engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) keeps the provider's native hosted shell when available (OpenAI); on other providers the call is routed to the OpenRouter sandbox.
        /// </param>
        /// <param name="environment">
        /// Server-side execution environment for the shell tool. Only container-backed environments are supported; "local" shells are not.
        /// </param>
        /// <param name="sleepAfterSeconds">
        /// How long (in seconds) the container stays warm after its last command before sleeping, freeing its capacity slot. Idle-based: each command renews the timer. Defaults to 900 (15 minutes); capped at 2592000 (30 days).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShellServerToolConfig(
            global::OpenRouter.ShellServerToolEngine? engine,
            global::OpenRouter.ShellServerToolEnvironment? environment,
            int? sleepAfterSeconds)
        {
            this.Engine = engine;
            this.Environment = environment;
            this.SleepAfterSeconds = sleepAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolConfig" /> class.
        /// </summary>
        public ShellServerToolConfig()
        {
        }

    }
}