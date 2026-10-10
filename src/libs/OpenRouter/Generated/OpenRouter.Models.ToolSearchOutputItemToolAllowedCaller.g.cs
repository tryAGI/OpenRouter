
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolSearchOutputItemToolAllowedCaller : global::System.IEquatable<ToolSearchOutputItemToolAllowedCaller>
    {
        /// <summary>
        ///
        /// </summary>
        public ToolSearchOutputItemToolAllowedCaller(string value)
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
        public static ToolSearchOutputItemToolAllowedCaller Direct { get; } = new("direct");

        /// <summary>
        ///
        /// </summary>
        public static ToolSearchOutputItemToolAllowedCaller Programmatic { get; } = new("programmatic");
        /// <summary>
        ///
        /// </summary>
        public static ToolSearchOutputItemToolAllowedCaller FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "direct" => Direct,
                "programmatic" => Programmatic,
                _ => new ToolSearchOutputItemToolAllowedCaller(value),
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
        public bool Equals(ToolSearchOutputItemToolAllowedCaller other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolSearchOutputItemToolAllowedCaller other && Equals(other);
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
        public static bool operator ==(ToolSearchOutputItemToolAllowedCaller left, ToolSearchOutputItemToolAllowedCaller right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolSearchOutputItemToolAllowedCaller left, ToolSearchOutputItemToolAllowedCaller right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchOutputItemToolAllowedCallerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchOutputItemToolAllowedCaller value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchOutputItemToolAllowedCaller? ToEnum(string value)
        {
            return ToolSearchOutputItemToolAllowedCaller.FromValue(value);
        }
    }
}