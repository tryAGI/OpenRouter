
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelInputV2Variant2ParamsSourcesValue : global::System.IEquatable<ModelInputV2Variant2ParamsSourcesValue>
    {
        /// <summary>
        ///
        /// </summary>
        public ModelInputV2Variant2ParamsSourcesValue(string value)
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
        public static ModelInputV2Variant2ParamsSourcesValue Base64 { get; } = new("base64");

        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant2ParamsSourcesValue Url { get; } = new("url");
        /// <summary>
        ///
        /// </summary>
        public static ModelInputV2Variant2ParamsSourcesValue FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "base64" => Base64,
                "url" => Url,
                _ => new ModelInputV2Variant2ParamsSourcesValue(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "base64" => true,
            "url" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ModelInputV2Variant2ParamsSourcesValue other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelInputV2Variant2ParamsSourcesValue other && Equals(other);
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
        public static bool operator ==(ModelInputV2Variant2ParamsSourcesValue left, ModelInputV2Variant2ParamsSourcesValue right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelInputV2Variant2ParamsSourcesValue left, ModelInputV2Variant2ParamsSourcesValue right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant2ParamsSourcesValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant2ParamsSourcesValue value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant2ParamsSourcesValue? ToEnum(string value)
        {
            return ModelInputV2Variant2ParamsSourcesValue.FromValue(value);
        }
    }
}