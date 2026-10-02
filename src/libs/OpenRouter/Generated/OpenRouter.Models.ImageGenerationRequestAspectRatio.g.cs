
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Normalized aspect ratio of the generated image. Providers clamp to their supported subset.<br/>
    /// Example: 16:9
    /// </summary>
    public readonly partial struct ImageGenerationRequestAspectRatio : global::System.IEquatable<ImageGenerationRequestAspectRatio>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequestAspectRatio(string value)
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
        public static ImageGenerationRequestAspectRatio x16_9 { get; } = new("16:9");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x195_9 { get; } = new("19.5:9");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x1_1 { get; } = new("1:1");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x1_2 { get; } = new("1:2");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x1_4 { get; } = new("1:4");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x1_8 { get; } = new("1:8");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x235_1 { get; } = new("2.35:1");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x20_9 { get; } = new("20:9");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x21_9 { get; } = new("21:9");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x2_1 { get; } = new("2:1");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x2_3 { get; } = new("2:3");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x3_2 { get; } = new("3:2");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x3_4 { get; } = new("3:4");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x4_1 { get; } = new("4:1");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x4_3 { get; } = new("4:3");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x4_5 { get; } = new("4:5");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x5_2 { get; } = new("5:2");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x5_4 { get; } = new("5:4");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x5_7 { get; } = new("5:7");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x7_5 { get; } = new("7:5");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x8_1 { get; } = new("8:1");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x9_16 { get; } = new("9:16");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x9_195 { get; } = new("9:19.5");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x9_20 { get; } = new("9:20");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio x9_21 { get; } = new("9:21");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio Auto { get; } = new("auto");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestAspectRatio FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "16:9" => x16_9,
                "19.5:9" => x195_9,
                "1:1" => x1_1,
                "1:2" => x1_2,
                "1:4" => x1_4,
                "1:8" => x1_8,
                "2.35:1" => x235_1,
                "20:9" => x20_9,
                "21:9" => x21_9,
                "2:1" => x2_1,
                "2:3" => x2_3,
                "3:2" => x3_2,
                "3:4" => x3_4,
                "4:1" => x4_1,
                "4:3" => x4_3,
                "4:5" => x4_5,
                "5:2" => x5_2,
                "5:4" => x5_4,
                "5:7" => x5_7,
                "7:5" => x7_5,
                "8:1" => x8_1,
                "9:16" => x9_16,
                "9:19.5" => x9_195,
                "9:20" => x9_20,
                "9:21" => x9_21,
                "auto" => Auto,
                _ => new ImageGenerationRequestAspectRatio(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "16:9" => true,
            "19.5:9" => true,
            "1:1" => true,
            "1:2" => true,
            "1:4" => true,
            "1:8" => true,
            "2.35:1" => true,
            "20:9" => true,
            "21:9" => true,
            "2:1" => true,
            "2:3" => true,
            "3:2" => true,
            "3:4" => true,
            "4:1" => true,
            "4:3" => true,
            "4:5" => true,
            "5:2" => true,
            "5:4" => true,
            "5:7" => true,
            "7:5" => true,
            "8:1" => true,
            "9:16" => true,
            "9:19.5" => true,
            "9:20" => true,
            "9:21" => true,
            "auto" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationRequestAspectRatio other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationRequestAspectRatio other && Equals(other);
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
        public static bool operator ==(ImageGenerationRequestAspectRatio left, ImageGenerationRequestAspectRatio right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationRequestAspectRatio left, ImageGenerationRequestAspectRatio right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestAspectRatio value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestAspectRatio? ToEnum(string value)
        {
            return ImageGenerationRequestAspectRatio.FromValue(value);
        }
    }
}