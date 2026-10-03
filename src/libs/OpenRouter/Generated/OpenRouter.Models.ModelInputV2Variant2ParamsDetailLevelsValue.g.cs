
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelInputV2Variant2ParamsDetailLevelsValue : global::System.IEquatable<ModelInputV2Variant2ParamsDetailLevelsValue>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelInputV2Variant2ParamsDetailLevelsValue(string value)
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
        public static ModelInputV2Variant2ParamsDetailLevelsValue Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant2ParamsDetailLevelsValue High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant2ParamsDetailLevelsValue Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant2ParamsDetailLevelsValue Original { get; } = new("original");
        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant2ParamsDetailLevelsValue FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "high" => High,
                "low" => Low,
                "original" => Original,
                _ => new ModelInputV2Variant2ParamsDetailLevelsValue(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "high" => true,
            "low" => true,
            "original" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ModelInputV2Variant2ParamsDetailLevelsValue other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelInputV2Variant2ParamsDetailLevelsValue other && Equals(other);
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
        public static bool operator ==(ModelInputV2Variant2ParamsDetailLevelsValue left, ModelInputV2Variant2ParamsDetailLevelsValue right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelInputV2Variant2ParamsDetailLevelsValue left, ModelInputV2Variant2ParamsDetailLevelsValue right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant2ParamsDetailLevelsValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant2ParamsDetailLevelsValue value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant2ParamsDetailLevelsValue? ToEnum(string value)
        {
            return ModelInputV2Variant2ParamsDetailLevelsValue.FromValue(value);
        }
    }
}