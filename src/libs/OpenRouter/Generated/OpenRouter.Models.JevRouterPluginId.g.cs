
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum JevRouterPluginId
    {
        /// <summary>
        ///
        /// </summary>
        JevRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JevRouterPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JevRouterPluginId value)
        {
            return value switch
            {
                JevRouterPluginId.JevRouter => "jev-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JevRouterPluginId? ToEnum(string value)
        {
            return value switch
            {
                "jev-router" => JevRouterPluginId.JevRouter,
                _ => null,
            };
        }
    }
}