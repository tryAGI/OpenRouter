
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesRequestPluginsItemsDiscriminatorId
    {
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
    public static class ResponsesRequestPluginsItemsDiscriminatorIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsDiscriminatorId value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsDiscriminatorId.AutoBetaRouter => "auto-beta-router",
                ResponsesRequestPluginsItemsDiscriminatorId.AutoRouter => "auto-router",
                ResponsesRequestPluginsItemsDiscriminatorId.ContextCompression => "context-compression",
                ResponsesRequestPluginsItemsDiscriminatorId.FileParser => "file-parser",
                ResponsesRequestPluginsItemsDiscriminatorId.Fusion => "fusion",
                ResponsesRequestPluginsItemsDiscriminatorId.Moderation => "moderation",
                ResponsesRequestPluginsItemsDiscriminatorId.ParetoRouter => "pareto-router",
                ResponsesRequestPluginsItemsDiscriminatorId.ResponseHealing => "response-healing",
                ResponsesRequestPluginsItemsDiscriminatorId.Web => "web",
                ResponsesRequestPluginsItemsDiscriminatorId.WebFetch => "web-fetch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorId? ToEnum(string value)
        {
            return value switch
            {
                "auto-beta-router" => ResponsesRequestPluginsItemsDiscriminatorId.AutoBetaRouter,
                "auto-router" => ResponsesRequestPluginsItemsDiscriminatorId.AutoRouter,
                "context-compression" => ResponsesRequestPluginsItemsDiscriminatorId.ContextCompression,
                "file-parser" => ResponsesRequestPluginsItemsDiscriminatorId.FileParser,
                "fusion" => ResponsesRequestPluginsItemsDiscriminatorId.Fusion,
                "moderation" => ResponsesRequestPluginsItemsDiscriminatorId.Moderation,
                "pareto-router" => ResponsesRequestPluginsItemsDiscriminatorId.ParetoRouter,
                "response-healing" => ResponsesRequestPluginsItemsDiscriminatorId.ResponseHealing,
                "web" => ResponsesRequestPluginsItemsDiscriminatorId.Web,
                "web-fetch" => ResponsesRequestPluginsItemsDiscriminatorId.WebFetch,
                _ => null,
            };
        }
    }
}