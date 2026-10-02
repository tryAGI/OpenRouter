
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Reasoning effort to apply from this point in the conversation onward<br/>
    /// Example: low
    /// </summary>
    public readonly partial struct ConfigurationUpdateReasoningEffort : global::System.IEquatable<ConfigurationUpdateReasoningEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public ConfigurationUpdateReasoningEffort(string value)
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
        public static ConfigurationUpdateReasoningEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ConfigurationUpdateReasoningEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ConfigurationUpdateReasoningEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static ConfigurationUpdateReasoningEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static ConfigurationUpdateReasoningEffort Minimal { get; } = new("minimal");

        /// <summary>
        ///
        /// </summary>
        public static ConfigurationUpdateReasoningEffort None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static ConfigurationUpdateReasoningEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static ConfigurationUpdateReasoningEffort FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "max" => Max,
                "medium" => Medium,
                "minimal" => Minimal,
                "none" => None,
                "xhigh" => Xhigh,
                _ => new ConfigurationUpdateReasoningEffort(value),
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
            "minimal" => true,
            "none" => true,
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
        public bool Equals(ConfigurationUpdateReasoningEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConfigurationUpdateReasoningEffort other && Equals(other);
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
        public static bool operator ==(ConfigurationUpdateReasoningEffort left, ConfigurationUpdateReasoningEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ConfigurationUpdateReasoningEffort left, ConfigurationUpdateReasoningEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigurationUpdateReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigurationUpdateReasoningEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigurationUpdateReasoningEffort? ToEnum(string value)
        {
            return ConfigurationUpdateReasoningEffort.FromValue(value);
        }
    }
}