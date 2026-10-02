
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Output format. "json" (default) returns { text, usage }. "verbose_json" additionally returns task, language, duration, and segment-level timestamps; only supported by OpenAI-compatible providers.<br/>
    /// Example: json
    /// </summary>
    public readonly partial struct STTRequestResponseFormat : global::System.IEquatable<STTRequestResponseFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public STTRequestResponseFormat(string value)
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
        public static STTRequestResponseFormat Json { get; } = new("json");

        /// <summary>
        ///
        /// </summary>
        public static STTRequestResponseFormat VerboseJson { get; } = new("verbose_json");
        /// <summary>
        ///
        /// </summary>
        public static STTRequestResponseFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "json" => Json,
                "verbose_json" => VerboseJson,
                _ => new STTRequestResponseFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "json" => true,
            "verbose_json" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(STTRequestResponseFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTRequestResponseFormat other && Equals(other);
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
        public static bool operator ==(STTRequestResponseFormat left, STTRequestResponseFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(STTRequestResponseFormat left, STTRequestResponseFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class STTRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this STTRequestResponseFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static STTRequestResponseFormat? ToEnum(string value)
        {
            return STTRequestResponseFormat.FromValue(value);
        }
    }
}