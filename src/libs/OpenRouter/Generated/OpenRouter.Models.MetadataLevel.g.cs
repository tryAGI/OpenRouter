
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
    /// Example: enabled
    /// </summary>
    public readonly partial struct MetadataLevel : global::System.IEquatable<MetadataLevel>
    {
        /// <summary>
        ///
        /// </summary>
        public MetadataLevel(string value)
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
        public static MetadataLevel Disabled { get; } = new("disabled");

        /// <summary>
        ///
        /// </summary>
        public static MetadataLevel Enabled { get; } = new("enabled");
        /// <summary>
        ///
        /// </summary>
        public static MetadataLevel FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "disabled" => Disabled,
                "enabled" => Enabled,
                _ => new MetadataLevel(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "disabled" => true,
            "enabled" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(MetadataLevel other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataLevel other && Equals(other);
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
        public static bool operator ==(MetadataLevel left, MetadataLevel right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MetadataLevel left, MetadataLevel right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataLevel value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataLevel? ToEnum(string value)
        {
            return MetadataLevel.FromValue(value);
        }
    }
}