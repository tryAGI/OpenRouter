
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Design Arena only: arena to query. Defaults to `models` when source is `design-arena`.<br/>
    /// Example: models
    /// </summary>
    public readonly partial struct GetBenchmarksArena : global::System.IEquatable<GetBenchmarksArena>
    {
        /// <summary>
        ///
        /// </summary>
        public GetBenchmarksArena(string value)
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
        public static GetBenchmarksArena Agents { get; } = new("agents");

        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksArena Builders { get; } = new("builders");

        /// <summary>
        /// arena to query. Defaults to `models` when source is `design-arena`.
        /// </summary>
        public static GetBenchmarksArena Models { get; } = new("models");
        /// <summary>
        ///
        /// </summary>
        public static GetBenchmarksArena FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "agents" => Agents,
                "builders" => Builders,
                "models" => Models,
                _ => new GetBenchmarksArena(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "agents" => true,
            "builders" => true,
            "models" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GetBenchmarksArena other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetBenchmarksArena other && Equals(other);
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
        public static bool operator ==(GetBenchmarksArena left, GetBenchmarksArena right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetBenchmarksArena left, GetBenchmarksArena right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBenchmarksArenaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBenchmarksArena value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBenchmarksArena? ToEnum(string value)
        {
            return GetBenchmarksArena.FromValue(value);
        }
    }
}