
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Whether the workspace's saved provider order was applied ('enforce') or only logged ('shadow') for the request this attempt belongs to; only present when the workspace has a saved order<br/>
    /// Example: shadow
    /// </summary>
    public readonly partial struct ProviderResponseProviderSortOrderMode : global::System.IEquatable<ProviderResponseProviderSortOrderMode>
    {
        /// <summary>
        ///
        /// </summary>
        public ProviderResponseProviderSortOrderMode(string value)
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
        public static ProviderResponseProviderSortOrderMode Enforce { get; } = new("enforce");

        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderSortOrderMode Shadow { get; } = new("shadow");
        /// <summary>
        ///
        /// </summary>
        public static ProviderResponseProviderSortOrderMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "enforce" => Enforce,
                "shadow" => Shadow,
                _ => new ProviderResponseProviderSortOrderMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "enforce" => true,
            "shadow" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ProviderResponseProviderSortOrderMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderResponseProviderSortOrderMode other && Equals(other);
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
        public static bool operator ==(ProviderResponseProviderSortOrderMode left, ProviderResponseProviderSortOrderMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderResponseProviderSortOrderMode left, ProviderResponseProviderSortOrderMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResponseProviderSortOrderModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResponseProviderSortOrderMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResponseProviderSortOrderMode? ToEnum(string value)
        {
            return ProviderResponseProviderSortOrderMode.FromValue(value);
        }
    }
}