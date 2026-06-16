
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Which shell engine to use. "openrouter" runs commands server-side in the OpenRouter sandbox. "auto" (default) keeps the provider's native hosted shell when available (OpenAI); on other providers the call is routed to the OpenRouter sandbox.
    /// </summary>
    public enum ShellServerToolEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShellServerToolEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShellServerToolEngine value)
        {
            return value switch
            {
                ShellServerToolEngine.Auto => "auto",
                ShellServerToolEngine.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShellServerToolEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ShellServerToolEngine.Auto,
                "openrouter" => ShellServerToolEngine.Openrouter,
                _ => null,
            };
        }
    }
}