
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
    /// </summary>
    public sealed partial class OpenRouterMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Attempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempts")]
        public global::System.Collections.Generic.IList<global::OpenRouter.RouterAttempt>? Attempts { get; set; }

        /// <summary>
        /// Example: {"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":3}
        /// </summary>
        /// <example>{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":3}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EndpointsMetadata Endpoints { get; set; }

        /// <summary>
        /// Milliseconds measured for the generation, from dispatching the upstream request until its response body ended. Divide the completion token count by this for throughput. Absent when no upstream request was dispatched.<br/>
        /// Example: 2016
        /// </summary>
        /// <example>2016</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_time")]
        public int? GenerationTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsByok { get; set; }

        /// <summary>
        /// Example: {"version_group":"anthropic/claude-sonnet-4"}
        /// </summary>
        /// <example>{"version_group":"anthropic/claude-sonnet-4"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::OpenRouter.RouterParams? Params { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public global::System.Collections.Generic.IList<global::OpenRouter.PipelineStage>? Pipeline { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Requested { get; set; }

        /// <summary>
        /// Example: direct
        /// </summary>
        /// <example>direct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.RoutingStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.RoutingStrategy Strategy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterMetadata" /> class.
        /// </summary>
        /// <param name="attempt"></param>
        /// <param name="endpoints">
        /// Example: {"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":3}
        /// </param>
        /// <param name="isByok"></param>
        /// <param name="requested"></param>
        /// <param name="strategy">
        /// Example: direct
        /// </param>
        /// <param name="summary"></param>
        /// <param name="attempts"></param>
        /// <param name="generationTime">
        /// Milliseconds measured for the generation, from dispatching the upstream request until its response body ended. Divide the completion token count by this for throughput. Absent when no upstream request was dispatched.<br/>
        /// Example: 2016
        /// </param>
        /// <param name="params">
        /// Example: {"version_group":"anthropic/claude-sonnet-4"}
        /// </param>
        /// <param name="pipeline"></param>
        /// <param name="region"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenRouterMetadata(
            int attempt,
            global::OpenRouter.EndpointsMetadata endpoints,
            bool isByok,
            string requested,
            global::OpenRouter.RoutingStrategy strategy,
            string summary,
            global::System.Collections.Generic.IList<global::OpenRouter.RouterAttempt>? attempts,
            int? generationTime,
            global::OpenRouter.RouterParams? @params,
            global::System.Collections.Generic.IList<global::OpenRouter.PipelineStage>? pipeline,
            string? region)
        {
            this.Attempt = attempt;
            this.Attempts = attempts;
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.GenerationTime = generationTime;
            this.IsByok = isByok;
            this.Params = @params;
            this.Pipeline = pipeline;
            this.Region = region;
            this.Requested = requested ?? throw new global::System.ArgumentNullException(nameof(requested));
            this.Strategy = strategy;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRouterMetadata" /> class.
        /// </summary>
        public OpenRouterMetadata()
        {
        }

    }
}