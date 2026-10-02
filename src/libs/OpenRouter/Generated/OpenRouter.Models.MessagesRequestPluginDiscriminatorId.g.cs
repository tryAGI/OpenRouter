
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestPluginDiscriminatorId
    {
        /// <summary>
        ///
        /// </summary>
        Alignment,
        /// <summary>
        ///
        /// </summary>
        AutoBetaRouter,
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
        JevRouter,
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
        SwitchyardRouter,
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
    public static class MessagesRequestPluginDiscriminatorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginDiscriminatorId value)
        {
            return value switch
            {
                MessagesRequestPluginDiscriminatorId.Alignment => "alignment",
                MessagesRequestPluginDiscriminatorId.AutoBetaRouter => "auto-beta-router",
                MessagesRequestPluginDiscriminatorId.AutoRouter => "auto-router",
                MessagesRequestPluginDiscriminatorId.ContextCompression => "context-compression",
                MessagesRequestPluginDiscriminatorId.FileParser => "file-parser",
                MessagesRequestPluginDiscriminatorId.Fusion => "fusion",
                MessagesRequestPluginDiscriminatorId.JevRouter => "jev-router",
                MessagesRequestPluginDiscriminatorId.Moderation => "moderation",
                MessagesRequestPluginDiscriminatorId.ParetoRouter => "pareto-router",
                MessagesRequestPluginDiscriminatorId.ResponseHealing => "response-healing",
                MessagesRequestPluginDiscriminatorId.SwitchyardRouter => "switchyard-router",
                MessagesRequestPluginDiscriminatorId.Web => "web",
                MessagesRequestPluginDiscriminatorId.WebFetch => "web-fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginDiscriminatorId? ToEnum(string value)
        {
            return value switch
            {
                "alignment" => MessagesRequestPluginDiscriminatorId.Alignment,
                "auto-beta-router" => MessagesRequestPluginDiscriminatorId.AutoBetaRouter,
                "auto-router" => MessagesRequestPluginDiscriminatorId.AutoRouter,
                "context-compression" => MessagesRequestPluginDiscriminatorId.ContextCompression,
                "file-parser" => MessagesRequestPluginDiscriminatorId.FileParser,
                "fusion" => MessagesRequestPluginDiscriminatorId.Fusion,
                "jev-router" => MessagesRequestPluginDiscriminatorId.JevRouter,
                "moderation" => MessagesRequestPluginDiscriminatorId.Moderation,
                "pareto-router" => MessagesRequestPluginDiscriminatorId.ParetoRouter,
                "response-healing" => MessagesRequestPluginDiscriminatorId.ResponseHealing,
                "switchyard-router" => MessagesRequestPluginDiscriminatorId.SwitchyardRouter,
                "web" => MessagesRequestPluginDiscriminatorId.Web,
                "web-fetch" => MessagesRequestPluginDiscriminatorId.WebFetch,
                _ => null,
            };
        }
    }
}