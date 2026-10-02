
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Marketplace category group to filter by (e.g. `coding`). Only apps tagged with a subcategory inside this group are returned. Mutually combinable with `subcategory` — when both are supplied the `subcategory` must belong to the `category` group.<br/>
    /// Example: coding
    /// </summary>
    public readonly partial struct GetAppRankingsCategory : global::System.IEquatable<GetAppRankingsCategory>
    {
        /// <summary>
        ///
        /// </summary>
        public GetAppRankingsCategory(string value)
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
        public static GetAppRankingsCategory Coding { get; } = new("coding");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsCategory Creative { get; } = new("creative");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsCategory Entertainment { get; } = new("entertainment");

        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsCategory Productivity { get; } = new("productivity");
        /// <summary>
        ///
        /// </summary>
        public static GetAppRankingsCategory FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "coding" => Coding,
                "creative" => Creative,
                "entertainment" => Entertainment,
                "productivity" => Productivity,
                _ => new GetAppRankingsCategory(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "coding" => true,
            "creative" => true,
            "entertainment" => true,
            "productivity" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetAppRankingsCategory other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAppRankingsCategory other && Equals(other);
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
        public static bool operator ==(GetAppRankingsCategory left, GetAppRankingsCategory right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetAppRankingsCategory left, GetAppRankingsCategory right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAppRankingsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAppRankingsCategory value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAppRankingsCategory? ToEnum(string value)
        {
            return GetAppRankingsCategory.FromValue(value);
        }
    }
}