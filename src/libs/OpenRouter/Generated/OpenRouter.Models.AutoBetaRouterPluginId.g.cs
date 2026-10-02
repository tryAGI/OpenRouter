
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoBetaRouterPluginId
    {
        /// <summary>
        ///
        /// </summary>
        AutoBetaRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoBetaRouterPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoBetaRouterPluginId value)
        {
            return value switch
            {
                AutoBetaRouterPluginId.AutoBetaRouter => "auto-beta-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoBetaRouterPluginId? ToEnum(string value)
        {
            return value switch
            {
                "auto-beta-router" => AutoBetaRouterPluginId.AutoBetaRouter,
                _ => null,
            };
        }
    }
}