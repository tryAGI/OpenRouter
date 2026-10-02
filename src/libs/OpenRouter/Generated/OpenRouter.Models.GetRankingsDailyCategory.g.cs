
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Restrict to a use-case category (e.g. `programming`, `roleplay`). Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `language_type`.<br/>
    /// Example: programming
    /// </summary>
    public readonly partial struct GetRankingsDailyCategory : global::System.IEquatable<GetRankingsDailyCategory>
    {
        /// <summary>
        ///
        /// </summary>
        public GetRankingsDailyCategory(string value)
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
        public static GetRankingsDailyCategory Academia { get; } = new("academia");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Finance { get; } = new("finance");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Health { get; } = new("health");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Legal { get; } = new("legal");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Marketing { get; } = new("marketing");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory MarketingSeo { get; } = new("marketing/seo");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Programming { get; } = new("programming");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Roleplay { get; } = new("roleplay");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Science { get; } = new("science");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Technology { get; } = new("technology");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Translation { get; } = new("translation");

        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory Trivia { get; } = new("trivia");
        /// <summary>
        ///
        /// </summary>
        public static GetRankingsDailyCategory FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "academia" => Academia,
                "finance" => Finance,
                "health" => Health,
                "legal" => Legal,
                "marketing" => Marketing,
                "marketing/seo" => MarketingSeo,
                "programming" => Programming,
                "roleplay" => Roleplay,
                "science" => Science,
                "technology" => Technology,
                "translation" => Translation,
                "trivia" => Trivia,
                _ => new GetRankingsDailyCategory(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "academia" => true,
            "finance" => true,
            "health" => true,
            "legal" => true,
            "marketing" => true,
            "marketing/seo" => true,
            "programming" => true,
            "roleplay" => true,
            "science" => true,
            "technology" => true,
            "translation" => true,
            "trivia" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetRankingsDailyCategory other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetRankingsDailyCategory other && Equals(other);
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
        public static bool operator ==(GetRankingsDailyCategory left, GetRankingsDailyCategory right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetRankingsDailyCategory left, GetRankingsDailyCategory right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRankingsDailyCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRankingsDailyCategory value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRankingsDailyCategory? ToEnum(string value)
        {
            return GetRankingsDailyCategory.FromValue(value);
        }
    }
}