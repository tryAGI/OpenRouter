
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationPluginId
    {
        /// <summary>
        /// 
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationPluginIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationPluginId value)
        {
            return value switch
            {
                ModerationPluginId.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationPluginId? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ModerationPluginId.Moderation,
                _ => null,
            };
        }
    }
}