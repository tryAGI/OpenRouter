
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Filter models by use case category<br/>
    /// Example: programming
    /// </summary>
    public readonly partial struct GetModelsCategory : global::System.IEquatable<GetModelsCategory>
    {
        /// <summary>
        ///
        /// </summary>
        public GetModelsCategory(string value)
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
        public static GetModelsCategory Academia { get; } = new("academia");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Finance { get; } = new("finance");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Health { get; } = new("health");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Legal { get; } = new("legal");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Marketing { get; } = new("marketing");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory MarketingSeo { get; } = new("marketing/seo");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Programming { get; } = new("programming");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Roleplay { get; } = new("roleplay");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Science { get; } = new("science");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Technology { get; } = new("technology");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Translation { get; } = new("translation");

        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory Trivia { get; } = new("trivia");
        /// <summary>
        ///
        /// </summary>
        public static GetModelsCategory FromValue(string value)
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
                _ => new GetModelsCategory(value),
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
        public bool Equals(GetModelsCategory other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetModelsCategory other && Equals(other);
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
        public static bool operator ==(GetModelsCategory left, GetModelsCategory right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetModelsCategory left, GetModelsCategory right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsCategory value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsCategory? ToEnum(string value)
        {
            return GetModelsCategory.FromValue(value);
        }
    }
}