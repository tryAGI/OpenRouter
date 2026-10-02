
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Categorical kind of a pipeline stage. Multiple plugins can share a type (e.g. all guardrail-level plugins emit `guardrail`); the `name` field disambiguates which plugin emitted it.<br/>
    /// Example: guardrail
    /// </summary>
    public readonly partial struct PipelineStageType : global::System.IEquatable<PipelineStageType>
    {
        /// <summary>
        ///
        /// </summary>
        public PipelineStageType(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static PipelineStageType ContextCompression { get; } = new("context_compression");

        /// <summary>
        ///
        /// </summary>
        public static PipelineStageType Guardrail { get; } = new("guardrail");

        /// <summary>
        ///
        /// </summary>
        public static PipelineStageType Plugin { get; } = new("plugin");

        /// <summary>
        ///
        /// </summary>
        public static PipelineStageType ResponseHealing { get; } = new("response_healing");

        /// <summary>
        ///
        /// </summary>
        public static PipelineStageType ServerTools { get; } = new("server_tools");
        /// <summary>
        ///
        /// </summary>
        public static PipelineStageType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "context_compression" => ContextCompression,
                "guardrail" => Guardrail,
                "plugin" => Plugin,
                "response_healing" => ResponseHealing,
                "server_tools" => ServerTools,
                _ => new PipelineStageType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "context_compression" => true,
            "guardrail" => true,
            "plugin" => true,
            "response_healing" => true,
            "server_tools" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PipelineStageType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PipelineStageType other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PipelineStageType left, PipelineStageType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PipelineStageType left, PipelineStageType right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineStageType? ToEnum(string value)
        {
            return PipelineStageType.FromValue(value);
        }
    }
}