
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdditionalToolsItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Critic,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Discriminator,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalToolsItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalToolsItemRole value)
        {
            return value switch
            {
                AdditionalToolsItemRole.Assistant => "assistant",
                AdditionalToolsItemRole.Critic => "critic",
                AdditionalToolsItemRole.Developer => "developer",
                AdditionalToolsItemRole.Discriminator => "discriminator",
                AdditionalToolsItemRole.System => "system",
                AdditionalToolsItemRole.Tool => "tool",
                AdditionalToolsItemRole.Unknown => "unknown",
                AdditionalToolsItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalToolsItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AdditionalToolsItemRole.Assistant,
                "critic" => AdditionalToolsItemRole.Critic,
                "developer" => AdditionalToolsItemRole.Developer,
                "discriminator" => AdditionalToolsItemRole.Discriminator,
                "system" => AdditionalToolsItemRole.System,
                "tool" => AdditionalToolsItemRole.Tool,
                "unknown" => AdditionalToolsItemRole.Unknown,
                "user" => AdditionalToolsItemRole.User,
                _ => null,
            };
        }
    }
}