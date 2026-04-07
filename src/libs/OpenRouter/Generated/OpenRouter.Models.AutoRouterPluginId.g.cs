
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoRouterPluginId
    {
        /// <summary>
        /// 
        /// </summary>
        AutoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoRouterPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoRouterPluginId value)
        {
            return value switch
            {
                AutoRouterPluginId.AutoRouter => "auto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoRouterPluginId? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => AutoRouterPluginId.AutoRouter,
                _ => null,
            };
        }
    }
}