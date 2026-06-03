
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Which message roles to scan for prompt injection. Only applies to the regex-prompt-injection builtin. Defaults to all_messages.
    /// </summary>
    public enum PromptInjectionScanScope
    {
        /// <summary>
        /// 
        /// </summary>
        AllMessages,
        /// <summary>
        /// 
        /// </summary>
        UserOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptInjectionScanScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptInjectionScanScope value)
        {
            return value switch
            {
                PromptInjectionScanScope.AllMessages => "all_messages",
                PromptInjectionScanScope.UserOnly => "user_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptInjectionScanScope? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => PromptInjectionScanScope.AllMessages,
                "user_only" => PromptInjectionScanScope.UserOnly,
                _ => null,
            };
        }
    }
}