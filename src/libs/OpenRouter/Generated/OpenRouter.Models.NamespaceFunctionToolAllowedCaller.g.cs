
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NamespaceFunctionToolAllowedCaller : global::System.IEquatable<NamespaceFunctionToolAllowedCaller>
    {
        /// <summary>
        ///
        /// </summary>
        public NamespaceFunctionToolAllowedCaller(string value)
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
        public static NamespaceFunctionToolAllowedCaller Direct { get; } = new("direct");

        /// <summary>
        ///
        /// </summary>
        public static NamespaceFunctionToolAllowedCaller Programmatic { get; } = new("programmatic");
        /// <summary>
        ///
        /// </summary>
        public static NamespaceFunctionToolAllowedCaller FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "direct" => Direct,
                "programmatic" => Programmatic,
                _ => new NamespaceFunctionToolAllowedCaller(value),
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
        public bool Equals(NamespaceFunctionToolAllowedCaller other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NamespaceFunctionToolAllowedCaller other && Equals(other);
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
        public static bool operator ==(NamespaceFunctionToolAllowedCaller left, NamespaceFunctionToolAllowedCaller right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NamespaceFunctionToolAllowedCaller left, NamespaceFunctionToolAllowedCaller right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NamespaceFunctionToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamespaceFunctionToolAllowedCaller value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamespaceFunctionToolAllowedCaller? ToEnum(string value)
        {
            return NamespaceFunctionToolAllowedCaller.FromValue(value);
        }
    }
}