
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Loading profile. `portable` serves the `defer_loading` tools with router-built search and call wrappers on any model and keeps the catalog fixed. `universal` defers every wrappable tool behind the same wrappers so the provider-facing tool list never changes, and rebuilds the catalog from each request so tools can be added or removed mid-conversation.
    /// </summary>
    public readonly partial struct DeferredToolsControlProfile : global::System.IEquatable<DeferredToolsControlProfile>
    {
        /// <summary>
        ///
        /// </summary>
        public DeferredToolsControlProfile(string value)
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
        public static DeferredToolsControlProfile Portable { get; } = new("portable");

        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsControlProfile Universal { get; } = new("universal");
        /// <summary>
        ///
        /// </summary>
        public static DeferredToolsControlProfile FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "portable" => Portable,
                "universal" => Universal,
                _ => new DeferredToolsControlProfile(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "portable" => true,
            "universal" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DeferredToolsControlProfile other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeferredToolsControlProfile other && Equals(other);
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
        public static bool operator ==(DeferredToolsControlProfile left, DeferredToolsControlProfile right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DeferredToolsControlProfile left, DeferredToolsControlProfile right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeferredToolsControlProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeferredToolsControlProfile value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeferredToolsControlProfile? ToEnum(string value)
        {
            return DeferredToolsControlProfile.FromValue(value);
        }
    }
}