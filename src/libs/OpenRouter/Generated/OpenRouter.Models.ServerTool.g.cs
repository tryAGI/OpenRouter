
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerTool
    {
        /// <summary>
        /// Every spelling accepted in `tools[].type` for this tool, including the canonical `id`, and what the call surfaces as under each
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputName> Aliases { get; set; }

        /// <summary>
        /// The engine a request without `parameters.engine` (or with `engine: "auto"`) runs on; `native` applies where the endpoint runs the tool itself, otherwise `fallback_engine`. A request pinned to a data region skips either engine when its `data_regions` does not list that region. Null for a tool without an engine parameter<br/>
        /// Example: native
        /// </summary>
        /// <example>native</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_engine")]
        public string? DefaultEngine { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngine> Engines { get; set; }

        /// <summary>
        /// The engine an unpinned request runs on when `default_engine` is `native` and the endpoint does not run the tool itself; null when there is no fallback<br/>
        /// Example: exa
        /// </summary>
        /// <example>exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_engine")]
        public string? FallbackEngine { get; set; }

        /// <summary>
        /// Canonical `openrouter:*` name; the stable `tools[].type` on every API format in `supported_api_formats`<br/>
        /// Example: openrouter:web_search
        /// </summary>
        /// <example>openrouter:web_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// JSON Schema of the arguments the model emits when calling the tool<br/>
        /// Example: {"properties":{},"type":"object"}
        /// </summary>
        /// <example>{"properties":{},"type":"object"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// Example: Web search
        /// </summary>
        /// <example>Web search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Endpoints whose provider runs this tool itself during inference. Zero for tools no provider runs natively.<br/>
        /// Example: {"endpoint_count":18,"model_count":12}
        /// </summary>
        /// <example>{"endpoint_count":18,"model_count":12}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_support")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ServerToolNativeSupport NativeSupport { get; set; }

        /// <summary>
        /// JSON Schema of the result returned to the model; null when undeclared<br/>
        /// Example: {"properties":{},"type":"object"}
        /// </summary>
        /// <example>{"properties":{},"type":"object"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// JSON Schema for the caller-side `tools[].parameters` object<br/>
        /// Example: {"properties":{},"type":"object"}
        /// </summary>
        /// <example>{"properties":{},"type":"object"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ParametersSchema { get; set; }

        /// <summary>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ServerToolStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ServerToolStatus Status { get; set; }

        /// <summary>
        /// One sentence for cards and search results; never sent to a model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_api_formats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ServerToolSupportedApiFormat> SupportedApiFormats { get; set; }

        /// <summary>
        /// The description sent upstream as the function tool description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerTool" /> class.
        /// </summary>
        /// <param name="aliases">
        /// Every spelling accepted in `tools[].type` for this tool, including the canonical `id`, and what the call surfaces as under each
        /// </param>
        /// <param name="docsUrl"></param>
        /// <param name="engines"></param>
        /// <param name="id">
        /// Canonical `openrouter:*` name; the stable `tools[].type` on every API format in `supported_api_formats`<br/>
        /// Example: openrouter:web_search
        /// </param>
        /// <param name="inputSchema">
        /// JSON Schema of the arguments the model emits when calling the tool<br/>
        /// Example: {"properties":{},"type":"object"}
        /// </param>
        /// <param name="name">
        /// Example: Web search
        /// </param>
        /// <param name="nativeSupport">
        /// Endpoints whose provider runs this tool itself during inference. Zero for tools no provider runs natively.<br/>
        /// Example: {"endpoint_count":18,"model_count":12}
        /// </param>
        /// <param name="parametersSchema">
        /// JSON Schema for the caller-side `tools[].parameters` object<br/>
        /// Example: {"properties":{},"type":"object"}
        /// </param>
        /// <param name="status">
        /// Example: active
        /// </param>
        /// <param name="summary">
        /// One sentence for cards and search results; never sent to a model
        /// </param>
        /// <param name="supportedApiFormats"></param>
        /// <param name="toolDescription">
        /// The description sent upstream as the function tool description
        /// </param>
        /// <param name="defaultEngine">
        /// The engine a request without `parameters.engine` (or with `engine: "auto"`) runs on; `native` applies where the endpoint runs the tool itself, otherwise `fallback_engine`. A request pinned to a data region skips either engine when its `data_regions` does not list that region. Null for a tool without an engine parameter<br/>
        /// Example: native
        /// </param>
        /// <param name="fallbackEngine">
        /// The engine an unpinned request runs on when `default_engine` is `native` and the endpoint does not run the tool itself; null when there is no fallback<br/>
        /// Example: exa
        /// </param>
        /// <param name="outputSchema">
        /// JSON Schema of the result returned to the model; null when undeclared<br/>
        /// Example: {"properties":{},"type":"object"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerTool(
            global::System.Collections.Generic.IList<global::OpenRouter.ServerToolInputName> aliases,
            string docsUrl,
            global::System.Collections.Generic.IList<global::OpenRouter.ServerToolEngine> engines,
            string id,
            object inputSchema,
            string name,
            global::OpenRouter.ServerToolNativeSupport nativeSupport,
            object parametersSchema,
            global::OpenRouter.ServerToolStatus status,
            string summary,
            global::System.Collections.Generic.IList<global::OpenRouter.ServerToolSupportedApiFormat> supportedApiFormats,
            string toolDescription,
            string? defaultEngine,
            string? fallbackEngine,
            object? outputSchema)
        {
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
            this.DefaultEngine = defaultEngine;
            this.DocsUrl = docsUrl ?? throw new global::System.ArgumentNullException(nameof(docsUrl));
            this.Engines = engines ?? throw new global::System.ArgumentNullException(nameof(engines));
            this.FallbackEngine = fallbackEngine;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NativeSupport = nativeSupport ?? throw new global::System.ArgumentNullException(nameof(nativeSupport));
            this.OutputSchema = outputSchema;
            this.ParametersSchema = parametersSchema ?? throw new global::System.ArgumentNullException(nameof(parametersSchema));
            this.Status = status;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.SupportedApiFormats = supportedApiFormats ?? throw new global::System.ArgumentNullException(nameof(supportedApiFormats));
            this.ToolDescription = toolDescription ?? throw new global::System.ArgumentNullException(nameof(toolDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerTool" /> class.
        /// </summary>
        public ServerTool()
        {
        }

    }
}