
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: high
    /// </summary>
    public readonly partial struct AnthropicOutputEffort : global::System.IEquatable<AnthropicOutputEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicOutputEffort(string value)
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
        public static AnthropicOutputEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicOutputEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicOutputEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicOutputEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicOutputEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicOutputEffort FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "max" => Max,
                "medium" => Medium,
                "xhigh" => Xhigh,
                _ => new AnthropicOutputEffort(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "high" => true,
            "low" => true,
            "max" => true,
            "medium" => true,
            "xhigh" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicOutputEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicOutputEffort other && Equals(other);
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
        public static bool operator ==(AnthropicOutputEffort left, AnthropicOutputEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicOutputEffort left, AnthropicOutputEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicOutputEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicOutputEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicOutputEffort? ToEnum(string value)
        {
            return AnthropicOutputEffort.FromValue(value);
        }
    }
}