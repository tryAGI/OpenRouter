
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:bash server tool<br/>
    /// Example: {"environment":{"type":"container_auto"}}
    /// </summary>
    public sealed partial class BashServerToolConfig
    {
        /// <summary>
        /// Which bash engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) and "native" use native passthrough, returning the tool call to your application to run client-side; OpenRouter does not execute the commands.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BashServerToolEngineJsonConverter))]
        public global::OpenRouter.BashServerToolEngine? Engine { get; set; }

        /// <summary>
        /// Execution environment for the bash server tool.<br/>
        /// Example: {"type":"container_auto"}
        /// </summary>
        /// <example>{"type":"container_auto"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BashServerToolEnvironmentJsonConverter))]
        public global::OpenRouter.BashServerToolEnvironment? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BashServerToolConfig" /> class.
        /// </summary>
        /// <param name="engine">
        /// Which bash engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) and "native" use native passthrough, returning the tool call to your application to run client-side; OpenRouter does not execute the commands.<br/>
        /// Example: auto
        /// </param>
        /// <param name="environment">
        /// Execution environment for the bash server tool.<br/>
        /// Example: {"type":"container_auto"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BashServerToolConfig(
            global::OpenRouter.BashServerToolEngine? engine,
            global::OpenRouter.BashServerToolEnvironment? environment)
        {
            this.Engine = engine;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashServerToolConfig" /> class.
        /// </summary>
        public BashServerToolConfig()
        {
        }

    }
}