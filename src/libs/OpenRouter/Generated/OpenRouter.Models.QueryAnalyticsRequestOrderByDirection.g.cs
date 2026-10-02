
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct QueryAnalyticsRequestOrderByDirection : global::System.IEquatable<QueryAnalyticsRequestOrderByDirection>
    {
        /// <summary>
        ///
        /// </summary>
        public QueryAnalyticsRequestOrderByDirection(string value)
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
        public static QueryAnalyticsRequestOrderByDirection Asc { get; } = new("asc");

        /// <summary>
        ///
        /// </summary>
        public static QueryAnalyticsRequestOrderByDirection Desc { get; } = new("desc");
        /// <summary>
        ///
        /// </summary>
        public static QueryAnalyticsRequestOrderByDirection FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "asc" => Asc,
                "desc" => Desc,
                _ => new QueryAnalyticsRequestOrderByDirection(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "asc" => true,
            "desc" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(QueryAnalyticsRequestOrderByDirection other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryAnalyticsRequestOrderByDirection other && Equals(other);
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
        public static bool operator ==(QueryAnalyticsRequestOrderByDirection left, QueryAnalyticsRequestOrderByDirection right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(QueryAnalyticsRequestOrderByDirection left, QueryAnalyticsRequestOrderByDirection right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryAnalyticsRequestOrderByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryAnalyticsRequestOrderByDirection value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryAnalyticsRequestOrderByDirection? ToEnum(string value)
        {
            return QueryAnalyticsRequestOrderByDirection.FromValue(value);
        }
    }
}