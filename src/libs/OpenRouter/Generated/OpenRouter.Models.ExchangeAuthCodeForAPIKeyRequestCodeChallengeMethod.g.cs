
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The method used to generate the code challenge<br/>
    /// Example: S256
    /// </summary>
    public readonly partial struct ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod : global::System.IEquatable<ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod>
    {
        /// <summary>
        ///
        /// </summary>
        public ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod(string value)
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
        public static ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod S256 { get; } = new("S256");

        /// <summary>
        ///
        /// </summary>
        public static ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod Plain { get; } = new("plain");
        /// <summary>
        ///
        /// </summary>
        public static ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "S256" => S256,
                "plain" => Plain,
                _ => new ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "S256" => true,
            "plain" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod other && Equals(other);
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
        public static bool operator ==(ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod left, ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod left, ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod? ToEnum(string value)
        {
            return ExchangeAuthCodeForAPIKeyRequestCodeChallengeMethod.FromValue(value);
        }
    }
}