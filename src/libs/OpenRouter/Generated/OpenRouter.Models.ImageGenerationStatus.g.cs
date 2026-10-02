
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: completed
    /// </summary>
    public readonly partial struct ImageGenerationStatus : global::System.IEquatable<ImageGenerationStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationStatus(string value)
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
        public static ImageGenerationStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationStatus Generating { get; } = new("generating");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationStatus InProgress { get; } = new("in_progress");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completed" => Completed,
                "failed" => Failed,
                "generating" => Generating,
                "in_progress" => InProgress,
                _ => new ImageGenerationStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completed" => true,
            "failed" => true,
            "generating" => true,
            "in_progress" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationStatus other && Equals(other);
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
        public static bool operator ==(ImageGenerationStatus left, ImageGenerationStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationStatus left, ImageGenerationStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationStatus? ToEnum(string value)
        {
            return ImageGenerationStatus.FromValue(value);
        }
    }
}