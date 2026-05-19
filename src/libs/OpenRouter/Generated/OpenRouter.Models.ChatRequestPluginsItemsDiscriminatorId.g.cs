
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestPluginsItemsDiscriminatorId
    {
        /// <summary>
        /// 
        /// </summary>
        AutoRouter,
        /// <summary>
        /// 
        /// </summary>
        ContextCompression,
        /// <summary>
        /// 
        /// </summary>
        FileParser,
        /// <summary>
        /// 
        /// </summary>
        Fusion,
        /// <summary>
        /// 
        /// </summary>
        Moderation,
        /// <summary>
        /// 
        /// </summary>
        ParetoRouter,
        /// <summary>
        /// 
        /// </summary>
        ResponseHealing,
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        WebFetch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsDiscriminatorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsDiscriminatorId value)
        {
            return value switch
            {
                ChatRequestPluginsItemsDiscriminatorId.AutoRouter => "auto-router",
                ChatRequestPluginsItemsDiscriminatorId.ContextCompression => "context-compression",
                ChatRequestPluginsItemsDiscriminatorId.FileParser => "file-parser",
                ChatRequestPluginsItemsDiscriminatorId.Fusion => "fusion",
                ChatRequestPluginsItemsDiscriminatorId.Moderation => "moderation",
                ChatRequestPluginsItemsDiscriminatorId.ParetoRouter => "pareto-router",
                ChatRequestPluginsItemsDiscriminatorId.ResponseHealing => "response-healing",
                ChatRequestPluginsItemsDiscriminatorId.Web => "web",
                ChatRequestPluginsItemsDiscriminatorId.WebFetch => "web-fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsDiscriminatorId? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => ChatRequestPluginsItemsDiscriminatorId.AutoRouter,
                "context-compression" => ChatRequestPluginsItemsDiscriminatorId.ContextCompression,
                "file-parser" => ChatRequestPluginsItemsDiscriminatorId.FileParser,
                "fusion" => ChatRequestPluginsItemsDiscriminatorId.Fusion,
                "moderation" => ChatRequestPluginsItemsDiscriminatorId.Moderation,
                "pareto-router" => ChatRequestPluginsItemsDiscriminatorId.ParetoRouter,
                "response-healing" => ChatRequestPluginsItemsDiscriminatorId.ResponseHealing,
                "web" => ChatRequestPluginsItemsDiscriminatorId.Web,
                "web-fetch" => ChatRequestPluginsItemsDiscriminatorId.WebFetch,
                _ => null,
            };
        }
    }
}