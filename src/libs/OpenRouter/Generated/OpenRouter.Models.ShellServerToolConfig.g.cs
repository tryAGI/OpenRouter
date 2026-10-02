
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:shell server tool<br/>
    /// Example: {"engine":"openrouter","environment":{"type":"container_auto"}}
    /// </summary>
    public sealed partial class ShellServerToolConfig
    {
        /// <summary>
        /// Which shell engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) keeps the provider's native hosted shell when available (OpenAI); on other providers the call is routed to the OpenRouter sandbox.<br/>
        /// Example: openrouter
        /// </summary>
        /// <example>openrouter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellServerToolEngineJsonConverter))]
        public global::OpenRouter.ShellServerToolEngine? Engine { get; set; }

        /// <summary>
        /// Server-side execution environment for the shell tool. Only container-backed environments are supported; "local" shells are not.<br/>
        /// Example: {"type":"container_auto"}
        /// </summary>
        /// <example>{"type":"container_auto"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellServerToolEnvironmentJsonConverter))]
        public global::OpenRouter.ShellServerToolEnvironment? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolConfig" /> class.
        /// </summary>
        /// <param name="engine">
        /// Which shell engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) keeps the provider's native hosted shell when available (OpenAI); on other providers the call is routed to the OpenRouter sandbox.<br/>
        /// Example: openrouter
        /// </param>
        /// <param name="environment">
        /// Server-side execution environment for the shell tool. Only container-backed environments are supported; "local" shells are not.<br/>
        /// Example: {"type":"container_auto"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShellServerToolConfig(
            global::OpenRouter.ShellServerToolEngine? engine,
            global::OpenRouter.ShellServerToolEnvironment? environment)
        {
            this.Engine = engine;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellServerToolConfig" /> class.
        /// </summary>
        public ShellServerToolConfig()
        {
        }

    }
}