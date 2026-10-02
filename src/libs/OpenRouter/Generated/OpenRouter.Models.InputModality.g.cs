
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: text
    /// </summary>
    public readonly partial struct InputModality : global::System.IEquatable<InputModality>
    {
        /// <summary>
        ///
        /// </summary>
        public InputModality(string value)
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
        public static InputModality Audio { get; } = new("audio");

        /// <summary>
        ///
        /// </summary>
        public static InputModality File { get; } = new("file");

        /// <summary>
        ///
        /// </summary>
        public static InputModality Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static InputModality Text { get; } = new("text");

        /// <summary>
        ///
        /// </summary>
        public static InputModality Video { get; } = new("video");
        /// <summary>
        ///
        /// </summary>
        public static InputModality FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "file" => File,
                "image" => Image,
                "text" => Text,
                "video" => Video,
                _ => new InputModality(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "file" => true,
            "image" => true,
            "text" => true,
            "video" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InputModality other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputModality other && Equals(other);
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
        public static bool operator ==(InputModality left, InputModality right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputModality left, InputModality right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputModality value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputModality? ToEnum(string value)
        {
            return InputModality.FromValue(value);
        }
    }
}