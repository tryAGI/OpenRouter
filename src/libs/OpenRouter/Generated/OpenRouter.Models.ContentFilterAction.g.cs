
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Action taken when the pattern matches
    /// </summary>
    public enum ContentFilterAction
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Flag,
        /// <summary>
        /// 
        /// </summary>
        Redact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterAction value)
        {
            return value switch
            {
                ContentFilterAction.Block => "block",
                ContentFilterAction.Flag => "flag",
                ContentFilterAction.Redact => "redact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => ContentFilterAction.Block,
                "flag" => ContentFilterAction.Flag,
                "redact" => ContentFilterAction.Redact,
                _ => null,
            };
        }
    }
}