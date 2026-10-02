
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputMemoryServerToolItemAction : global::System.IEquatable<OutputMemoryServerToolItemAction>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputMemoryServerToolItemAction(string value)
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
        public static OutputMemoryServerToolItemAction Delete { get; } = new("delete");

        /// <summary>
        ///
        /// </summary>
        public static OutputMemoryServerToolItemAction Read { get; } = new("read");

        /// <summary>
        ///
        /// </summary>
        public static OutputMemoryServerToolItemAction Write { get; } = new("write");
        /// <summary>
        ///
        /// </summary>
        public static OutputMemoryServerToolItemAction FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "delete" => Delete,
                "read" => Read,
                "write" => Write,
                _ => new OutputMemoryServerToolItemAction(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "delete" => true,
            "read" => true,
            "write" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OutputMemoryServerToolItemAction other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMemoryServerToolItemAction other && Equals(other);
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
        public static bool operator ==(OutputMemoryServerToolItemAction left, OutputMemoryServerToolItemAction right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputMemoryServerToolItemAction left, OutputMemoryServerToolItemAction right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMemoryServerToolItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMemoryServerToolItemAction value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMemoryServerToolItemAction? ToEnum(string value)
        {
            return OutputMemoryServerToolItemAction.FromValue(value);
        }
    }
}