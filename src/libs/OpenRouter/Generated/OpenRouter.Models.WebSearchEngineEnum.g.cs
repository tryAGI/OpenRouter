
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    public enum WebSearchEngineEnum
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
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchEngineEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchEngineEnum value)
        {
            return value switch
            {
                WebSearchEngineEnum.Auto => "auto",
                WebSearchEngineEnum.Exa => "exa",
                WebSearchEngineEnum.Firecrawl => "firecrawl",
                WebSearchEngineEnum.Native => "native",
                WebSearchEngineEnum.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchEngineEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => WebSearchEngineEnum.Auto,
                "exa" => WebSearchEngineEnum.Exa,
                "firecrawl" => WebSearchEngineEnum.Firecrawl,
                "native" => WebSearchEngineEnum.Native,
                "parallel" => WebSearchEngineEnum.Parallel,
                _ => null,
            };
        }
    }
}