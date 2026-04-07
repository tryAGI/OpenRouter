
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseHealingPluginId
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseHealingPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseHealingPluginId value)
        {
            return value switch
            {
                ResponseHealingPluginId.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseHealingPluginId? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => ResponseHealingPluginId.ResponseHealing,
                _ => null,
            };
        }
    }
}