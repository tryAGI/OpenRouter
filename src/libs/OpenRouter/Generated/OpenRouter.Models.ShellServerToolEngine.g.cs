
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Which shell engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) keeps the provider's native hosted shell when available (OpenAI); on other providers the call is routed to the OpenRouter sandbox.<br/>
    /// Example: openrouter
    /// </summary>
    public readonly partial struct ShellServerToolEngine : global::System.IEquatable<ShellServerToolEngine>
    {
        /// <summary>
        ///
        /// </summary>
        public ShellServerToolEngine(string value)
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
        public static ShellServerToolEngine Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ShellServerToolEngine Openrouter { get; } = new("openrouter");
        /// <summary>
        ///
        /// </summary>
        public static ShellServerToolEngine FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "openrouter" => Openrouter,
                _ => new ShellServerToolEngine(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "openrouter" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ShellServerToolEngine other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShellServerToolEngine other && Equals(other);
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
        public static bool operator ==(ShellServerToolEngine left, ShellServerToolEngine right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ShellServerToolEngine left, ShellServerToolEngine right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellServerToolEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellServerToolEngine value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellServerToolEngine? ToEnum(string value)
        {
            return ShellServerToolEngine.FromValue(value);
        }
    }
}