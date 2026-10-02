
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: auto
    /// </summary>
    public readonly partial struct OpenAIResponsesTruncation : global::System.IEquatable<OpenAIResponsesTruncation>
    {
        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesTruncation(string value)
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
        public static OpenAIResponsesTruncation Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesTruncation Disabled { get; } = new("disabled");
        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesTruncation FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "disabled" => Disabled,
                _ => new OpenAIResponsesTruncation(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "disabled" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OpenAIResponsesTruncation other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAIResponsesTruncation other && Equals(other);
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
        public static bool operator ==(OpenAIResponsesTruncation left, OpenAIResponsesTruncation right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenAIResponsesTruncation left, OpenAIResponsesTruncation right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesTruncationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesTruncation value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesTruncation? ToEnum(string value)
        {
            return OpenAIResponsesTruncation.FromValue(value);
        }
    }
}