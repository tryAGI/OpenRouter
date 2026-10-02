
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Whether the operator expects a single value or an array
    /// </summary>
    public readonly partial struct GetAnalyticsMetaResponseDataOperatorValueType : global::System.IEquatable<GetAnalyticsMetaResponseDataOperatorValueType>
    {
        /// <summary>
        ///
        /// </summary>
        public GetAnalyticsMetaResponseDataOperatorValueType(string value)
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
        public static GetAnalyticsMetaResponseDataOperatorValueType Array { get; } = new("array");

        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataOperatorValueType Scalar { get; } = new("scalar");
        /// <summary>
        ///
        /// </summary>
        public static GetAnalyticsMetaResponseDataOperatorValueType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "array" => Array,
                "scalar" => Scalar,
                _ => new GetAnalyticsMetaResponseDataOperatorValueType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "array" => true,
            "scalar" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetAnalyticsMetaResponseDataOperatorValueType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAnalyticsMetaResponseDataOperatorValueType other && Equals(other);
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
        public static bool operator ==(GetAnalyticsMetaResponseDataOperatorValueType left, GetAnalyticsMetaResponseDataOperatorValueType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetAnalyticsMetaResponseDataOperatorValueType left, GetAnalyticsMetaResponseDataOperatorValueType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsMetaResponseDataOperatorValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsMetaResponseDataOperatorValueType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsMetaResponseDataOperatorValueType? ToEnum(string value)
        {
            return GetAnalyticsMetaResponseDataOperatorValueType.FromValue(value);
        }
    }
}