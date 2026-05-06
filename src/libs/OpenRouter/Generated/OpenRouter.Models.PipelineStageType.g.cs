
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Categorical kind of a pipeline stage. Multiple plugins can share a type (e.g. all guardrail-level plugins emit `guardrail`); the `name` field disambiguates which plugin emitted it.
    /// </summary>
    public enum PipelineStageType
    {
        /// <summary>
        /// 
        /// </summary>
        ContextCompression,
        /// <summary>
        /// 
        /// </summary>
        FileParser,
        /// <summary>
        /// 
        /// </summary>
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        ResponseHealing,
        /// <summary>
        /// 
        /// </summary>
        Router,
        /// <summary>
        /// 
        /// </summary>
        ServerTools,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineStageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineStageType value)
        {
            return value switch
            {
                PipelineStageType.ContextCompression => "context_compression",
                PipelineStageType.FileParser => "file_parser",
                PipelineStageType.Guardrail => "guardrail",
                PipelineStageType.ResponseHealing => "response_healing",
                PipelineStageType.Router => "router",
                PipelineStageType.ServerTools => "server_tools",
                PipelineStageType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineStageType? ToEnum(string value)
        {
            return value switch
            {
                "context_compression" => PipelineStageType.ContextCompression,
                "file_parser" => PipelineStageType.FileParser,
                "guardrail" => PipelineStageType.Guardrail,
                "response_healing" => PipelineStageType.ResponseHealing,
                "router" => PipelineStageType.Router,
                "server_tools" => PipelineStageType.ServerTools,
                "web_search" => PipelineStageType.WebSearch,
                _ => null,
            };
        }
    }
}