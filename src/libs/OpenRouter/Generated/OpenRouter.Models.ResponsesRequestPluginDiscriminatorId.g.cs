
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponsesRequestPluginDiscriminatorId
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
    public static class ResponsesRequestPluginDiscriminatorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginDiscriminatorId value)
        {
            return value switch
            {
                ResponsesRequestPluginDiscriminatorId.Alignment => "alignment",
                ResponsesRequestPluginDiscriminatorId.AutoBetaRouter => "auto-beta-router",
                ResponsesRequestPluginDiscriminatorId.AutoRouter => "auto-router",
                ResponsesRequestPluginDiscriminatorId.ContextCompression => "context-compression",
                ResponsesRequestPluginDiscriminatorId.FileParser => "file-parser",
                ResponsesRequestPluginDiscriminatorId.Fusion => "fusion",
                ResponsesRequestPluginDiscriminatorId.JevRouter => "jev-router",
                ResponsesRequestPluginDiscriminatorId.Moderation => "moderation",
                ResponsesRequestPluginDiscriminatorId.ParetoRouter => "pareto-router",
                ResponsesRequestPluginDiscriminatorId.ResponseHealing => "response-healing",
                ResponsesRequestPluginDiscriminatorId.SwitchyardRouter => "switchyard-router",
                ResponsesRequestPluginDiscriminatorId.Web => "web",
                ResponsesRequestPluginDiscriminatorId.WebFetch => "web-fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginDiscriminatorId? ToEnum(string value)
        {
            return value switch
            {
                "alignment" => ResponsesRequestPluginDiscriminatorId.Alignment,
                "auto-beta-router" => ResponsesRequestPluginDiscriminatorId.AutoBetaRouter,
                "auto-router" => ResponsesRequestPluginDiscriminatorId.AutoRouter,
                "context-compression" => ResponsesRequestPluginDiscriminatorId.ContextCompression,
                "file-parser" => ResponsesRequestPluginDiscriminatorId.FileParser,
                "fusion" => ResponsesRequestPluginDiscriminatorId.Fusion,
                "jev-router" => ResponsesRequestPluginDiscriminatorId.JevRouter,
                "moderation" => ResponsesRequestPluginDiscriminatorId.Moderation,
                "pareto-router" => ResponsesRequestPluginDiscriminatorId.ParetoRouter,
                "response-healing" => ResponsesRequestPluginDiscriminatorId.ResponseHealing,
                "switchyard-router" => ResponsesRequestPluginDiscriminatorId.SwitchyardRouter,
                "web" => ResponsesRequestPluginDiscriminatorId.Web,
                "web-fetch" => ResponsesRequestPluginDiscriminatorId.WebFetch,
                _ => null,
            };
        }
    }
}