
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: text
    /// </summary>
    public readonly partial struct OutputModalityEnum : global::System.IEquatable<OutputModalityEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputModalityEnum(string value)
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
        public static OutputModalityEnum Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static OutputModalityEnum Text { get; } = new("text");
        /// <summary>
        ///
        /// </summary>
        public static OutputModalityEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "image" => Image,
                "text" => Text,
                _ => new OutputModalityEnum(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "image" => true,
            "text" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OutputModalityEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputModalityEnum other && Equals(other);
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
        public static bool operator ==(OutputModalityEnum left, OutputModalityEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputModalityEnum left, OutputModalityEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputModalityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputModalityEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputModalityEnum? ToEnum(string value)
        {
            return OutputModalityEnum.FromValue(value);
        }
    }
}