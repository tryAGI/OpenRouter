
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: completed
    /// </summary>
    public readonly partial struct ToolCallStatus : global::System.IEquatable<ToolCallStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ToolCallStatus(string value)
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
        public static ToolCallStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static ToolCallStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static ToolCallStatus Incomplete { get; } = new("incomplete");
        /// <summary>
        ///
        /// </summary>
        public static ToolCallStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                _ => new ToolCallStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completed" => true,
            "in_progress" => true,
            "incomplete" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ToolCallStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallStatus other && Equals(other);
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
        public static bool operator ==(ToolCallStatus left, ToolCallStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolCallStatus left, ToolCallStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallStatus? ToEnum(string value)
        {
            return ToolCallStatus.FromValue(value);
        }
    }
}