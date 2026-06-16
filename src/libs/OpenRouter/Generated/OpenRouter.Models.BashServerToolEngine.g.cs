
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Which bash engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) and "native" use native passthrough, returning the tool call to your application to run client-side; OpenRouter does not execute the commands.
    /// </summary>
    public enum BashServerToolEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Native,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashServerToolEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashServerToolEngine value)
        {
            return value switch
            {
                BashServerToolEngine.Auto => "auto",
                BashServerToolEngine.Native => "native",
                BashServerToolEngine.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashServerToolEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BashServerToolEngine.Auto,
                "native" => BashServerToolEngine.Native,
                "openrouter" => BashServerToolEngine.Openrouter,
                _ => null,
            };
        }
    }
}