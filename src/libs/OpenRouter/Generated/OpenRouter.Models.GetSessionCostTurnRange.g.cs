
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Filter by the inclusive number of turns in a session.<br/>
    /// Example: 10-49-turns
    /// </summary>
    public readonly partial struct GetSessionCostTurnRange : global::System.IEquatable<GetSessionCostTurnRange>
    {
        /// <summary>
        ///
        /// </summary>
        public GetSessionCostTurnRange(string value)
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
        public static GetSessionCostTurnRange x1Turn { get; } = new("1-turn");

        /// <summary>
        ///
        /// </summary>
        public static GetSessionCostTurnRange x1049Turns { get; } = new("10-49-turns");

        /// <summary>
        ///
        /// </summary>
        public static GetSessionCostTurnRange x29Turns { get; } = new("2-9-turns");

        /// <summary>
        ///
        /// </summary>
        public static GetSessionCostTurnRange x50PlusTurns { get; } = new("50-plus-turns");
        /// <summary>
        ///
        /// </summary>
        public static GetSessionCostTurnRange FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "1-turn" => x1Turn,
                "10-49-turns" => x1049Turns,
                "2-9-turns" => x29Turns,
                "50-plus-turns" => x50PlusTurns,
                _ => new GetSessionCostTurnRange(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "1-turn" => true,
            "10-49-turns" => true,
            "2-9-turns" => true,
            "50-plus-turns" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetSessionCostTurnRange other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetSessionCostTurnRange other && Equals(other);
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
        public static bool operator ==(GetSessionCostTurnRange left, GetSessionCostTurnRange right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetSessionCostTurnRange left, GetSessionCostTurnRange right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSessionCostTurnRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionCostTurnRange value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionCostTurnRange? ToEnum(string value)
        {
            return GetSessionCostTurnRange.FromValue(value);
        }
    }
}