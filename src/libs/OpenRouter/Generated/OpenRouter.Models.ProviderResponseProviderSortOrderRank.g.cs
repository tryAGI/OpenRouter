
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ProviderResponseProviderSortOrderRank : global::System.IEquatable<ProviderResponseProviderSortOrderRank>
    {
        /// <summary>
        ///
        /// </summary>
        public ProviderResponseProviderSortOrderRank(string value)
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
        public static ProviderResponseProviderSortOrderRank Order { get; } = new("order");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderSortOrderRank Unlisted { get; } = new("unlisted");
        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderSortOrderRank FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "order" => Order,
                "unlisted" => Unlisted,
                _ => new ProviderResponseProviderSortOrderRank(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "order" => true,
            "unlisted" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ProviderResponseProviderSortOrderRank other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderResponseProviderSortOrderRank other && Equals(other);
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
        public static bool operator ==(ProviderResponseProviderSortOrderRank left, ProviderResponseProviderSortOrderRank right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderResponseProviderSortOrderRank left, ProviderResponseProviderSortOrderRank right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResponseProviderSortOrderRankExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResponseProviderSortOrderRank value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResponseProviderSortOrderRank? ToEnum(string value)
        {
            return ProviderResponseProviderSortOrderRank.FromValue(value);
        }
    }
}