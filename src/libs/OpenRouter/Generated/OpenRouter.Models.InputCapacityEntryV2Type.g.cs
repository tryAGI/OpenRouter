
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputCapacityEntryV2Type : global::System.IEquatable<InputCapacityEntryV2Type>
    {
        /// <summary>
        ///
        /// </summary>
        public InputCapacityEntryV2Type(string value)
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
        public static InputCapacityEntryV2Type CacheWrite { get; } = new("cache_write");

        /// <summary>
        ///
        /// </summary>
        public static InputCapacityEntryV2Type CachedPrompt { get; } = new("cached_prompt");

        /// <summary>
        ///
        /// </summary>
        public static InputCapacityEntryV2Type Prompt { get; } = new("prompt");
        /// <summary>
        ///
        /// </summary>
        public static InputCapacityEntryV2Type FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "cache_write" => CacheWrite,
                "cached_prompt" => CachedPrompt,
                "prompt" => Prompt,
                _ => new InputCapacityEntryV2Type(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "cache_write" => true,
            "cached_prompt" => true,
            "prompt" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InputCapacityEntryV2Type other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputCapacityEntryV2Type other && Equals(other);
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
        public static bool operator ==(InputCapacityEntryV2Type left, InputCapacityEntryV2Type right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputCapacityEntryV2Type left, InputCapacityEntryV2Type right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputCapacityEntryV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputCapacityEntryV2Type value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputCapacityEntryV2Type? ToEnum(string value)
        {
            return InputCapacityEntryV2Type.FromValue(value);
        }
    }
}