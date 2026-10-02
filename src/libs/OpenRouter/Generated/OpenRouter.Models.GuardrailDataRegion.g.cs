
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// An OpenRouter data region: `global` (https://openrouter.ai), `europe` (https://eu.openrouter.ai), or `us` (https://us.openrouter.ai)<br/>
    /// Example: europe
    /// </summary>
    public readonly partial struct GuardrailDataRegion : global::System.IEquatable<GuardrailDataRegion>
    {
        /// <summary>
        ///
        /// </summary>
        public GuardrailDataRegion(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `global` (https://openrouter.ai), `europe` (https://eu.openrouter.ai), or `us` (https://us.openrouter.ai)
        /// </summary>
        public static GuardrailDataRegion Europe { get; } = new("europe");

        /// <summary>
        /// `global` (https://openrouter.ai), `europe` (https://eu.openrouter.ai), or `us` (https://us.openrouter.ai)
        /// </summary>
        public static GuardrailDataRegion Global { get; } = new("global");

        /// <summary>
        /// `global` (https://openrouter.ai), `europe` (https://eu.openrouter.ai), or `us` (https://us.openrouter.ai)
        /// </summary>
        public static GuardrailDataRegion Us { get; } = new("us");
        /// <summary>
        ///
        /// </summary>
        public static GuardrailDataRegion FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "europe" => Europe,
                "global" => Global,
                "us" => Us,
                _ => new GuardrailDataRegion(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "europe" => true,
            "global" => true,
            "us" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GuardrailDataRegion other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailDataRegion other && Equals(other);
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
        public static bool operator ==(GuardrailDataRegion left, GuardrailDataRegion right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GuardrailDataRegion left, GuardrailDataRegion right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailDataRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailDataRegion value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailDataRegion? ToEnum(string value)
        {
            return GuardrailDataRegion.FromValue(value);
        }
    }
}