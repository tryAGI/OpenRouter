
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImageGenerationServerToolModeration : global::System.IEquatable<ImageGenerationServerToolModeration>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationServerToolModeration(string value)
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
        public static ImageGenerationServerToolModeration Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolModeration Low { get; } = new("low");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolModeration FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "low" => Low,
                _ => new ImageGenerationServerToolModeration(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "low" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationServerToolModeration other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationServerToolModeration other && Equals(other);
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
        public static bool operator ==(ImageGenerationServerToolModeration left, ImageGenerationServerToolModeration right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationServerToolModeration left, ImageGenerationServerToolModeration right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolModerationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolModeration value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolModeration? ToEnum(string value)
        {
            return ImageGenerationServerToolModeration.FromValue(value);
        }
    }
}