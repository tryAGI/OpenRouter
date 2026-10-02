
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Status of a shell call or its output.<br/>
    /// Example: completed
    /// </summary>
    public readonly partial struct ShellCallStatus : global::System.IEquatable<ShellCallStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ShellCallStatus(string value)
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
        public static ShellCallStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static ShellCallStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static ShellCallStatus Incomplete { get; } = new("incomplete");
        /// <summary>
        ///
        /// </summary>
        public static ShellCallStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                _ => new ShellCallStatus(value),
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
        public bool Equals(ShellCallStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShellCallStatus other && Equals(other);
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
        public static bool operator ==(ShellCallStatus left, ShellCallStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ShellCallStatus left, ShellCallStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellCallStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellCallStatus? ToEnum(string value)
        {
            return ShellCallStatus.FromValue(value);
        }
    }
}