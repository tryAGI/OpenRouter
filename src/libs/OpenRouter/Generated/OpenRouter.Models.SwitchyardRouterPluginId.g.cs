
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SwitchyardRouterPluginId
    {
        /// <summary>
        ///
        /// </summary>
        SwitchyardRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwitchyardRouterPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwitchyardRouterPluginId value)
        {
            return value switch
            {
                SwitchyardRouterPluginId.SwitchyardRouter => "switchyard-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwitchyardRouterPluginId? ToEnum(string value)
        {
            return value switch
            {
                "switchyard-router" => SwitchyardRouterPluginId.SwitchyardRouter,
                _ => null,
            };
        }
    }
}