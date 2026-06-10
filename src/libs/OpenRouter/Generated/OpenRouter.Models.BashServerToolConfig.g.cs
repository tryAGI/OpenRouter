
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:bash server tool
    /// </summary>
    public sealed partial class BashServerToolConfig
    {
        /// <summary>
        /// Which bash engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) and "native" use native passthrough, returning the tool call to your application to run client-side; OpenRouter does not execute the commands.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BashServerToolEngineJsonConverter))]
        public global::OpenRouter.BashServerToolEngine? Engine { get; set; }

        /// <summary>
        /// Execution environment for the bash server tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BashServerToolEnvironmentJsonConverter))]
        public global::OpenRouter.BashServerToolEnvironment? Environment { get; set; }

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
        /// Initializes a new instance of the <see cref="BashServerToolConfig" /> class.
        /// </summary>
        /// <param name="engine">
        /// Which bash engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) and "native" use native passthrough, returning the tool call to your application to run client-side; OpenRouter does not execute the commands.
        /// </param>
        /// <param name="environment">
        /// Execution environment for the bash server tool.
        /// </param>
        /// <param name="sleepAfterSeconds">
        /// How long (in seconds) the container stays warm after its last command before sleeping, freeing its capacity slot. Idle-based: each command renews the timer. Defaults to 900 (15 minutes); capped at 2592000 (30 days).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BashServerToolConfig(
            global::OpenRouter.BashServerToolEngine? engine,
            global::OpenRouter.BashServerToolEnvironment? environment,
            int? sleepAfterSeconds)
        {
            this.Engine = engine;
            this.Environment = environment;
            this.SleepAfterSeconds = sleepAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashServerToolConfig" /> class.
        /// </summary>
        public BashServerToolConfig()
        {
        }

    }
}