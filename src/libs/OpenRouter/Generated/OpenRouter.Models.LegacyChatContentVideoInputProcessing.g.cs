
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Video processing mode. `agentic` enables agentic video processing and `static` forces fixed-rate frame sampling on providers that support it (currently Google Gemini).<br/>
    /// Example: agentic
    /// </summary>
    public readonly partial struct LegacyChatContentVideoInputProcessing : global::System.IEquatable<LegacyChatContentVideoInputProcessing>
    {
        /// <summary>
        ///
        /// </summary>
        public LegacyChatContentVideoInputProcessing(string value)
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
        public static LegacyChatContentVideoInputProcessing Agentic { get; } = new("agentic");

        /// <summary>
        ///
        /// </summary>
        public static LegacyChatContentVideoInputProcessing Static { get; } = new("static");
        /// <summary>
        ///
        /// </summary>
        public static LegacyChatContentVideoInputProcessing FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "agentic" => Agentic,
                "static" => Static,
                _ => new LegacyChatContentVideoInputProcessing(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "agentic" => true,
            "static" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(LegacyChatContentVideoInputProcessing other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LegacyChatContentVideoInputProcessing other && Equals(other);
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
        public static bool operator ==(LegacyChatContentVideoInputProcessing left, LegacyChatContentVideoInputProcessing right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LegacyChatContentVideoInputProcessing left, LegacyChatContentVideoInputProcessing right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyChatContentVideoInputProcessingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyChatContentVideoInputProcessing value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyChatContentVideoInputProcessing? ToEnum(string value)
        {
            return LegacyChatContentVideoInputProcessing.FromValue(value);
        }
    }
}