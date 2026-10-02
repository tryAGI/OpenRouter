
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Whether this image represents the first or last frame of the video<br/>
    /// Example: first_frame
    /// </summary>
    public readonly partial struct FrameImageVariant2FrameType : global::System.IEquatable<FrameImageVariant2FrameType>
    {
        /// <summary>
        ///
        /// </summary>
        public FrameImageVariant2FrameType(string value)
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
        public static FrameImageVariant2FrameType FirstFrame { get; } = new("first_frame");

        /// <summary>
        ///
        /// </summary>
        public static FrameImageVariant2FrameType LastFrame { get; } = new("last_frame");
        /// <summary>
        ///
        /// </summary>
        public static FrameImageVariant2FrameType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "first_frame" => FirstFrame,
                "last_frame" => LastFrame,
                _ => new FrameImageVariant2FrameType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "first_frame" => true,
            "last_frame" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(FrameImageVariant2FrameType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FrameImageVariant2FrameType other && Equals(other);
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
        public static bool operator ==(FrameImageVariant2FrameType left, FrameImageVariant2FrameType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FrameImageVariant2FrameType left, FrameImageVariant2FrameType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FrameImageVariant2FrameTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FrameImageVariant2FrameType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FrameImageVariant2FrameType? ToEnum(string value)
        {
            return FrameImageVariant2FrameType.FromValue(value);
        }
    }
}