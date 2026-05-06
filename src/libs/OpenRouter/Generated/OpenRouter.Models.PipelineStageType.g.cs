
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
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        Plugin,
        /// <summary>
        /// 
        /// </summary>
        ResponseHealing,
        /// <summary>
        /// 
        /// </summary>
        ServerTools,
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
                PipelineStageType.Guardrail => "guardrail",
                PipelineStageType.Plugin => "plugin",
                PipelineStageType.ResponseHealing => "response_healing",
                PipelineStageType.ServerTools => "server_tools",
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
                "guardrail" => PipelineStageType.Guardrail,
                "plugin" => PipelineStageType.Plugin,
                "response_healing" => PipelineStageType.ResponseHealing,
                "server_tools" => PipelineStageType.ServerTools,
                _ => null,
            };
        }
    }
}