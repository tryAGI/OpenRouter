
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer. Valid values are `low`, `medium`, `high`, `xhigh`, or `max`.<br/>
    /// Example: medium
    /// </summary>
    public readonly partial struct MessagesOutputConfigEffort : global::System.IEquatable<MessagesOutputConfigEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public MessagesOutputConfigEffort(string value)
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
        public static MessagesOutputConfigEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static MessagesOutputConfigEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static MessagesOutputConfigEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static MessagesOutputConfigEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static MessagesOutputConfigEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static MessagesOutputConfigEffort FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "max" => Max,
                "medium" => Medium,
                "xhigh" => Xhigh,
                _ => new MessagesOutputConfigEffort(value),
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
        public bool Equals(MessagesOutputConfigEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesOutputConfigEffort other && Equals(other);
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
        public static bool operator ==(MessagesOutputConfigEffort left, MessagesOutputConfigEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessagesOutputConfigEffort left, MessagesOutputConfigEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesOutputConfigEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesOutputConfigEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesOutputConfigEffort? ToEnum(string value)
        {
            return MessagesOutputConfigEffort.FromValue(value);
        }
    }
}