
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImageGenerationServerToolInputFidelity : global::System.IEquatable<ImageGenerationServerToolInputFidelity>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationServerToolInputFidelity(string value)
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
        public static ImageGenerationServerToolInputFidelity High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolInputFidelity Low { get; } = new("low");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolInputFidelity FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                _ => new ImageGenerationServerToolInputFidelity(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "high" => true,
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
        public bool Equals(ImageGenerationServerToolInputFidelity other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationServerToolInputFidelity other && Equals(other);
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
        public static bool operator ==(ImageGenerationServerToolInputFidelity left, ImageGenerationServerToolInputFidelity right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationServerToolInputFidelity left, ImageGenerationServerToolInputFidelity right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolInputFidelityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolInputFidelity value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolInputFidelity? ToEnum(string value)
        {
            return ImageGenerationServerToolInputFidelity.FromValue(value);
        }
    }
}