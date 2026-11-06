
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct McpCallItemStatus : global::System.IEquatable<McpCallItemStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public McpCallItemStatus(string value)
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
        public static McpCallItemStatus Calling { get; } = new("calling");

        /// <summary>
        ///
        /// </summary>
        public static McpCallItemStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static McpCallItemStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static McpCallItemStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static McpCallItemStatus Incomplete { get; } = new("incomplete");
        /// <summary>
        ///
        /// </summary>
        public static McpCallItemStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "calling" => Calling,
                "completed" => Completed,
                "failed" => Failed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                _ => new McpCallItemStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "calling" => true,
            "completed" => true,
            "failed" => true,
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
        public bool Equals(McpCallItemStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpCallItemStatus other && Equals(other);
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
        public static bool operator ==(McpCallItemStatus left, McpCallItemStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(McpCallItemStatus left, McpCallItemStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallItemStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallItemStatus? ToEnum(string value)
        {
            return McpCallItemStatus.FromValue(value);
        }
    }
}