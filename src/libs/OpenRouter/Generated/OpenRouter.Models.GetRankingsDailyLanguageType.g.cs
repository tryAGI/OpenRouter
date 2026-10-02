
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Restrict to natural-language or programming-language tagged activity. Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `category`.<br/>
    /// Example: natural
    /// </summary>
    public readonly partial struct GetRankingsDailyLanguageType : global::System.IEquatable<GetRankingsDailyLanguageType>
    {
        /// <summary>
        ///
        /// </summary>
        public GetRankingsDailyLanguageType(string value)
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
        public static GetRankingsDailyLanguageType Natural { get; } = new("natural");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyLanguageType Programming { get; } = new("programming");
        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyLanguageType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "natural" => Natural,
                "programming" => Programming,
                _ => new GetRankingsDailyLanguageType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "natural" => true,
            "programming" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetRankingsDailyLanguageType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetRankingsDailyLanguageType other && Equals(other);
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
        public static bool operator ==(GetRankingsDailyLanguageType left, GetRankingsDailyLanguageType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetRankingsDailyLanguageType left, GetRankingsDailyLanguageType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRankingsDailyLanguageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRankingsDailyLanguageType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRankingsDailyLanguageType? ToEnum(string value)
        {
            return GetRankingsDailyLanguageType.FromValue(value);
        }
    }
}