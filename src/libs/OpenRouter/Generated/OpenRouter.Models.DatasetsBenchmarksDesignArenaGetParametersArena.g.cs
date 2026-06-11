
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Arena to query. Defaults to `models`.<br/>
    /// Default Value: models
    /// </summary>
    public enum DatasetsBenchmarksDesignArenaGetParametersArena
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
        /// 
        /// </summary>
        Models,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsBenchmarksDesignArenaGetParametersArenaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsBenchmarksDesignArenaGetParametersArena value)
        {
            return value switch
            {
                DatasetsBenchmarksDesignArenaGetParametersArena.Agents => "agents",
                DatasetsBenchmarksDesignArenaGetParametersArena.Builders => "builders",
                DatasetsBenchmarksDesignArenaGetParametersArena.Models => "models",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsBenchmarksDesignArenaGetParametersArena? ToEnum(string value)
        {
            return value switch
            {
                "agents" => DatasetsBenchmarksDesignArenaGetParametersArena.Agents,
                "builders" => DatasetsBenchmarksDesignArenaGetParametersArena.Builders,
                "models" => DatasetsBenchmarksDesignArenaGetParametersArena.Models,
                _ => null,
            };
        }
    }
}