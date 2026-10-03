
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelInputV2Variant3ParamsFormatsValue : global::System.IEquatable<ModelInputV2Variant3ParamsFormatsValue>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelInputV2Variant3ParamsFormatsValue(string value)
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
        public static ModelInputV2Variant3ParamsFormatsValue VideoMp4 { get; } = new("video/mp4");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant3ParamsFormatsValue VideoWebm { get; } = new("video/webm");
        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant3ParamsFormatsValue FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "video/mp4" => VideoMp4,
                "video/webm" => VideoWebm,
                _ => new ModelInputV2Variant3ParamsFormatsValue(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "video/mp4" => true,
            "video/webm" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ModelInputV2Variant3ParamsFormatsValue other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelInputV2Variant3ParamsFormatsValue other && Equals(other);
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
        public static bool operator ==(ModelInputV2Variant3ParamsFormatsValue left, ModelInputV2Variant3ParamsFormatsValue right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelInputV2Variant3ParamsFormatsValue left, ModelInputV2Variant3ParamsFormatsValue right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant3ParamsFormatsValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant3ParamsFormatsValue value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant3ParamsFormatsValue? ToEnum(string value)
        {
            return ModelInputV2Variant3ParamsFormatsValue.FromValue(value);
        }
    }
}