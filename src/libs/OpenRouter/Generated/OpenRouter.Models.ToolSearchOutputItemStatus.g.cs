
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolSearchOutputItemStatus : global::System.IEquatable<ToolSearchOutputItemStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ToolSearchOutputItemStatus(string value)
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
        public static ToolSearchOutputItemStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static ToolSearchOutputItemStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static ToolSearchOutputItemStatus Incomplete { get; } = new("incomplete");
        /// <summary>
        ///
        /// </summary>
        public static ToolSearchOutputItemStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                _ => new ToolSearchOutputItemStatus(value),
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
        public bool Equals(ToolSearchOutputItemStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolSearchOutputItemStatus other && Equals(other);
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
        public static bool operator ==(ToolSearchOutputItemStatus left, ToolSearchOutputItemStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolSearchOutputItemStatus left, ToolSearchOutputItemStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchOutputItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchOutputItemStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchOutputItemStatus? ToEnum(string value)
        {
            return ToolSearchOutputItemStatus.FromValue(value);
        }
    }
}