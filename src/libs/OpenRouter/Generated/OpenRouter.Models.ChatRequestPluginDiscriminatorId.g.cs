
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatRequestPluginDiscriminatorId
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
    public static class ChatRequestPluginDiscriminatorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginDiscriminatorId value)
        {
            return value switch
            {
                ChatRequestPluginDiscriminatorId.Alignment => "alignment",
                ChatRequestPluginDiscriminatorId.AutoBetaRouter => "auto-beta-router",
                ChatRequestPluginDiscriminatorId.AutoRouter => "auto-router",
                ChatRequestPluginDiscriminatorId.ContextCompression => "context-compression",
                ChatRequestPluginDiscriminatorId.FileParser => "file-parser",
                ChatRequestPluginDiscriminatorId.Fusion => "fusion",
                ChatRequestPluginDiscriminatorId.JevRouter => "jev-router",
                ChatRequestPluginDiscriminatorId.Moderation => "moderation",
                ChatRequestPluginDiscriminatorId.ParetoRouter => "pareto-router",
                ChatRequestPluginDiscriminatorId.ResponseHealing => "response-healing",
                ChatRequestPluginDiscriminatorId.SwitchyardRouter => "switchyard-router",
                ChatRequestPluginDiscriminatorId.Web => "web",
                ChatRequestPluginDiscriminatorId.WebFetch => "web-fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginDiscriminatorId? ToEnum(string value)
        {
            return value switch
            {
                "alignment" => ChatRequestPluginDiscriminatorId.Alignment,
                "auto-beta-router" => ChatRequestPluginDiscriminatorId.AutoBetaRouter,
                "auto-router" => ChatRequestPluginDiscriminatorId.AutoRouter,
                "context-compression" => ChatRequestPluginDiscriminatorId.ContextCompression,
                "file-parser" => ChatRequestPluginDiscriminatorId.FileParser,
                "fusion" => ChatRequestPluginDiscriminatorId.Fusion,
                "jev-router" => ChatRequestPluginDiscriminatorId.JevRouter,
                "moderation" => ChatRequestPluginDiscriminatorId.Moderation,
                "pareto-router" => ChatRequestPluginDiscriminatorId.ParetoRouter,
                "response-healing" => ChatRequestPluginDiscriminatorId.ResponseHealing,
                "switchyard-router" => ChatRequestPluginDiscriminatorId.SwitchyardRouter,
                "web" => ChatRequestPluginDiscriminatorId.Web,
                "web-fetch" => ChatRequestPluginDiscriminatorId.WebFetch,
                _ => null,
            };
        }
    }
}