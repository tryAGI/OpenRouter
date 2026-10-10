
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AdditionalToolsItemToolAllowedCaller : global::System.IEquatable<AdditionalToolsItemToolAllowedCaller>
    {
        /// <summary>
        ///
        /// </summary>
        public AdditionalToolsItemToolAllowedCaller(string value)
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
        public static AdditionalToolsItemToolAllowedCaller Direct { get; } = new("direct");

        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemToolAllowedCaller Programmatic { get; } = new("programmatic");
        /// <summary>
        ///
        /// </summary>
        public static AdditionalToolsItemToolAllowedCaller FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "direct" => Direct,
                "programmatic" => Programmatic,
                _ => new AdditionalToolsItemToolAllowedCaller(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "direct" => true,
            "programmatic" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AdditionalToolsItemToolAllowedCaller other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AdditionalToolsItemToolAllowedCaller other && Equals(other);
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
        public static bool operator ==(AdditionalToolsItemToolAllowedCaller left, AdditionalToolsItemToolAllowedCaller right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AdditionalToolsItemToolAllowedCaller left, AdditionalToolsItemToolAllowedCaller right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsItemToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsItemToolAllowedCaller value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsItemToolAllowedCaller? ToEnum(string value)
        {
            return AdditionalToolsItemToolAllowedCaller.FromValue(value);
        }
    }
}