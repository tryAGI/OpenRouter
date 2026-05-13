
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestPluginsItemsDiscriminatorId
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsDiscriminatorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsDiscriminatorId value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsDiscriminatorId.AutoRouter => "auto-router",
                MessagesRequestPluginsItemsDiscriminatorId.ContextCompression => "context-compression",
                MessagesRequestPluginsItemsDiscriminatorId.FileParser => "file-parser",
                MessagesRequestPluginsItemsDiscriminatorId.Fusion => "fusion",
                MessagesRequestPluginsItemsDiscriminatorId.Moderation => "moderation",
                MessagesRequestPluginsItemsDiscriminatorId.ParetoRouter => "pareto-router",
                MessagesRequestPluginsItemsDiscriminatorId.ResponseHealing => "response-healing",
                MessagesRequestPluginsItemsDiscriminatorId.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsDiscriminatorId? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => MessagesRequestPluginsItemsDiscriminatorId.AutoRouter,
                "context-compression" => MessagesRequestPluginsItemsDiscriminatorId.ContextCompression,
                "file-parser" => MessagesRequestPluginsItemsDiscriminatorId.FileParser,
                "fusion" => MessagesRequestPluginsItemsDiscriminatorId.Fusion,
                "moderation" => MessagesRequestPluginsItemsDiscriminatorId.Moderation,
                "pareto-router" => MessagesRequestPluginsItemsDiscriminatorId.ParetoRouter,
                "response-healing" => MessagesRequestPluginsItemsDiscriminatorId.ResponseHealing,
                "web" => MessagesRequestPluginsItemsDiscriminatorId.Web,
                _ => null,
            };
        }
    }
}