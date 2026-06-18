
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Design Arena only: arena to query. Defaults to `models` when source is `design-arena`.
    /// </summary>
    public enum BenchmarksGetParametersArena
    {
        /// <summary>
        /// 
        /// </summary>
        Agents,
        /// <summary>
        /// 
        /// </summary>
        Builders,
        /// <summary>
        /// arena to query. Defaults to `models` when source is `design-arena`.
        /// </summary>
        Models,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksGetParametersArenaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksGetParametersArena value)
        {
            return value switch
            {
                BenchmarksGetParametersArena.Agents => "agents",
                BenchmarksGetParametersArena.Builders => "builders",
                BenchmarksGetParametersArena.Models => "models",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksGetParametersArena? ToEnum(string value)
        {
            return value switch
            {
                "agents" => BenchmarksGetParametersArena.Agents,
                "builders" => BenchmarksGetParametersArena.Builders,
                "models" => BenchmarksGetParametersArena.Models,
                _ => null,
            };
        }
    }
}