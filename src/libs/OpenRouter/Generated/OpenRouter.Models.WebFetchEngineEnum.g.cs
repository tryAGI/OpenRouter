
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Which fetch engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in fetch. "exa" uses Exa Contents API. "openrouter" uses direct HTTP fetch. "firecrawl" uses Firecrawl scrape (requires BYOK). "parallel" uses the Parallel extract API.
    /// </summary>
    public enum WebFetchEngineEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Exa,
        /// <summary>
        /// 
        /// </summary>
        Firecrawl,
        /// <summary>
        /// 
        /// </summary>
        Native,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebFetchEngineEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebFetchEngineEnum value)
        {
            return value switch
            {
                WebFetchEngineEnum.Auto => "auto",
                WebFetchEngineEnum.Exa => "exa",
                WebFetchEngineEnum.Firecrawl => "firecrawl",
                WebFetchEngineEnum.Native => "native",
                WebFetchEngineEnum.Openrouter => "openrouter",
                WebFetchEngineEnum.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebFetchEngineEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => WebFetchEngineEnum.Auto,
                "exa" => WebFetchEngineEnum.Exa,
                "firecrawl" => WebFetchEngineEnum.Firecrawl,
                "native" => WebFetchEngineEnum.Native,
                "openrouter" => WebFetchEngineEnum.Openrouter,
                "parallel" => WebFetchEngineEnum.Parallel,
                _ => null,
            };
        }
    }
}